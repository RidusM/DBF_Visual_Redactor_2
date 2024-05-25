using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;


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
            public string STATE { get; set; }
        };
        public class WarehousData
        {
            public int INDEX { get; set; }
            public string ID { get; set; }
            public string ID_PRCG { get; set; }
            public string NAME { get; set; }
            public string FOLDER { get; set; }
            public decimal WEIGHT { get; set; }
            public decimal INPACK { get; set; }
            public decimal QTY { get; set; }
            public decimal COST1 { get; set; }
        }
        public class UsersData
        {
            public int INDEX { get; set; }
            public string ID { get; set; }
            public string NAME { get; set; }
            public string LOGIN { get; set; }
            public string PASSWORD { get; set; }
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
        public int StateExport;
        private List<WarehousData> _warehous;
        private List<FoldersData> _folders;
        private List<UsersData> _user;

        private List<WarehousData> _prevWarehous;
#pragma warning restore CS0649 // Полю "Form1._prevWarehous" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
        private List<FoldersData> _prevFolders;
#pragma warning disable CS0649 // Полю "Form1._prevUser" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
        private List<UsersData> _prevUser;
#pragma warning restore CS0649 // Полю "Form1._prevUser" нигде не присваивается значение, поэтому оно всегда будет иметь значение по умолчанию null.
        public Form1()
        {
            InitializeComponent();
            treeView.TabStop = false;
            listBoxItems.TabStop = false;
        }
        // Внесение изменений в ListBox
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBoxID.Text = null;
            textBoxID_PRCG.Text = null;
            textBoxName.Text = null;
            comboBoxFolders.Text = null;
            textBoxWeight.Text = null;
            textBoxInPack.Text = null;
            textBoxQTY.Text = null;
            textBoxCost1.Text = null;
            if (treeView.Nodes.Count > 0)
                if (StateExport != 2)
                {
                    listBoxItems.DisplayMember = "Name";
                    listBoxItems.ValueMember = "ID";
                    listBoxItems.DataSource = _warehous.Where(x => x.FOLDER == e.Node.Name).ToList();
                    comboBoxFolders.Text = e.Node.Text;
                }
        }
        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex != -1 && StateExport != 2)
            {
                labelID_PRCG.Text = @"ID_PRCG";
                labelName.Text = @"Название";
                labelFolderName.Text = @"Имя папки";
                textBoxID.Text = listBoxItems.GetItemText(listBoxItems.SelectedValue.ToString());
                textBoxID_PRCG.Text = _warehous.Find(x => x.ID == textBoxID.Text).ID_PRCG;
                textBoxName.Text = listBoxItems.GetItemText(listBoxItems.SelectedItem);
                textBoxWeight.Text = _warehous.Find(x => x.ID == textBoxID.Text).WEIGHT.ToString(CultureInfo.InvariantCulture);
                textBoxInPack.Text = _warehous.Find(x => x.ID == textBoxID.Text).INPACK.ToString(CultureInfo.InvariantCulture);
                textBoxQTY.Text = _warehous.Find(x => x.ID == textBoxID.Text).QTY.ToString(CultureInfo.InvariantCulture);
                textBoxCost1.Text = _warehous.Find(x => x.ID == textBoxID.Text).COST1.ToString(CultureInfo.InvariantCulture);
            }
            else if (StateExport == 2)
            {
                labelID_PRCG.Text = @"ФИО";
                labelName.Text = @"Логин";
                labelFolderName.Text = @"Пароль";
                textBoxID_PRCG.Text = listBoxItems.GetItemText(listBoxItems.SelectedItem);
                textBoxID.Text = _user.Find(x => x.NAME == textBoxID_PRCG.Text).ID;
                textBoxName.Text = _user.Find(x => x.ID == textBoxID.Text).LOGIN;
                comboBoxFolders.Text = _user.Find(x => x.ID == textBoxID.Text).PASSWORD;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (listBoxItems.SelectedIndex > -1 && StateExport != 2)
            {
                foreach (var item in _warehous.Where(x => x.ID == listBoxItems.SelectedValue.ToString()))
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
            else if (listBoxItems.SelectedIndex > -1 && StateExport == 2)
            {
                foreach (var item in _user.Where(x => x.ID == listBoxItems.SelectedValue.ToString()))
                {
                    item.ID = textBoxID.Text;
                    item.NAME = textBoxID_PRCG.Text;
                    item.LOGIN = textBoxName.Text;
                    item.PASSWORD = comboBoxFolders.Text;
                    richTextBoxLogger.Text += $"Произведено изменение данных сотрудника {textBoxID_PRCG.Text}\n";
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
            _folders.Clear();
            foreach (var node in Collect(treeView.Nodes))
            {
                var newListFolders = new FoldersData()
                {
                    ID = node.Name,
                    NAME = node.Text,
                    LEVEL = node.Level,
                };
                _folders.Add(newListFolders);
            }
            var output = """
                           {"Fields":[{"Name":"ID","FieldType":"C","Length":55,"DecimalPlaces":0},
                           {"Name":"LEVEL","FieldType":"N","Length":10,"DecimalPlaces":0},
                           {"Name":"NAME","FieldType":"C","Length":100,"DecimalPlaces":0}],"Records":[
                           """;
            for (int i = 0; i < _folders.Count; i++)
            {
                if (_folders[i].NAME.Contains('"'))
                {
                    _folders[i].NAME = _folders[i].NAME.Replace("\"", @"\""");
                }
                output += $$"""
                            [{"Name":"ID","Value":"{{_folders[i].ID}}"},
                            {"Name":"LEVEL","Value":"{{_folders[i].LEVEL}}"},
                            {"Name":"NAME","Value":"{{_folders[i].NAME}}"}],
                            """;
            }
            output = output.Remove(output.Length - 1);
            output += "]}";
            apiClient.PostFolders(Host, Port, output);
            _folders.Clear();
            _prevFolders.Clear();
            richTextBoxLogger.Text += "Произведен экспорт Folders\n";
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
            for (int i = 0; i < _warehous.Count; i++)
            {
                if (_warehous[i].NAME.Contains(@"\"))
                {
                    _warehous[i].NAME = _warehous[i].NAME.Replace(@"\", @"");
                }
                if (_warehous[i].NAME.Contains('"'))
                {
                    _warehous[i].NAME = _warehous[i].NAME.Replace("\"", @"\""");
                }
                output += $$"""
                            [{"Name":"ID","Value":"{{_warehous[i].ID}}"},
                            {"Name":"ID_PRCG","Value":"{{_warehous[i].ID_PRCG}}"},
                            {"Name":"NAME","Value":"{{_warehous[i].NAME}}"},
                            {"Name":"FOLDER","Value":"{{_warehous[i].FOLDER}}"},
                            {"Name":"WEIGHT","Value":"{{_warehous[i].WEIGHT.ToString().Replace(",", ".")}}"},
                            {"Name":"INPACK","Value":"{{_warehous[i].INPACK.ToString().Replace(",", ".")}}"},
                            {"Name":"QTY","Value":"{{_warehous[i].QTY.ToString().Replace(",", ".")}}"},
                            {"Name":"COST1","Value":"{{_warehous[i].COST1.ToString().Replace(",", ".")}}"}],
                            """;
            }
            output = output.Remove(output.Length - 1);
            output += "]}";
            apiClient.PostWarehous(Host, Port, output);
            _warehous.Clear();
            _prevWarehous.Clear();
            richTextBoxLogger.Text += "Произведен экспорт Warehous\n";
        }
        private void WarehousToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WarehousExport();
        }
        private void UsersExportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var output = """
                         {"Fields":[{"Name":"ID","FieldType":"C","Length":100,"DecimalPlaces":0},
                         {"Name":"NAME","FieldType":"C","Length":100,"DecimalPlaces":0},
                         {"Name":"LOGIN","FieldType":"C","Length":30,"DecimalPlaces":0},
                         {"Name":"PASSWORD","FieldType":"C","Length":30,"DecimalPlaces":0}],"Records":[
                         """;
            for (int i = 0; i < _user.Count; i++)
            {
                output += $$"""
                            [{"Name":"ID","Value":"{{_user[i].ID}}"},
                            {"Name":"NAME","Value":"{{_user[i].NAME}}"},
                            {"Name":"LOGIN","Value":"{{_user[i].LOGIN}}"},
                            {"Name":"PASSWORD","Value":"{{_user[i].PASSWORD}}"}],
                            """;
            }
            output = output.Remove(output.Length - 1);
            output += "]}";
            apiClient.PostUsers(Host, Port, output);
            _user.Clear();
            _prevUser.Clear();
            richTextBoxLogger.Text += "Произведен экспорт Users\n";
        }

        // Import данных из DBF
        private void fOLDERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StateExport = 0;
            treeView.Nodes.Clear();
            treeView1.Nodes.Clear();
            FoldersExportToolStripMenuItem1.Enabled = true;
            GetFolders();
            GetPrevFolders();
            GetWarehous();
            PopulateBaseNodes();
            GetPrevWarehous();
            GetWarehousWithFolders();
            richTextBoxLogger.Text += "Произведен импорт Folders\n";

        }
        private void fullToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoldersExportToolStripMenuItem1.Enabled = true;
            StateExport = 1;
            treeView.Nodes.Clear();
            treeView1.Nodes.Clear();
            GetFolders();
            PopulateBaseNodes();
            GetWarehousWithFolders();
            richTextBoxLogger.Text += "Произведен экспорт полного Warehous\n";
        }
        private void uSERSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UsersExportToolStripMenuItem.Enabled = true;
            treeView.Nodes.Clear();
            treeView1.Nodes.Clear();
            StateExport = 2;
            GetUsers();
            richTextBoxLogger.Text += "Произведен экспорт Users\n";
        }
        private void GetFolders()
        {
            string json = apiClient.GetFolders(Host, Port).Result;
            var root = JObject.Parse(json);
            var records = root.Last;
            _folders = new List<FoldersData>();
            Dictionary<string, string> comboSource = new Dictionary<string, string>();
            var data = records.Children();
            foreach (JToken result in data)
            {
                var record = JsonConvert.DeserializeObject<List<List<RecordsList>>>(result.ToString());
                if (record != null)
                {
                    for (int i = 0; i < record.Count; i++)
                    {
                        _folders.Add(new FoldersData());
                        _folders[i].INDEX = i;
                        _folders[i].STATE = "default";
                        _folders[i].ID = record[i][0].VALUE;
                        _folders[i].LEVEL = Convert.ToInt32(record[i][1].VALUE);
                        _folders[i].NAME = record[i][2].VALUE;
                        comboSource.Add(_folders[i].ID, _folders[i].NAME);
                    }
                }

            }
            comboBoxFolders.ValueMember = "Key";
            comboBoxFolders.DisplayMember = "Value";
            comboBoxFolders.DataSource = comboSource.ToList();
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
                        _prevFolders[i].STATE = "default";
                        _prevFolders[i].INDEX = i;
                        _prevFolders[i].ID = record[i][0].VALUE;
                        _prevFolders[i].LEVEL = Convert.ToInt32(record[i][1].VALUE);
                        _prevFolders[i].NAME = record[i][2].VALUE;
                    }
                }
            }
        }

        private void GetWarehous()
        {
            string json = apiClient.GetWarehous(Host, Port).Result;
            var root = JObject.Parse(json);
            var records = root.Last;
            _warehous = new List<WarehousData>();
            var data = records.Children();
            foreach (JToken result in data)
            {
                var record = JsonConvert.DeserializeObject<List<List<RecordsList>>>(result.ToString());
                if (record != null)
                {
                    for (int i = 0; i < record.Count; i++)
                    {
                        _warehous.Add(new WarehousData());
                        _warehous[i].INDEX = i;
                        _warehous[i].ID = record[i][0].VALUE;
                        _warehous[i].ID_PRCG = record[i][1].VALUE;
                        _warehous[i].NAME = record[i][2].VALUE;
                        _warehous[i].FOLDER = record[i][3].VALUE;
                        _warehous[i].WEIGHT = decimal.Parse(record[i][4].VALUE.Replace(".", ","));
                        _warehous[i].INPACK = decimal.Parse(record[i][5].VALUE.Replace(".", ","));
                        if (record[i][6].VALUE != "")
                            _warehous[i].QTY = decimal.Parse(record[i][6].VALUE.Replace(".", ","));
                        else
                            _warehous[i].QTY = 0;
                        _warehous[i].COST1 = decimal.Parse(record[i][7].VALUE.Replace(".", ","));
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
                        _prevWarehous[i].INDEX = i;
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
        private void GetWarehousWithFolders()
        {
            string json = apiClient.GetWarehous(Host, Port).Result;
            var root = JObject.Parse(json);
            var records = root.Last;
            _warehous = new List<WarehousData>();
            var data = records.Children();
            foreach (JToken result in data)
            {
                var record = JsonConvert.DeserializeObject<List<List<RecordsList>>>(result.ToString());
                if (record != null)
                {
                    for (int i = 0; i < record.Count; i++)
                    {
                        _warehous.Add(new WarehousData());
                        _warehous[i].INDEX = i;
                        _warehous[i].ID = record[i][0].VALUE;
                        _warehous[i].ID_PRCG = record[i][1].VALUE;
                        _warehous[i].NAME = record[i][2].VALUE;
                        _warehous[i].FOLDER = record[i][3].VALUE;
                        _warehous[i].WEIGHT = decimal.Parse(record[i][4].VALUE.Replace(".", ","));
                        _warehous[i].INPACK = decimal.Parse(record[i][5].VALUE.Replace(".", ","));
                        if (record[i][6].VALUE != "")
                            _warehous[i].QTY = decimal.Parse(record[i][6].VALUE.Replace(".", ","));
                        else
                            _warehous[i].QTY = 0;
                        _warehous[i].COST1 = decimal.Parse(record[i][7].VALUE.Replace(".", ","));
                    }
                }
            }
        }
        private void GetUsers()
        {
            string json = apiClient.GetUsers(Host, Port).Result;
            var root = JObject.Parse(json);
            var records = root.Last;
            _user = new List<UsersData>();
            var data = records.Children();
            Dictionary<string, string> listSource = new Dictionary<string, string>();
            foreach (JToken result in data)
            {
                var record = JsonConvert.DeserializeObject<List<List<RecordsList>>>(result.ToString());
                if (record != null)
                {
                    for (int i = 0; i < record.Count; i++)
                    {
                        _user.Add(new UsersData());
                        _user[i].INDEX = i;
                        _user[i].ID = record[i][0].VALUE;
                        _user[i].NAME = record[i][1].VALUE;
                        _user[i].LOGIN = record[i][2].VALUE;
                        _user[i].PASSWORD = record[i][3].VALUE;
                        listSource.Add(_user[i].ID, _user[i].NAME);
                    }
                }

            }

            textBoxWeight.Visible = false;
            textBoxCost1.Visible = false;
            textBoxInPack.Visible = false;
            textBoxQTY.Visible = false;
            labelWeight.Visible = false;
            labelCOST1.Visible = false;
            labelInPack.Visible = false;
            labelQTY.Visible = false;
            listBoxItems.ValueMember = "Key";
            listBoxItems.DisplayMember = "Value";
            listBoxItems.DataSource = listSource.ToList();
        }

        // treeView логика построения
        public void PopulateBaseNodes()
        {
            treeView.Nodes.Clear();
            treeView.BeginUpdate();

            for (var i = 0; i < _folders.Count; i++)
                if (_folders[i].LEVEL == 0)
                {
                    treeView.Nodes.Add(_folders[i].ID, _folders[i].NAME);
                    treeView.Nodes[treeView.Nodes.Count - 1].Tag = _folders[i];
                }

            for (var i = 0; i < treeView.Nodes.Count; i++)
                PopulateChilds(treeView.Nodes[i]);

            treeView.EndUpdate();
            treeView.Refresh();
            var _newlistDeleted = _prevFolders.Where(x =>
                !_folders.Any(x2 => x2.ID == x.ID)).ToList();
            foreach (var folder in _newlistDeleted)
                folder.STATE = "deleted";
            var _newlistChanged = _prevFolders.Where(x =>
                _folders.Any(x2 => x2.NAME != x.NAME && x.ID == x2.ID) ||
                _folders.Any(x2 => x2.LEVEL != x.LEVEL && x.ID == x2.ID)).ToList();
            foreach (var folder in _newlistChanged)
                folder.STATE = "Changed";
            var _newListNew = _folders.Where(x =>
                !_prevFolders.Any(x2 => x2.ID == x.ID)).ToList();
            var _newlist = _newlistChanged.Concat(_newlistDeleted).Concat(_newListNew).ToList();
            if (_newlist.Count != 0)
            {
                treeView1.Nodes.Clear();
                treeView1.BeginUpdate();
                for (var i = 0; i < _newlist.Count; i++)
                {
                        treeView1.Nodes.Add(_newlist[i].ID, _newlist[i].NAME);
                        if (_newlist[i].STATE == "Changed")
                            treeView1.Nodes[treeView1.Nodes.Count - 1].BackColor = Color.Yellow;
                        else if (_newlist[i].STATE == "deleted")
                            treeView1.Nodes[treeView1.Nodes.Count - 1].BackColor = Color.Red;
                        else
                            treeView1.Nodes[treeView1.Nodes.Count - 1].BackColor = Color.Green;
                        treeView1.Nodes[treeView1.Nodes.Count - 1].Tag = _newlist[i];
                }

                treeView1.EndUpdate();
                treeView1.Refresh();
            }
        } // Объявление родительских узлов
        public void PopulateChilds(TreeNode parentNode)
        {
            var parentRed = (FoldersData)parentNode.Tag;

            for (var i = parentRed.INDEX + 1; i < _folders.Count; i++)
            {
                if (_folders[i].LEVEL == parentRed.LEVEL + 1)
                {
                    parentNode.Nodes.Add(_folders[i].ID, _folders[i].NAME);
                    parentNode.Nodes[parentNode.Nodes.Count - 1].Tag = _folders[i];
                    PopulateChilds(parentNode.Nodes[parentNode.Nodes.Count - 1]);
                }

                if (_folders[i].LEVEL <= parentRed.LEVEL) break;
            }
        }  // Объявление дочерних узлов
        // treeView создание новых веток
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var cr = new CreateFolder();
            cr.ShowDialog();
            if (cr.id != "" && cr.name != "")
            {
                treeView.Nodes.Add(cr.id, cr.name);
                _folders.Add(new FoldersData { ID = cr.id, NAME = cr.name });
            }

            richTextBoxLogger.Text += $"Добавлена новая папка. ID={cr.id}, NAME={cr.name}\n";
        } // Добавление ветки
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode != null)
            {
                treeView.Nodes.Remove(treeView.SelectedNode);
                richTextBoxLogger.Text +=
                    $"Удалена папка. ID={treeView.SelectedNode.Name}, NAME={treeView.SelectedNode.Text}\n";
            }
            else MessageBox.Show(@"Пожалуйста, выберите необходимый элемент!", @"Ошибка", MessageBoxButtons.OK);
        } // Удаление ветки
        // treeView редактирование названий FOLDERS
        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            treeView.SelectedNode.BeginEdit();
        }
        private void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            foreach (var item in _folders.Where(x => x.ID == e.Node.Name))
                item.NAME = e.Label;
            richTextBoxLogger.Text += $"Измененно название папки. Прошлое имя = {e.Node.Text}, новое имя = {e.Label}\n";
        }
        // DragDrop Реализация
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoDragDrop(e.Item, DragDropEffects.Move);
        }
        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        private void treeView1_DragOver(object sender, DragEventArgs e)
        {
            var targetPoint = treeView.PointToClient(new Point(e.X, e.Y));
            treeView.SelectedNode = treeView.GetNodeAt(targetPoint);
        }
        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            var targetNode = treeView.GetNodeAt(treeView.PointToClient(new Point(e.X, e.Y)));
            if (e.Data.GetDataPresent(typeof(TreeNode)))
            {
                var draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));
                if (targetNode == null && draggedNode != null)
                {
                    draggedNode.Remove();
                    treeView.Nodes.Add(draggedNode);
                    richTextBoxLogger.Text += $"Папка {draggedNode.Text} перемещена на 0 уровень.\n";
                    _folders.Find(x => x.ID == draggedNode.Name).LEVEL = 0;
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
                        _folders.Find(x => x.ID == draggedNode.Name).LEVEL = draggedNode.Level;
                    }
                    catch
                    {
                        _prevFolders.Find(x => x.ID == draggedNode.Name).LEVEL = draggedNode.Level;
                        draggedNode.BackColor = Color.White;
                    }
                }
            }
            else
            {
                var result = listBoxItems.GetItemText(listBoxItems.SelectedItem);
                string newFolder = _warehous.Find(x => x.NAME == result).FOLDER;
                string lastFolder = _folders.Find(x => x.ID == newFolder).NAME;
                _warehous.Find(x => x.NAME == result).FOLDER = targetNode.Name;
                listBoxItems.Update();
                richTextBoxLogger.Text += $"Перемещена папка {result}\nв папку {targetNode.Text}.\n" +
                                          $"Прошлая папка {lastFolder}.\n";
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
            treeView.Focus();
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
                        listBoxItems.SelectedIndex = listBoxItems.TopIndex + y;
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

        private void treeView1_ItemDrag_1(object sender, ItemDragEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView1_DragEnter_1(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            foreach (var node in Collect(treeView1.Nodes))
            {
                if (node != null)
                {
                    if (node.BackColor == Color.Red)
                    {
                        node.Remove();
                        TreeNode nodes2 = treeView.Nodes.Cast<TreeNode>().FirstOrDefault(x => x.Text == node.Text);
                        if (nodes2 != null)
                            treeView.Nodes.Remove(nodes2);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void treeView1_NodeMouseClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            textBoxID.Text = null;
            textBoxID_PRCG.Text = null;
            textBoxName.Text = null;
            comboBoxFolders.Text = null;
            textBoxWeight.Text = null;
            textBoxInPack.Text = null;
            textBoxQTY.Text = null;
            textBoxCost1.Text = null;
            if (treeView.Nodes.Count > 0)
                if (StateExport != 2)
                {
                    listBoxItems.DisplayMember = "Name";
                    listBoxItems.ValueMember = "ID";
                    listBoxItems.DataSource = _prevWarehous.Where(x => x.FOLDER == e.Node.Name).ToList();
                    comboBoxFolders.Text = e.Node.Text;
                }
        }
    }
}