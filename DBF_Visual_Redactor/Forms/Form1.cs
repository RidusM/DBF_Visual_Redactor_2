using DBF_Visual_Redactor.DataClasses;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using SelectionMode = System.Windows.Forms.SelectionMode;


namespace DBF_Visual_Redactor
{
    public partial class Form1 : Form
    {
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
        private List<WarehousData> _exportWarehous;
        private List<FoldersData> _exportFolders;
        private List<WarehousData> _toLeftLbWarehous;
        public Form1()
        {
            InitializeComponent();
            treeViewPrev.TabStop = false;
            listBoxItems.TabStop = false;
            listBoxNew.TabStop = false;
        }
        // Внесение изменений в ListBox
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1 && IsPrev)
            {
                textBoxID.Text = listBoxItems.GetItemText(listBoxItems.SelectedValue.ToString());
                textBoxID_PRCG.Text = _exportWarehous.Find(x => x.ID == textBoxID.Text).ID_PRCG;
                textBoxName.Text = listBoxItems.GetItemText(listBoxItems.SelectedItem);
                textBoxWeight.Text = _exportWarehous.Find(x => x.ID == textBoxID.Text).WEIGHT.ToString(CultureInfo.InvariantCulture);
                textBoxInPack.Text = _exportWarehous.Find(x => x.ID == textBoxID.Text).INPACK.ToString(CultureInfo.InvariantCulture);
                textBoxQTY.Text = _exportWarehous.Find(x => x.ID == textBoxID.Text).QTY.ToString(CultureInfo.InvariantCulture);
                textBoxCost1.Text = _exportWarehous.Find(x => x.ID == textBoxID.Text).COST1.ToString(CultureInfo.InvariantCulture);
            }
        }
        // Изменение параметров поля
        private void buttonSaveParameters_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex > -1 && IsPrev)
            {
                foreach (var item in _exportWarehous.Where(x => x.ID == listBoxItems.SelectedValue.ToString()))
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
            _exportFolders.Clear();
            foreach (var node in Collect(treeViewPrev.Nodes))
            {
                var newListFolders = new FoldersData()
                {
                    ID = node.Name,
                    NAME = node.Text,
                    LEVEL = node.Level,
                };
                _exportFolders.Add(newListFolders);
            }
            var output = """
                           {"Fields":[{"Name":"ID","FieldType":"C","Length":55,"DecimalPlaces":0},
                           {"Name":"LEVEL","FieldType":"N","Length":10,"DecimalPlaces":0},
                           {"Name":"NAME","FieldType":"C","Length":100,"DecimalPlaces":0}],"Records":[
                           """;
            for (int i = 0; i < _exportFolders.Count; i++)
            {
                if (_exportFolders[i].NAME.Contains('"'))
                {
                    _exportFolders[i].NAME = _exportFolders[i].NAME.Replace("\"", @"\""");
                }
                output += $$"""
                            [{"Name":"ID","Value":"{{_exportFolders[i].ID}}"},
                            {"Name":"LEVEL","Value":"{{_exportFolders[i].LEVEL}}"},
                            {"Name":"NAME","Value":"{{_exportFolders[i].NAME}}"}],
                            """;
            }
            output = output.Remove(output.Length - 1);
            output += "]}";
            apiClient.PostFolders(Host, Port, output);
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
            for (int i = 0; i < _exportWarehous.Count; i++)
            {
                if (_exportWarehous[i].NAME.Contains(@"\"))
                {
                    _exportWarehous[i].NAME = _exportWarehous[i].NAME.Replace(@"\", @"");
                }
                if (_exportWarehous[i].NAME.Contains('"'))
                {
                    _exportWarehous[i].NAME = _exportWarehous[i].NAME.Replace("\"", @"\""");
                }
                output += $$"""
                            [{"Name":"ID","Value":"{{_exportWarehous[i].ID}}"},
                            {"Name":"ID_PRCG","Value":"{{_exportWarehous[i].ID_PRCG}}"},
                            {"Name":"NAME","Value":"{{_exportWarehous[i].NAME}}"},
                            {"Name":"FOLDER","Value":"{{_exportWarehous[i].FOLDER}}"},
                            {"Name":"WEIGHT","Value":"{{_exportWarehous[i].WEIGHT.ToString().Replace(",", ".")}}"},
                            {"Name":"INPACK","Value":"{{_exportWarehous[i].INPACK.ToString().Replace(",", ".")}}"},
                            {"Name":"QTY","Value":"{{_exportWarehous[i].QTY.ToString().Replace(",", ".")}}"},
                            {"Name":"COST1","Value":"{{_exportWarehous[i].COST1.ToString().Replace(",", ".")}}"}],
                            """;
            }
            output = output.Remove(output.Length - 1);
            output += "]}";
            apiClient.PostWarehous(Host, Port, output);
            _exportWarehous.Clear();
            _newWarehous.Clear();
            _prevWarehous.Clear();
            richTextBoxLogger.Text += "Произведен экспорт Warehous\n";
        }
        // Import данных из DBF
        private void fOLDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeViewPrev.Nodes.Clear();
            FoldersExportToolStripMenuItem1.Enabled = true;
            GetNewFolders();
            GetPrevFolders();
            GetNewWarehous();
            GetPrevWarehous();
            GetDifferenceData();
            PopulateBaseNodes();
            richTextBoxLogger.Text += "Произведен импорт Folders\n";

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
        private void GetDifferenceData()
        {
            _exportWarehous = new List<WarehousData>();
            _exportFolders = new List<FoldersData>();
            _toLeftLbWarehous = new List<WarehousData>();
            _toLeftLbWarehous.Clear();
            var allWarehousData = _newWarehous.Concat(_prevWarehous).ToList();
            var allFoldersData = _newFolders.Concat(_prevFolders).ToList();
            foreach (var warehous in allWarehousData)
            {
                try
                {
                    warehous.COST1 = _prevWarehous.Find(x => x.ID == warehous.ID).COST1;
                    warehous.QTY = _prevWarehous.Find(x => x.ID == warehous.ID).QTY;
                    warehous.NAME = _prevWarehous.Find(x => x.ID == warehous.ID).NAME;
                }
                catch
                {
                    warehous.COST1 = _newWarehous.Find(x => x.ID == warehous.ID).COST1;
                    warehous.QTY = _newWarehous.Find(x => x.ID == warehous.ID).QTY;
                    warehous.NAME = _newWarehous.Find(x => x.ID == warehous.ID).NAME;
                }
            }
            var differenceWarehousData = allWarehousData.Where(x => !_prevWarehous.Any(x2 => x2.ID == x.ID)).ToList();
            var differenceFoldersData = allFoldersData.Where(x => !_newFolders.Any(x2 => x.ID == x2.ID)).ToList();
            _exportFolders = _prevFolders.ToList();
            if (_exportFolders.Count > _newFolders.Count)
                _exportFolders = _newFolders.ToList();
            var itemToHide = differenceWarehousData.Where(x => _exportFolders.Any(x2 => x.FOLDER == x2.ID)).ToList();
            foreach ( var item in itemToHide)
            {
                differenceWarehousData.Remove(item);
                allWarehousData.Remove(item);
            }
            _exportWarehous = _exportWarehous.Concat(differenceWarehousData).Concat(_prevWarehous).ToList();
            _toLeftLbWarehous = allWarehousData.Where(x => !_prevWarehous.Any(x2 => x.ID == x2.ID)).ToList();
            listBoxNew.ValueMember = "ID";
            listBoxNew.DisplayMember = "NAME";
            listBoxNew.DataSource = _toLeftLbWarehous;
            comboBoxFolders.ValueMember = "Key";
            comboBoxFolders.DisplayMember = "Value";
            comboBoxFolders.DataSource = _exportFolders.ToList();
            comboBoxFolders.Text = null;
            textBoxCost1.Text = null;
            textBoxID.Text = null;
            textBoxID_PRCG.Text = null;
            textBoxInPack.Text = null;
            textBoxName.Text = null;
            textBoxQTY.Text = null;
            textBoxWeight.Text = null;
        }
        private void GetPrevFolders()
        {
            string json = apiClient.GetPrevFolders(Host, Port).Result;
            var root = JObject.Parse(json);
            var records = root.Last;
            _prevFolders = new List<FoldersData>();
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
                    }
                }
            }
        }
        private void GetNewWarehous()
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
        }
        // treeView логика построения
        public void PopulateBaseNodes()
        {
            treeViewPrev.Nodes.Clear();
            treeViewPrev.BeginUpdate();
            for (var i = 0; i < _exportFolders.Count; i++)
                if (_exportFolders[i].LEVEL == 0)
                {
                    treeViewPrev.Nodes.Add(_exportFolders[i].ID, _exportFolders[i].NAME);
                    treeViewPrev.Nodes[treeViewPrev.Nodes.Count - 1].Tag = _exportFolders[i];
                }

            for (var i = 0; i < treeViewPrev.Nodes.Count; i++)
                PopulateChilds(treeViewPrev.Nodes[i]);
            treeViewPrev.EndUpdate();
        } // Объявление родительских узлов
        public void PopulateChilds(TreeNode parentNode)
        {
            var parentRed = (FoldersData)parentNode.Tag;
            for (var i = parentRed.INDEX + 1; i < _exportFolders.Count; i++)
            {
                if (_exportFolders[i].LEVEL == parentRed.LEVEL + 1)
                {
                    parentNode.Nodes.Add(_exportFolders[i].ID, _exportFolders[i].NAME);
                    parentNode.Nodes[parentNode.Nodes.Count - 1].Tag = _exportFolders[i];
                    PopulateChilds(parentNode.Nodes[parentNode.Nodes.Count - 1]);
                }

                if (_exportFolders[i].LEVEL <= parentRed.LEVEL) break;
            }
        }  // Объявление дочерних узлов
        // treeView создание новых веток
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
        // treeView удаление веток
        private void buttonDeleteFolder_Click(object sender, EventArgs e)
        {
            if (treeViewPrev.SelectedNode != null)
            {
                if (listBoxItems.Items.Count < 1)
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
            if (listBoxNew.Items.Count > -1 && listBoxNew.SelectedItem != null && listBoxNew.SelectedValue.ToString() != "")
            {
                textBoxID.Text = listBoxNew.GetItemText(listBoxNew.SelectedValue.ToString());
                textBoxID_PRCG.Text = _exportWarehous.Find(x => x.ID == textBoxID.Text).ID_PRCG;
                textBoxName.Text = listBoxNew.GetItemText(listBoxNew.SelectedItem);
                textBoxWeight.Text = _exportWarehous.Find(x => x.ID == textBoxID.Text).WEIGHT
                    .ToString(CultureInfo.InvariantCulture);
                textBoxInPack.Text = _exportWarehous.Find(x => x.ID == textBoxID.Text).INPACK
                    .ToString(CultureInfo.InvariantCulture);
                textBoxQTY.Text = _exportWarehous.Find(x => x.ID == textBoxID.Text).QTY
                    .ToString(CultureInfo.InvariantCulture);
                textBoxCost1.Text = _exportWarehous.Find(x => x.ID == textBoxID.Text).COST1
                    .ToString(CultureInfo.InvariantCulture);
            }
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
                var listFolder = _newFolders.Concat(_prevFolders).ToList();
                var listFolder2 = listFolder.Where(x => x.NAME == e.Node.Text).ToList();
                var listDataSource = _newWarehous.Where(x => listFolder2.Any(x2 => x.FOLDER == x2.ID));
                var listDataSource2 = _prevWarehous.Where(x => listFolder2.Any(x2 => x.FOLDER == x2.ID));
                listDataSource = listDataSource.Concat(listDataSource2);
                listBoxItems.DataSource = listDataSource.ToList();
                comboBoxFolders.SelectedIndex = e.Node.Index;
                comboBoxFolders.Text = e.Node.Text;
            }
        }
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
            IsPrev = true;
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
            if (listBoxItems.SelectedItem != null) 
                listBoxItems.DoDragDrop(listBoxItems.SelectedItem, DragDropEffects.Move);
            else
                listBoxNew.DoDragDrop(listBoxNew.SelectedItem, DragDropEffects.Move);
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
                        _newFolders.Find(x => x.ID == draggedNode.Name).LEVEL = draggedNode.Level;
                        draggedNode.BackColor = Color.White;
                    }
                }
            }
            else if (IsPrev)
            {
                foreach (var item in listBoxItems.SelectedItems)
                {
                    try
                    {
                        var result = listBoxNew.GetItemText(item);
                        _exportWarehous.Find(x => x.NAME == result).FOLDER = targetNode.Name;
                        richTextBoxLogger.Text += $"{result} перемещен \nв папку {targetNode.Text}.\n";
                    }
                    catch { }
                }
                var newDataSource = _exportWarehous.Where(x => x.FOLDER == targetNode.Name).ToList();
                listBoxItems.DataSource = newDataSource;
                listBoxItems.Refresh();
                treeViewPrev.SelectedNode = targetNode;
            }
            else if (!IsPrev)
            {
                foreach (var item in listBoxNew.SelectedItems)
                {
                    try
                    {
                        var result = listBoxNew.GetItemText(item);
                        _exportWarehous.Find(x => x.NAME == result).FOLDER = targetNode.Name;
                        var deleteItem = _toLeftLbWarehous.Find(x => x.NAME == result);
                        _toLeftLbWarehous.Remove(deleteItem);
                        richTextBoxLogger.Text += $"{result} перемещен \nв папку {targetNode.Text}.\n";
                    }
                    catch { }
                }
                listBoxNew.DataSource = null;
                listBoxNew.ValueMember = "ID";
                listBoxNew.DisplayMember = "NAME";
                listBoxNew.DataSource = _toLeftLbWarehous;
            }
        }
        private void treeViewPrev_DragOver(object sender, DragEventArgs e)
        {
            var targetPoint = treeViewPrev.PointToClient(new Point(e.X, e.Y));
            treeViewPrev.SelectedNode = treeViewPrev.GetNodeAt(targetPoint);
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
        private void listBoxNew_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        private void listBoxNew_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
            treeViewPrev.Focus();
        }
        private void listBoxNew_MouseDown(object sender, MouseEventArgs e)
        {
            IsPrev = false;
            if (e.Button == MouseButtons.Left && listBoxNew.SelectedIndex > -1)
            {
                _draggActive = true;
                _draggStartPoint = new Point(e.X, e.Y);
                if (_draggActive == false)
                {
                    int y = e.Y / listBoxNew.ItemHeight;
                    if (y < listBoxNew.Items.Count)
                    {
                        listBoxNew.SelectedIndex = listBoxNew.TopIndex + y;
                        listBoxNew.SetSelected(listBoxNew.SelectedIndex, true);
                    }
                }
            }
        }
        private void listBoxNew_MouseMove(object sender, MouseEventArgs e)
        {
            if (_draggActive)
            {
                if (Math.Abs(e.X - _draggStartPoint.X) > 1 || Math.Abs(e.Y - _draggStartPoint.Y) > 1)
                    StartDragging();
            }
        }
        private void listBoxNew_MouseUp(object sender, MouseEventArgs e)
        {
            if (_draggActive)
                _draggActive = false;
        }
        private void listBoxNew_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                listBoxNew.BeginUpdate();
                for (int i = 0; i < listBoxNew.Items.Count; i++)
                    listBoxNew.SetSelected(i, true);
                listBoxNew.EndUpdate();
            }
        }
    }
}