using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Forms;
using ListBox = System.Windows.Forms.ListBox;
using SelectionMode = System.Windows.Forms.SelectionMode;
using TreeView = System.Windows.Forms.TreeView;


namespace DBF_Visual_Redactor
{
    public partial class Form1 : Form
    {
        public class FoldersData
        {
            public string ID { get; set; }
            public string NAME { get; set; }
            public int LEVEL { get; set; }
            public int INDEX { get; set; }
        };
        public class WarehousData
        {
            public string ID { get; set; }
            public string ID_PRCG { get; set; }
            public string NAME { get; set; }
            public string FOLDER { get; set; }
            public decimal WEIGHT { get; set; }
            public decimal INPACK { get; set; }
            public decimal QTY { get; set; }
            public decimal COST1 { get; set; }
        }
        public class RecordsList
        {
            [JsonProperty("VALUE")]
            public string VALUE { get; set; }
            [JsonProperty("NAME")]
            public string NAME { get; set; }
        }
        private bool _draggActive = false;
        private Point _draggStartPoint = new();
        private API apiClient = new API();
        static Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        public string Host = config.AppSettings.Settings["ip"].Value;
        public string Port = config.AppSettings.Settings["port"].Value;
        public bool IsPrev = false;
        private List<WarehousData> _newWarehous;
        private List<FoldersData> _newFolders;
        private List<WarehousData> _prevWarehous;
        private List<FoldersData> _prevFolders;
        private List<WarehousData> _NoSKUWarehous;
        public Form1()
        {
            InitializeComponent();
            treeViewPrev.TabStop = false;
            listBoxItems.TabStop = false;
        }
        // Внесение изменений в ListBox
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1 && IsPrev)
            {
                textBoxID.Text = listBoxItems.GetItemText(listBoxItems.SelectedValue.ToString());
                textBoxID_PRCG.Text = _prevWarehous.Find(x => x.ID == textBoxID.Text).ID_PRCG;
                textBoxName.Text = listBoxItems.GetItemText(listBoxItems.SelectedItem);
                textBoxWeight.Text = _prevWarehous.Find(x => x.ID == textBoxID.Text).WEIGHT.ToString(CultureInfo.InvariantCulture);
                textBoxInPack.Text = _prevWarehous.Find(x => x.ID == textBoxID.Text).INPACK.ToString(CultureInfo.InvariantCulture);
                textBoxQTY.Text = _prevWarehous.Find(x => x.ID == textBoxID.Text).QTY.ToString(CultureInfo.InvariantCulture);
                textBoxCost1.Text = _prevWarehous.Find(x => x.ID == textBoxID.Text).COST1.ToString(CultureInfo.InvariantCulture);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex > -1 && IsPrev)
            {
                foreach (var item in _prevWarehous.Where(x => x.ID == listBoxItems.SelectedValue.ToString()))
                {
                    item.ID = textBoxID.Text;
                    item.ID_PRCG = textBoxID_PRCG.Text;
                    item.NAME = textBoxName.Text;
                    item.FOLDER = comboBoxFolders.SelectedValue.ToString();
                    item.WEIGHT = decimal.Parse(textBoxWeight.Text.Replace(",", "."), CultureInfo.GetCultureInfo("en-US"));
                    item.INPACK = decimal.Parse(textBoxInPack.Text.Replace(",", "."), CultureInfo.GetCultureInfo("en-US"));
                    item.QTY = decimal.Parse(textBoxQTY.Text.Replace(",", "."), CultureInfo.GetCultureInfo("en-US"));
                    item.COST1 = decimal.Parse(textBoxCost1.Text.Replace(",", "."), CultureInfo.GetCultureInfo("en-US"));
                    richTextBoxLogger.Text += $"Произведено изменение данных товара {textBoxName.Text}\n";
                }
            }
        }
        // Настройка Connection Properties
        private void connectionsPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var connBox = new ConnectionForm();
            connBox.ShowDialog();
            var settings = config.AppSettings.Settings;
            settings["ip"].Value = connBox.host;
            settings["port"].Value = connBox.port;
            Host = settings["ip"].Value;
            Port = settings["port"].Value;
        }

        // Export данных в DBF
        IEnumerable<TreeNode> Collect(TreeNodeCollection nodes)
        {
            foreach (TreeNode node in nodes)
            {
                if (node == null) yield break;
                yield return node;
                foreach (var child in Collect(node.Nodes))
                    yield return child;
            }
        }
        private void FoldersExportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _prevFolders.Clear();
            foreach (var node in Collect(treeViewPrev.Nodes))
            {
                var newListFolders = new FoldersData()
                {
                    ID = node.Name,
                    NAME = node.Text,
                    LEVEL = node.Level,
                };
                _prevFolders.Add(newListFolders);
            }
            var output = """
                           {"Fields":[{"Name":"ID","FieldType":"C","Length":55,"DecimalPlaces":0},
                           {"Name":"LEVEL","FieldType":"N","Length":10,"DecimalPlaces":0},
                           {"Name":"NAME","FieldType":"C","Length":100,"DecimalPlaces":0}],"Records":[
                           """;
            for (int i = 0; i < _prevFolders.Count; i++)
            {
                if (_prevFolders[i].NAME.Contains('"'))
                {
                    _prevFolders[i].NAME = _prevFolders[i].NAME.Replace("\"", @"\""");
                }
                output += $$"""
                            [{"Name":"ID","Value":"{{_prevFolders[i].ID}}"},
                            {"Name":"LEVEL","Value":"{{_prevFolders[i].LEVEL}}"},
                            {"Name":"NAME","Value":"{{_prevFolders[i].NAME}}"}],
                            """;
            }
            output = output.Remove(output.Length - 1);
            output += "]}";
            apiClient.PostFolders(Host, Port, output);
            _prevFolders.Clear();
            richTextBoxLogger.Text += "Произведен экспорт Folders\n";
            WarehousExport();
        }

        private void WarehousExport()
        {
            var output = """
                         {"Fields":[{"Name":"ID","FieldType":"C","Length":55,"DecimalPlaces":0},
                         {"Name":"ID_PRCG","FieldType":"C","Length":55,"DecimalPlaces":0},
                         {"Name":"NAME","FieldType":"C","Length":100,"DecimalPlaces":0},
                         {"Name":"FOLDER","FieldType":"C","Length":55,"DecimalPlaces":0},
                         {"Name":"WEIGHT","FieldType":"N","Length":10,"DecimalPlaces":3},
                         {"Name":"INPACK","FieldType":"N","Length":10,"DecimalPlaces":3},
                         {"Name":"QTY","FieldType":"N","Length":10,"DecimalPlaces":3},
                         {"Name":"COST1","FieldType":"N","Length":10,"DecimalPlaces":2}],"Records":[
                         """;
            for (int i = 0; i < _prevWarehous.Count; i++)
            {
                if (_prevWarehous[i].NAME.Contains(@"\"))
                {
                    _prevWarehous[i].NAME = _prevWarehous[i].NAME.Replace(@"\", @"");
                }
                if (_prevWarehous[i].NAME.Contains('"'))
                {
                    _prevWarehous[i].NAME = _prevWarehous[i].NAME.Replace("\"", @"\""");
                }
                output += $$"""
                            [{"Name":"ID","Value":"{{_prevWarehous[i].ID}}"},
                            {"Name":"ID_PRCG","Value":"{{_prevWarehous[i].ID_PRCG}}"},
                            {"Name":"NAME","Value":"{{_prevWarehous[i].NAME}}"},
                            {"Name":"FOLDER","Value":"{{_prevWarehous[i].FOLDER}}"},
                            {"Name":"WEIGHT","Value":"{{_prevWarehous[i].WEIGHT.ToString().Replace(",", ".")}}"},
                            {"Name":"INPACK","Value":"{{_prevWarehous[i].INPACK.ToString().Replace(",", ".")}}"},
                            {"Name":"QTY","Value":"{{_prevWarehous[i].QTY.ToString().Replace(",", ".")}}"},
                            {"Name":"COST1","Value":"{{_newWarehous[i].COST1.ToString().Replace(",", ".")}}"}],
                            """;
            }
            output = output.Remove(output.Length - 1);
            output += "]}";
            apiClient.PostWarehous(Host, Port, output);
            _newWarehous.Clear();
            _prevWarehous.Clear();
            richTextBoxLogger.Text += "Произведен экспорт Warehous\n";
        }
        private void WarehousToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WarehousExport();
        }

        // Import данных из DBF
        private void fOLDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewPrev.Nodes.Clear();
            FoldersExportToolStripMenuItem1.Enabled = true;
            GetNewFolders();
            GetPrevFolders();
            GetWarehous();
            PopulateBaseNodes();
            richTextBoxLogger.Text += "Произведен импорт Folders\n";

        }
        private void fullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoldersExportToolStripMenuItem1.Enabled = true;
            treeViewPrev.Nodes.Clear();
            treeViewPrev.Nodes.Clear();
            GetNewFolders();
            PopulateBaseNodes();
            richTextBoxLogger.Text += "Произведен экспорт полного Warehous\n";
        }
        private void GetNewFolders()
        {
            string json = apiClient.GetFolders(Host, Port).Result;
            var root = JObject.Parse(json);
            var records = root.Last;
            _newFolders = new List<FoldersData>();
            var data = records.Children();
            foreach (JToken result in data)
            {
                var record = JsonConvert.DeserializeObject<List<List<RecordsList>>>(result.ToString());
                if (record != null)
                {
                    for (int i = 0; i < record.Count; i++)
                    {
                        _newFolders.Add(new FoldersData());
                        _newFolders[i].INDEX = i;
                        _newFolders[i].ID = record[i][0].VALUE;
                        _newFolders[i].LEVEL = Convert.ToInt32(record[i][1].VALUE);
                        _newFolders[i].NAME = record[i][2].VALUE;
                    }
                }
            }
        }

        private void FillListBoxNew()
        {
            _NoSKUWarehous = new List<WarehousData>();
            var listWithItems = _prevFolders.Where(x => _newWarehous.Any(x2 => x.ID == x2.FOLDER)); 
            _NoSKUWarehous.AddRange(_newWarehous.Where(x => !_prevWarehous.Any(x2 => x.ID == x2.ID)));
            var newlist = listWithItems.Where(x => _NoSKUWarehous.Any(x2 => x2.FOLDER == x.ID));
            listBoxNew.ValueMember = "ID";
            listBoxNew.DisplayMember = "NAME";
            listBoxNew.DataSource = newlist.ToList();
        }

        private void GetPrevFolders()
        {
            string json = apiClient.GetPrevFolders(Host, Port).Result;
            var root = JObject.Parse(json);
            var records = root.Last;
            _prevFolders = new List<FoldersData>();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            var data = records.Children();
            foreach (JToken result in data)
            {
                var record = JsonConvert.DeserializeObject<List<List<RecordsList>>>(result.ToString());
                if (record != null)
                {
                    for (int i = 0; i < record.Count; i++)
                    {
                        _prevFolders.Add(new FoldersData());
                        _prevFolders[i].INDEX = i;
                        _prevFolders[i].ID = record[i][0].VALUE;
                        _prevFolders[i].LEVEL = Convert.ToInt32(record[i][1].VALUE);
                        _prevFolders[i].NAME = record[i][2].VALUE;
                        comboSource.Add(_prevFolders[i].ID, _prevFolders[i].NAME);
                    }
                }
            }
            comboBoxFolders.ValueMember = "Key";
            comboBoxFolders.DisplayMember = "Value";
            comboBoxFolders.DataSource = comboSource.ToList();
        }

        private void GetWarehous()
        {
            string json = apiClient.GetWarehous(Host, Port).Result;
            var root = JObject.Parse(json);
            var records = root.Last;
            _newWarehous = new List<WarehousData>();
            var data = records.Children();
            foreach (JToken result in data)
            {
                var record = JsonConvert.DeserializeObject<List<List<RecordsList>>>(result.ToString());
                if (record != null)
                {
                    for (int i = 0; i < record.Count; i++)
                    {
                        _newWarehous.Add(new WarehousData());
                        _newWarehous[i].ID = record[i][0].VALUE;
                        _newWarehous[i].ID_PRCG = record[i][1].VALUE;
                        _newWarehous[i].NAME = record[i][2].VALUE;
                        _newWarehous[i].FOLDER = record[i][3].VALUE;
                        _newWarehous[i].WEIGHT = decimal.Parse(record[i][4].VALUE.Replace(".", ","));
                        _newWarehous[i].INPACK = decimal.Parse(record[i][5].VALUE.Replace(".", ","));
                        if (record[i][6].VALUE != "")
                            _newWarehous[i].QTY = decimal.Parse(record[i][6].VALUE.Replace(".", ","));
                        else
                            _newWarehous[i].QTY = 0;
                        _newWarehous[i].COST1 = decimal.Parse(record[i][7].VALUE.Replace(".", ","));
                    }
                }
            }
            GetPrevWarehous();
        }

        private void GetPrevWarehous()
        {
            string json = apiClient.GetPrevWarehous(Host, Port).Result;
            var root = JObject.Parse(json);
            var records = root.Last;
            _prevWarehous = new List<WarehousData>();
            var data = records.Children();
            foreach (JToken result in data)
            {
                var record = JsonConvert.DeserializeObject<List<List<RecordsList>>>(result.ToString());
                if (record != null)
                {
                    for (int i = 0; i < record.Count; i++)
                    {
                        _prevWarehous.Add(new WarehousData());
                        _prevWarehous[i].ID = record[i][0].VALUE;
                        _prevWarehous[i].ID_PRCG = record[i][1].VALUE;
                        _prevWarehous[i].NAME = record[i][2].VALUE;
                        _prevWarehous[i].FOLDER = record[i][3].VALUE;
                        _prevWarehous[i].WEIGHT = decimal.Parse(record[i][4].VALUE.Replace(".", ","));
                        _prevWarehous[i].INPACK = decimal.Parse(record[i][5].VALUE.Replace(".", ","));
                        if (record[i][6].VALUE != "")
                            _prevWarehous[i].QTY = decimal.Parse(record[i][6].VALUE.Replace(".", ","));
                        else
                            _prevWarehous[i].QTY = 0;
                        _prevWarehous[i].COST1 = decimal.Parse(record[i][7].VALUE.Replace(".", ","));
                    }
                }
            }
            FillListBoxNew();
        }

        // treeView логика построения
        public void PopulateBaseNodes()
        {
            treeViewPrev.Nodes.Clear();
            treeViewPrev.BeginUpdate();

            for (var i = 0; i < _prevFolders.Count; i++)
                if (_prevFolders[i].LEVEL == 0)
                {
                    treeViewPrev.Nodes.Add(_prevFolders[i].ID, _prevFolders[i].NAME);
                    treeViewPrev.Nodes[treeViewPrev.Nodes.Count - 1].Tag = _prevFolders[i];
                }

            for (var i = 0; i < treeViewPrev.Nodes.Count; i++)
                PopulateChilds(treeViewPrev.Nodes[i]);
            treeViewPrev.EndUpdate();
        } // Объявление родительских узлов
        public void PopulateChilds(TreeNode parentNode)
        {
            var parentRed = (FoldersData)parentNode.Tag;

            for (var i = parentRed.INDEX + 1; i < _prevFolders.Count; i++)
            {
                if (_prevFolders[i].LEVEL == parentRed.LEVEL + 1)
                {
                    parentNode.Nodes.Add(_prevFolders[i].ID, _prevFolders[i].NAME);
                    parentNode.Nodes[parentNode.Nodes.Count - 1].Tag = _prevFolders[i];
                    PopulateChilds(parentNode.Nodes[parentNode.Nodes.Count - 1]);
                }

                if (_prevFolders[i].LEVEL <= parentRed.LEVEL) break;
            }
        }  // Объявление дочерних узлов
        // treeView создание новых веток
        // treeView редактирование названий FOLDERS
        private bool ContainsNode(TreeNode node, TreeNode targetNode)
        {
            if (targetNode.Parent == null) return false;
            if (targetNode.Parent.Equals(node)) return true;
            return ContainsNode(node, targetNode.Parent);
        }
        private void listBox2_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            treeViewPrev.Focus();
        }
        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        /*
        Методы listBox.Mouse|Down|Move|Up реализованы представленным способом
        из-за возникновений конфликта во время редактирования элемента WAREHOUS
        */
        private void listBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && listBoxItems.SelectedIndex > -1)
            {
                _draggActive = true;
                _draggStartPoint = new Point(e.X, e.Y);
                if (_draggActive == false)
                {
                    int y = e.Y / listBoxItems.ItemHeight;
                    if (y < listBoxItems.Items.Count)
                    {
                        listBoxItems.SelectedIndex = listBoxItems.TopIndex + y;
                    }
                }
            }
        }
        private void listBox2_MouseMove(object sender, MouseEventArgs e)
        {
            if (_draggActive)
            {
                if (Math.Abs(e.X - _draggStartPoint.X) > 1 || Math.Abs(e.Y - _draggStartPoint.Y) > 1)
                    StartDragging();
            }
        }
        private void listBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (_draggActive)
                _draggActive = false;
        }
        private void StartDragging()
        {
            _draggActive = false;
            listBoxItems.DoDragDrop(listBoxItems.SelectedItem, DragDropEffects.Move);

        }

        private void treeViewPrev_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            IsPrev = true;
            textBoxID.Text = null;
            textBoxID_PRCG.Text = null;
            textBoxName.Text = null;
            comboBoxFolders.Text = null;
            textBoxWeight.Text = null;
            textBoxInPack.Text = null;
            textBoxQTY.Text = null;
            textBoxCost1.Text = null;
            if (treeViewPrev.Nodes.Count > 0)
            {
                listBoxItems.DisplayMember = "Name";
                listBoxItems.ValueMember = "ID";
                listBoxItems.DataSource = _prevWarehous.Where(x => x.FOLDER == e.Node.Name).ToList();
                comboBoxFolders.Text = e.Node.Text;
            }
        }

        private void treeViewPrev_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeViewPrev.SelectedNode.BeginEdit();
        }

        private void treeViewPrev_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void treeViewPrev_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeViewPrev_DragDrop(object sender, DragEventArgs e)
        {
            var targetNode = treeViewPrev.GetNodeAt(treeViewPrev.PointToClient(new Point(e.X, e.Y)));
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                var draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
                if (targetNode == null && draggedNode != null)
                {
                    draggedNode.Remove();
                    treeViewPrev.Nodes.Add(draggedNode);
                    richTextBoxLogger.Text += $"Папка {draggedNode.Text} перемещена на 0 уровень.\n";
                    _prevFolders.Find(x => x.ID == draggedNode.Name).LEVEL = 0;
                }
                else if (draggedNode != null && !draggedNode.Equals(targetNode) &&
                         !ContainsNode(draggedNode, targetNode))
                {
                    draggedNode.Remove();
                    targetNode.Nodes.Add(draggedNode);
                    targetNode.Expand();
                    richTextBoxLogger.Text += $"Перемещена папка {draggedNode.Text} в папку {targetNode.Text}.\n" +
                                              $"Папка {draggedNode.Text} находится на {draggedNode.Level} уровне.\n";
                    try
                    {
                        _prevFolders.Find(x => x.ID == draggedNode.Name).LEVEL = draggedNode.Level;
                    }
                    catch
                    {
                        _prevFolders.Find(x => x.ID == draggedNode.Name).LEVEL = draggedNode.Level;
                        draggedNode.BackColor = Color.White;
                    }
                }
            }
            else if (IsPrev)
            {
                foreach (var item in listBoxItems.SelectedItems)
                {
                    var result = listBoxItems.GetItemText(item);
                    string newFolder = _prevWarehous.Find(x => x.NAME == result).FOLDER;
                    string lastFolder = _prevFolders.Find(x => x.ID == newFolder).NAME;
                    _prevWarehous.Find(x => x.NAME == result).FOLDER = targetNode.Name;
                    listBoxItems.Update();
                    richTextBoxLogger.Text += $"Перемещена папка {result}\nв папку {targetNode.Text}.\n" +
                                              $"Прошлая папка {lastFolder}.\n";
                }
            }
            else if (!IsPrev)
            {
                foreach (var item in listBoxItems.SelectedItems)
                {
                    var result = listBoxItems.GetItemText(item);
                    string newFolder = _NoSKUWarehous.Find(x => x.NAME == result).FOLDER;
                    string lastFolder = _prevFolders.Find(x => x.ID == newFolder).NAME;
                    var newItem = _NoSKUWarehous.Find(x => x.NAME == result);
                    _NoSKUWarehous.Find(x => x.NAME == result).FOLDER = targetNode.Name;
                    _newWarehous.Remove(newItem);
                    _NoSKUWarehous.Remove(newItem);
                    _prevWarehous.Add(newItem);
                    listBoxItems.Update();
                    richTextBoxLogger.Text += $"Перемещена папка {result}\nв папку {targetNode.Text}.\n" +
                                              $"Прошлая папка {lastFolder}.\n";
                }
            }
        }

        private void treeViewPrev_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            foreach (var item in _prevFolders.Where(x => x.ID == e.Node.Name))
                item.NAME = e.Label;
            richTextBoxLogger.Text += $"Измененно название папки. Прошлое имя = {e.Node.Text}, новое имя = {e.Label}\n";
        }

        private void treeViewPrev_DragOver(object sender, DragEventArgs e)
        {
            var targetPoint = treeViewPrev.PointToClient(new Point(e.X, e.Y));
            treeViewPrev.SelectedNode = treeViewPrev.GetNodeAt(targetPoint);
        }

        private void buttonAddFolder_Click(object sender, EventArgs e)
        {
            var cr = new CreateFolder();
            cr.ShowDialog();
            if (cr.id != "" && cr.name != "")
            {
                treeViewPrev.Nodes.Add(cr.id, cr.name);
                _prevFolders.Add(new FoldersData { ID = cr.id, NAME = cr.name });
            }

            richTextBoxLogger.Text += $"Добавлена новая папка. ID={cr.id}, NAME={cr.name}\n";
        }
        private void buttonDeleteFolder_Click(object sender, EventArgs e)
        {
            if (treeViewPrev.SelectedNode != null)
            {
                if (listBoxItems.Items.Count < 0)
                {
                    treeViewPrev.Nodes.Remove(treeViewPrev.SelectedNode);
                    richTextBoxLogger.Text +=
                    $"Удалена папка. ID={treeViewPrev.SelectedNode.Name}, NAME={treeViewPrev.SelectedNode.Text}\n";
                }
                else MessageBox.Show(@"Удаление папки невозможно, пока в нем находится товар.", "Ошибка", MessageBoxButtons.OK);
            }
            else MessageBox.Show(@"Пожалуйста, выберите необходимый элемент!", @"Ошибка", MessageBoxButtons.OK);
        }

        private void listBoxNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            IsPrev = false;
            textBoxID.Text = null;
            textBoxID_PRCG.Text = null;
            textBoxName.Text = null;
            comboBoxFolders.Text = null;
            textBoxWeight.Text = null;
            textBoxInPack.Text = null;
            textBoxQTY.Text = null;
            textBoxCost1.Text = null;
            if (listBoxNew.Items.Count > -1)
            {
                listBoxItems.DataSource = _NoSKUWarehous.Where(x => x.FOLDER == listBoxNew.GetItemText(listBoxNew.SelectedValue)).ToList();
                listBoxItems.ValueMember = "ID";
                listBoxItems.DisplayMember = "NAME";
                if (listBoxItems.SelectedValue != null)
                {
                    comboBoxFolders.Text = listBoxNew.SelectedValue.ToString();
                    textBoxID.Text = listBoxItems.GetItemText(listBoxItems.SelectedValue.ToString());
                    textBoxID_PRCG.Text = _NoSKUWarehous.Find(x => x.ID == textBoxID.Text).ID_PRCG;
                    textBoxName.Text = listBoxItems.GetItemText(listBoxItems.SelectedItem);
                    textBoxWeight.Text = _NoSKUWarehous.Find(x => x.ID == textBoxID.Text).WEIGHT
                        .ToString(CultureInfo.InvariantCulture);
                    textBoxInPack.Text = _NoSKUWarehous.Find(x => x.ID == textBoxID.Text).INPACK
                        .ToString(CultureInfo.InvariantCulture);
                    textBoxQTY.Text = _NoSKUWarehous.Find(x => x.ID == textBoxID.Text).QTY
                        .ToString(CultureInfo.InvariantCulture);
                    textBoxCost1.Text = _NoSKUWarehous.Find(x => x.ID == textBoxID.Text).COST1
                        .ToString(CultureInfo.InvariantCulture);
                }
            }
        }

        private void listBoxItems_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                listBoxItems.SelectionMode = SelectionMode.MultiSimple;
                listBoxItems.BeginUpdate();
                for (int i = 0; i < listBoxItems.Items.Count; i++)
                    listBoxItems.SetSelected(i ,true);
                listBoxItems.EndUpdate();
            }
        }

        private void listBoxItems_DoubleClick(object sender, EventArgs e)
        {
            listBoxItems.SelectionMode = SelectionMode.MultiExtended;
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}