namespace DBF_Visual_Redactor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.treeView = new System.Windows.Forms.TreeView();
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.pictureButtonAddFolder = new System.Windows.Forms.PictureBox();
            this.pictureButtonDeleteFolder = new System.Windows.Forms.PictureBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxID_PRCG = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxInPack = new System.Windows.Forms.TextBox();
            this.textBoxQTY = new System.Windows.Forms.TextBox();
            this.textBoxCost1 = new System.Windows.Forms.TextBox();
            this.buttonSaveParameters = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.comboBoxFolders = new System.Windows.Forms.ComboBox();
            this.labelParameters = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelID_PRCG = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFolderName = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelInPack = new System.Windows.Forms.Label();
            this.labelQTY = new System.Windows.Forms.Label();
            this.labelCOST1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.richTextBoxLogger = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehousImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullImportWarehousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserImportWarehousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usersImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FoldersExportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehousExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsersExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButtonAddFolder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButtonDeleteFolder)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView
            // 
            this.treeView.AllowDrop = true;
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.LabelEdit = true;
            this.treeView.Location = new System.Drawing.Point(4, 3);
            this.treeView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(390, 417);
            this.treeView.TabIndex = 2;
            this.treeView.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            this.treeView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            this.treeView.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView.DragOver += new System.Windows.Forms.DragEventHandler(this.treeView1_DragOver);
            // 
            // listBoxItems
            // 
            this.listBoxItems.AllowDrop = true;
            this.listBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 15;
            this.listBoxItems.Location = new System.Drawing.Point(415, 51);
            this.listBoxItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.Size = new System.Drawing.Size(392, 529);
            this.listBoxItems.TabIndex = 4;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBoxItems.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            this.listBoxItems.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox2_DragOver);
            this.listBoxItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            this.listBoxItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseMove);
            this.listBoxItems.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseUp);
            // 
            // pictureButtonAddFolder
            // 
            this.pictureButtonAddFolder.Image = ((System.Drawing.Image)(resources.GetObject("pictureButtonAddFolder.Image")));
            this.pictureButtonAddFolder.Location = new System.Drawing.Point(4, 3);
            this.pictureButtonAddFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureButtonAddFolder.Name = "pictureButtonAddFolder";
            this.pictureButtonAddFolder.Size = new System.Drawing.Size(30, 27);
            this.pictureButtonAddFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureButtonAddFolder.TabIndex = 6;
            this.pictureButtonAddFolder.TabStop = false;
            this.pictureButtonAddFolder.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureButtonDeleteFolder
            // 
            this.pictureButtonDeleteFolder.Image = ((System.Drawing.Image)(resources.GetObject("pictureButtonDeleteFolder.Image")));
            this.pictureButtonDeleteFolder.Location = new System.Drawing.Point(42, 3);
            this.pictureButtonDeleteFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureButtonDeleteFolder.Name = "pictureButtonDeleteFolder";
            this.pictureButtonDeleteFolder.Size = new System.Drawing.Size(31, 27);
            this.pictureButtonDeleteFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureButtonDeleteFolder.TabIndex = 7;
            this.pictureButtonDeleteFolder.TabStop = false;
            this.pictureButtonDeleteFolder.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(120, 62);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(227, 47);
            this.textBoxID.TabIndex = 9;
            // 
            // textBoxID_PRCG
            // 
            this.textBoxID_PRCG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxID_PRCG.Location = new System.Drawing.Point(120, 118);
            this.textBoxID_PRCG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxID_PRCG.Multiline = true;
            this.textBoxID_PRCG.Name = "textBoxID_PRCG";
            this.textBoxID_PRCG.Size = new System.Drawing.Size(227, 47);
            this.textBoxID_PRCG.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(120, 174);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(227, 47);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWeight.Location = new System.Drawing.Point(120, 286);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxWeight.Multiline = true;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(227, 47);
            this.textBoxWeight.TabIndex = 13;
            // 
            // textBoxInPack
            // 
            this.textBoxInPack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInPack.Location = new System.Drawing.Point(120, 342);
            this.textBoxInPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxInPack.Multiline = true;
            this.textBoxInPack.Name = "textBoxInPack";
            this.textBoxInPack.Size = new System.Drawing.Size(227, 47);
            this.textBoxInPack.TabIndex = 14;
            // 
            // textBoxQTY
            // 
            this.textBoxQTY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQTY.Location = new System.Drawing.Point(120, 398);
            this.textBoxQTY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxQTY.Multiline = true;
            this.textBoxQTY.Name = "textBoxQTY";
            this.textBoxQTY.Size = new System.Drawing.Size(227, 47);
            this.textBoxQTY.TabIndex = 15;
            // 
            // textBoxCost1
            // 
            this.textBoxCost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCost1.Location = new System.Drawing.Point(120, 454);
            this.textBoxCost1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCost1.Multiline = true;
            this.textBoxCost1.Name = "textBoxCost1";
            this.textBoxCost1.Size = new System.Drawing.Size(227, 54);
            this.textBoxCost1.TabIndex = 16;
            // 
            // buttonSaveParameters
            // 
            this.buttonSaveParameters.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveParameters.Location = new System.Drawing.Point(4, 3);
            this.buttonSaveParameters.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveParameters.Name = "buttonSaveParameters";
            this.buttonSaveParameters.Size = new System.Drawing.Size(353, 43);
            this.buttonSaveParameters.TabIndex = 17;
            this.buttonSaveParameters.Text = "Сохранить изменения";
            this.buttonSaveParameters.UseVisualStyleBackColor = true;
            this.buttonSaveParameters.Click += new System.EventHandler(this.button3_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.treeView, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 48);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.226221F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 423);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pictureButtonAddFolder, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureButtonDeleteFolder, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(16, 581);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(77, 33);
            this.tableLayoutPanel3.TabIndex = 20;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.90883F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.09117F));
            this.tableLayoutPanel4.Controls.Add(this.comboBoxFolders, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.textBoxCost1, 1, 8);
            this.tableLayoutPanel4.Controls.Add(this.textBoxQTY, 1, 7);
            this.tableLayoutPanel4.Controls.Add(this.textBoxInPack, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.textBoxWeight, 1, 5);
            this.tableLayoutPanel4.Controls.Add(this.textBoxName, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.textBoxID_PRCG, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelParameters, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.labelID, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.labelID_PRCG, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.labelName, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.labelFolderName, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.labelWeight, 0, 5);
            this.tableLayoutPanel4.Controls.Add(this.labelInPack, 0, 6);
            this.tableLayoutPanel4.Controls.Add(this.labelQTY, 0, 7);
            this.tableLayoutPanel4.Controls.Add(this.labelCOST1, 0, 8);
            this.tableLayoutPanel4.Controls.Add(this.textBoxID, 1, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(818, 51);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 9;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(354, 514);
            this.tableLayoutPanel4.TabIndex = 21;
            // 
            // comboBoxFolders
            // 
            this.comboBoxFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFolders.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFolders.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxFolders.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBoxFolders.Font = new System.Drawing.Font("Yandex Sans Text Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFolders.FormattingEnabled = true;
            this.comboBoxFolders.Location = new System.Drawing.Point(119, 230);
            this.comboBoxFolders.Name = "comboBoxFolders";
            this.comboBoxFolders.Size = new System.Drawing.Size(229, 27);
            this.comboBoxFolders.TabIndex = 25;
            // 
            // labelParameters
            // 
            this.labelParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelParameters.Font = new System.Drawing.Font("Yandex Sans Text Regular", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelParameters.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelParameters.Location = new System.Drawing.Point(6, 3);
            this.labelParameters.Name = "labelParameters";
            this.labelParameters.Size = new System.Drawing.Size(104, 53);
            this.labelParameters.TabIndex = 18;
            this.labelParameters.Text = "Параметры";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelID.Location = new System.Drawing.Point(6, 59);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(104, 53);
            this.labelID.TabIndex = 19;
            this.labelID.Text = "ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelID_PRCG
            // 
            this.labelID_PRCG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID_PRCG.AutoSize = true;
            this.labelID_PRCG.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelID_PRCG.Location = new System.Drawing.Point(6, 115);
            this.labelID_PRCG.Name = "labelID_PRCG";
            this.labelID_PRCG.Size = new System.Drawing.Size(104, 53);
            this.labelID_PRCG.TabIndex = 20;
            this.labelID_PRCG.Text = "ID_PRCG";
            this.labelID_PRCG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelName
            // 
            this.labelName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelName.AutoSize = true;
            this.labelName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelName.Location = new System.Drawing.Point(6, 171);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(104, 53);
            this.labelName.TabIndex = 21;
            this.labelName.Text = "Название";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFolderName
            // 
            this.labelFolderName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFolderName.AutoSize = true;
            this.labelFolderName.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelFolderName.Location = new System.Drawing.Point(6, 227);
            this.labelFolderName.Name = "labelFolderName";
            this.labelFolderName.Size = new System.Drawing.Size(104, 53);
            this.labelFolderName.TabIndex = 22;
            this.labelFolderName.Text = "Имя папки";
            this.labelFolderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWeight
            // 
            this.labelWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWeight.AutoSize = true;
            this.labelWeight.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelWeight.Location = new System.Drawing.Point(6, 283);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(104, 53);
            this.labelWeight.TabIndex = 23;
            this.labelWeight.Text = "Вес";
            this.labelWeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInPack
            // 
            this.labelInPack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInPack.AutoSize = true;
            this.labelInPack.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelInPack.Location = new System.Drawing.Point(6, 339);
            this.labelInPack.Name = "labelInPack";
            this.labelInPack.Size = new System.Drawing.Size(104, 53);
            this.labelInPack.TabIndex = 24;
            this.labelInPack.Text = "В упаковке";
            this.labelInPack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQTY
            // 
            this.labelQTY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQTY.AutoSize = true;
            this.labelQTY.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelQTY.Location = new System.Drawing.Point(6, 395);
            this.labelQTY.Name = "labelQTY";
            this.labelQTY.Size = new System.Drawing.Size(104, 53);
            this.labelQTY.TabIndex = 25;
            this.labelQTY.Text = "Количество";
            this.labelQTY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelCOST1
            // 
            this.labelCOST1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCOST1.AutoSize = true;
            this.labelCOST1.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelCOST1.Location = new System.Drawing.Point(6, 451);
            this.labelCOST1.Name = "labelCOST1";
            this.labelCOST1.Size = new System.Drawing.Size(104, 60);
            this.labelCOST1.TabIndex = 26;
            this.labelCOST1.Text = "Цена";
            this.labelCOST1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.richTextBoxLogger, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 620);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1160, 123);
            this.tableLayoutPanel5.TabIndex = 22;
            // 
            // richTextBoxLogger
            // 
            this.richTextBoxLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLogger.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxLogger.Name = "richTextBoxLogger";
            this.richTextBoxLogger.Size = new System.Drawing.Size(1154, 117);
            this.richTextBoxLogger.TabIndex = 0;
            this.richTextBoxLogger.Text = "";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.buttonSaveParameters, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(814, 565);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(361, 49);
            this.tableLayoutPanel6.TabIndex = 23;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filesToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            this.filesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            this.filesToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.filesToolStripMenuItem.Text = "Files";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foldersImportToolStripMenuItem,
            this.warehousImportToolStripMenuItem,
            this.usersImportToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // foldersImportToolStripMenuItem
            // 
            this.foldersImportToolStripMenuItem.Name = "foldersImportToolStripMenuItem";
            this.foldersImportToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.foldersImportToolStripMenuItem.Text = "FOLDERS";
            this.foldersImportToolStripMenuItem.Click += new System.EventHandler(this.fOLDERSToolStripMenuItem_Click);
            // 
            // warehousImportToolStripMenuItem
            // 
            this.warehousImportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullImportWarehousToolStripMenuItem,
            this.currentUserImportWarehousToolStripMenuItem});
            this.warehousImportToolStripMenuItem.Name = "warehousImportToolStripMenuItem";
            this.warehousImportToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.warehousImportToolStripMenuItem.Text = "WAREHOUS";
            this.warehousImportToolStripMenuItem.Visible = false;
            // 
            // fullImportWarehousToolStripMenuItem
            // 
            this.fullImportWarehousToolStripMenuItem.Name = "fullImportWarehousToolStripMenuItem";
            this.fullImportWarehousToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.fullImportWarehousToolStripMenuItem.Text = "Full";
            this.fullImportWarehousToolStripMenuItem.Click += new System.EventHandler(this.fullToolStripMenuItem_Click);
            // 
            // currentUserImportWarehousToolStripMenuItem
            // 
            this.currentUserImportWarehousToolStripMenuItem.Name = "currentUserImportWarehousToolStripMenuItem";
            this.currentUserImportWarehousToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.currentUserImportWarehousToolStripMenuItem.Text = "CurrentUser";
            // 
            // usersImportToolStripMenuItem
            // 
            this.usersImportToolStripMenuItem.Name = "usersImportToolStripMenuItem";
            this.usersImportToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.usersImportToolStripMenuItem.Text = "USERS";
            this.usersImportToolStripMenuItem.Visible = false;
            this.usersImportToolStripMenuItem.Click += new System.EventHandler(this.uSERSToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FoldersExportToolStripMenuItem1,
            this.WarehousExportToolStripMenuItem,
            this.UsersExportToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // FoldersExportToolStripMenuItem1
            // 
            this.FoldersExportToolStripMenuItem1.Enabled = false;
            this.FoldersExportToolStripMenuItem1.Name = "FoldersExportToolStripMenuItem1";
            this.FoldersExportToolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.FoldersExportToolStripMenuItem1.Text = "FOLDERS";
            this.FoldersExportToolStripMenuItem1.Click += new System.EventHandler(this.FoldersExportToolStripMenuItem1_Click);
            // 
            // WarehousExportToolStripMenuItem
            // 
            this.WarehousExportToolStripMenuItem.Enabled = false;
            this.WarehousExportToolStripMenuItem.Name = "WarehousExportToolStripMenuItem";
            this.WarehousExportToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.WarehousExportToolStripMenuItem.Text = "WAREHOUS";
            this.WarehousExportToolStripMenuItem.Visible = false;
            this.WarehousExportToolStripMenuItem.Click += new System.EventHandler(this.WarehousToolStripMenuItem1_Click);
            // 
            // UsersExportToolStripMenuItem
            // 
            this.UsersExportToolStripMenuItem.Enabled = false;
            this.UsersExportToolStripMenuItem.Name = "UsersExportToolStripMenuItem";
            this.UsersExportToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.UsersExportToolStripMenuItem.Text = "USERS";
            this.UsersExportToolStripMenuItem.Visible = false;
            this.UsersExportToolStripMenuItem.Click += new System.EventHandler(this.UsersExportToolStripMenuItem1_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionsPropertiesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // connectionsPropertiesToolStripMenuItem
            // 
            this.connectionsPropertiesToolStripMenuItem.Name = "connectionsPropertiesToolStripMenuItem";
            this.connectionsPropertiesToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.connectionsPropertiesToolStripMenuItem.Text = "Connections properties";
            this.connectionsPropertiesToolStripMenuItem.Click += new System.EventHandler(this.connectionsPropertiesToolStripMenuItem_Click);
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.Window;
            this.treeView1.Location = new System.Drawing.Point(12, 477);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(392, 103);
            this.treeView1.TabIndex = 25;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag_1);
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick_1);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(96, 583);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 30);
            this.button1.TabIndex = 26;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Yellow;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(238, 583);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 30);
            this.button2.TabIndex = 27;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 591);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 28;
            this.label1.Text = "Папка удалена";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Папка отредактирована";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(565, 588);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(242, 23);
            this.button3.TabIndex = 30;
            this.button3.Text = "Удалить несохраненные папки";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 591);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 15);
            this.label3.TabIndex = 32;
            this.label3.Text = "Новая папка";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Green;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(438, 583);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 30);
            this.button4.TabIndex = 31;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 755);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.listBoxItems);
            this.Controls.Add(this.tableLayoutPanel6);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Yandex Sans Text Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "DBFRedactor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureButtonAddFolder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButtonDeleteFolder)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.PictureBox pictureButtonAddFolder;
        private System.Windows.Forms.PictureBox pictureButtonDeleteFolder;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxID_PRCG;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxInPack;
        private System.Windows.Forms.TextBox textBoxQTY;
        private System.Windows.Forms.TextBox textBoxCost1;
        private System.Windows.Forms.Button buttonSaveParameters;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label labelParameters;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelID_PRCG;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFolderName;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelInPack;
        private System.Windows.Forms.Label labelQTY;
        private System.Windows.Forms.Label labelCOST1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.RichTextBox richTextBoxLogger;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem filesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foldersImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem warehousImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersImportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullImportWarehousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserImportWarehousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FoldersExportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem WarehousExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UsersExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsPropertiesToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxFolders;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
    }
}

