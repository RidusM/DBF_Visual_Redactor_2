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
            this.listBoxItems = new System.Windows.Forms.ListBox();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxID_PRCG = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.textBoxInPack = new System.Windows.Forms.TextBox();
            this.textBoxQTY = new System.Windows.Forms.TextBox();
            this.textBoxCost1 = new System.Windows.Forms.TextBox();
            this.buttonSaveParameters = new System.Windows.Forms.Button();
            this.comboBoxFolders = new System.Windows.Forms.ComboBox();
            this.labelID = new System.Windows.Forms.Label();
            this.labelID_PRCG = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFolderName = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelInPack = new System.Windows.Forms.Label();
            this.labelQTY = new System.Windows.Forms.Label();
            this.labelCOST1 = new System.Windows.Forms.Label();
            this.richTextBoxLogger = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.filesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foldersImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.warehousImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullImportWarehousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserImportWarehousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FoldersExportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.WarehousExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsPropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeViewPrev = new System.Windows.Forms.TreeView();
            this.buttonAddFolder = new System.Windows.Forms.Button();
            this.buttonDeleteFolder = new System.Windows.Forms.Button();
            this.listBoxNew = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxItems
            // 
            this.listBoxItems.AllowDrop = true;
            this.listBoxItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxItems.FormattingEnabled = true;
            this.listBoxItems.ItemHeight = 15;
            this.listBoxItems.Location = new System.Drawing.Point(4, 3);
            this.listBoxItems.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxItems.Name = "listBoxItems";
            this.listBoxItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxItems.Size = new System.Drawing.Size(370, 439);
            this.listBoxItems.TabIndex = 4;
            this.listBoxItems.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            this.listBoxItems.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox2_DragEnter);
            this.listBoxItems.DragOver += new System.Windows.Forms.DragEventHandler(this.listBox2_DragOver);
            this.listBoxItems.DoubleClick += new System.EventHandler(this.listBoxItems_DoubleClick);
            this.listBoxItems.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxItems_KeyDown);
            this.listBoxItems.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseDown);
            this.listBoxItems.MouseMove += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseMove);
            this.listBoxItems.MouseUp += new System.Windows.Forms.MouseEventHandler(this.listBox2_MouseUp);
            // 
            // textBoxID
            // 
            this.textBoxID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(106, 4);
            this.textBoxID.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(177, 23);
            this.textBoxID.TabIndex = 9;
            // 
            // textBoxID_PRCG
            // 
            this.textBoxID_PRCG.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxID_PRCG.Location = new System.Drawing.Point(393, 4);
            this.textBoxID_PRCG.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxID_PRCG.Multiline = true;
            this.textBoxID_PRCG.Name = "textBoxID_PRCG";
            this.textBoxID_PRCG.Size = new System.Drawing.Size(177, 23);
            this.textBoxID_PRCG.TabIndex = 10;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxName.Location = new System.Drawing.Point(680, 4);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(177, 23);
            this.textBoxName.TabIndex = 11;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxWeight.Location = new System.Drawing.Point(393, 34);
            this.textBoxWeight.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxWeight.Multiline = true;
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.Size = new System.Drawing.Size(177, 23);
            this.textBoxWeight.TabIndex = 13;
            // 
            // textBoxInPack
            // 
            this.textBoxInPack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInPack.Location = new System.Drawing.Point(106, 34);
            this.textBoxInPack.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxInPack.Multiline = true;
            this.textBoxInPack.Name = "textBoxInPack";
            this.textBoxInPack.Size = new System.Drawing.Size(177, 23);
            this.textBoxInPack.TabIndex = 14;
            // 
            // textBoxQTY
            // 
            this.textBoxQTY.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxQTY.Location = new System.Drawing.Point(967, 34);
            this.textBoxQTY.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxQTY.Multiline = true;
            this.textBoxQTY.Name = "textBoxQTY";
            this.textBoxQTY.Size = new System.Drawing.Size(180, 23);
            this.textBoxQTY.TabIndex = 15;
            // 
            // textBoxCost1
            // 
            this.textBoxCost1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCost1.Location = new System.Drawing.Point(680, 34);
            this.textBoxCost1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCost1.Multiline = true;
            this.textBoxCost1.Name = "textBoxCost1";
            this.textBoxCost1.Size = new System.Drawing.Size(177, 23);
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
            this.buttonSaveParameters.Size = new System.Drawing.Size(364, 61);
            this.buttonSaveParameters.TabIndex = 17;
            this.buttonSaveParameters.Text = "Сохранить изменения";
            this.buttonSaveParameters.UseVisualStyleBackColor = true;
            this.buttonSaveParameters.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBoxFolders
            // 
            this.comboBoxFolders.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxFolders.BackColor = System.Drawing.SystemColors.Window;
            this.comboBoxFolders.Cursor = System.Windows.Forms.Cursors.Default;
            this.comboBoxFolders.Font = new System.Drawing.Font("Yandex Sans Text Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxFolders.FormattingEnabled = true;
            this.comboBoxFolders.Location = new System.Drawing.Point(966, 4);
            this.comboBoxFolders.Name = "comboBoxFolders";
            this.comboBoxFolders.Size = new System.Drawing.Size(182, 27);
            this.comboBoxFolders.TabIndex = 25;
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelID.AutoSize = true;
            this.labelID.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelID.Location = new System.Drawing.Point(4, 1);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(94, 29);
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
            this.labelID_PRCG.Location = new System.Drawing.Point(291, 1);
            this.labelID_PRCG.Name = "labelID_PRCG";
            this.labelID_PRCG.Size = new System.Drawing.Size(94, 29);
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
            this.labelName.Location = new System.Drawing.Point(578, 1);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(94, 29);
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
            this.labelFolderName.Location = new System.Drawing.Point(865, 1);
            this.labelFolderName.Name = "labelFolderName";
            this.labelFolderName.Size = new System.Drawing.Size(94, 29);
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
            this.labelWeight.Location = new System.Drawing.Point(291, 31);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(94, 29);
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
            this.labelInPack.Location = new System.Drawing.Point(4, 31);
            this.labelInPack.Name = "labelInPack";
            this.labelInPack.Size = new System.Drawing.Size(94, 29);
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
            this.labelQTY.Location = new System.Drawing.Point(865, 31);
            this.labelQTY.Name = "labelQTY";
            this.labelQTY.Size = new System.Drawing.Size(94, 29);
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
            this.labelCOST1.Location = new System.Drawing.Point(578, 31);
            this.labelCOST1.Name = "labelCOST1";
            this.labelCOST1.Size = new System.Drawing.Size(94, 29);
            this.labelCOST1.TabIndex = 26;
            this.labelCOST1.Text = "Цена";
            this.labelCOST1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // richTextBoxLogger
            // 
            this.richTextBoxLogger.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxLogger.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxLogger.Name = "richTextBoxLogger";
            this.richTextBoxLogger.Size = new System.Drawing.Size(1146, 91);
            this.richTextBoxLogger.TabIndex = 0;
            this.richTextBoxLogger.Text = "";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.buttonSaveParameters, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 460);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(372, 67);
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
            this.warehousImportToolStripMenuItem});
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
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FoldersExportToolStripMenuItem1,
            this.WarehousExportToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
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
            // treeViewPrev
            // 
            this.treeViewPrev.AllowDrop = true;
            this.treeViewPrev.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeViewPrev.BackColor = System.Drawing.SystemColors.Window;
            this.treeViewPrev.LabelEdit = true;
            this.treeViewPrev.Location = new System.Drawing.Point(3, 3);
            this.treeViewPrev.Name = "treeViewPrev";
            this.treeViewPrev.Size = new System.Drawing.Size(372, 452);
            this.treeViewPrev.TabIndex = 25;
            this.treeViewPrev.TabStop = false;
            this.treeViewPrev.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeViewPrev_AfterLabelEdit);
            this.treeViewPrev.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeViewPrev_ItemDrag);
            this.treeViewPrev.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewPrev_NodeMouseClick);
            this.treeViewPrev.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewPrev_NodeMouseDoubleClick);
            this.treeViewPrev.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeViewPrev_DragDrop);
            this.treeViewPrev.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeViewPrev_DragEnter);
            this.treeViewPrev.DragOver += new System.Windows.Forms.DragEventHandler(this.treeViewPrev_DragOver);
            // 
            // buttonAddFolder
            // 
            this.buttonAddFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddFolder.Location = new System.Drawing.Point(3, 3);
            this.buttonAddFolder.Name = "buttonAddFolder";
            this.buttonAddFolder.Size = new System.Drawing.Size(366, 27);
            this.buttonAddFolder.TabIndex = 27;
            this.buttonAddFolder.Text = "Добавить новую папку";
            this.buttonAddFolder.UseVisualStyleBackColor = true;
            this.buttonAddFolder.Click += new System.EventHandler(this.buttonAddFolder_Click);
            // 
            // buttonDeleteFolder
            // 
            this.buttonDeleteFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteFolder.Location = new System.Drawing.Point(3, 36);
            this.buttonDeleteFolder.Name = "buttonDeleteFolder";
            this.buttonDeleteFolder.Size = new System.Drawing.Size(366, 27);
            this.buttonDeleteFolder.TabIndex = 28;
            this.buttonDeleteFolder.Text = "Удалить текущую папку";
            this.buttonDeleteFolder.UseVisualStyleBackColor = true;
            this.buttonDeleteFolder.Click += new System.EventHandler(this.buttonDeleteFolder_Click);
            // 
            // listBoxNew
            // 
            this.listBoxNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxNew.FormattingEnabled = true;
            this.listBoxNew.ItemHeight = 15;
            this.listBoxNew.Location = new System.Drawing.Point(3, 3);
            this.listBoxNew.Name = "listBoxNew";
            this.listBoxNew.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxNew.Size = new System.Drawing.Size(372, 514);
            this.listBoxNew.TabIndex = 0;
            this.listBoxNew.SelectedIndexChanged += new System.EventHandler(this.listBoxNew_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxNew, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(378, 530);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.treeViewPrev, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(387, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.54205F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.45794F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(378, 530);
            this.tableLayoutPanel2.TabIndex = 29;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonDeleteFolder, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.buttonAddFolder, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 461);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(372, 66);
            this.tableLayoutPanel4.TabIndex = 31;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.listBoxItems, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(771, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.35514F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.64486F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(378, 530);
            this.tableLayoutPanel3.TabIndex = 30;
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel7.ColumnCount = 3;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel7.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(1152, 536);
            this.tableLayoutPanel7.TabIndex = 31;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel8.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel8.ColumnCount = 8;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.75F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.75F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.75F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.75F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.25F));
            this.tableLayoutPanel8.Controls.Add(this.textBoxID, 1, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBoxQTY, 7, 1);
            this.tableLayoutPanel8.Controls.Add(this.textBoxCost1, 5, 1);
            this.tableLayoutPanel8.Controls.Add(this.comboBoxFolders, 7, 0);
            this.tableLayoutPanel8.Controls.Add(this.labelID_PRCG, 2, 0);
            this.tableLayoutPanel8.Controls.Add(this.labelQTY, 6, 1);
            this.tableLayoutPanel8.Controls.Add(this.textBoxInPack, 1, 1);
            this.tableLayoutPanel8.Controls.Add(this.textBoxWeight, 3, 1);
            this.tableLayoutPanel8.Controls.Add(this.labelCOST1, 4, 1);
            this.tableLayoutPanel8.Controls.Add(this.textBoxID_PRCG, 3, 0);
            this.tableLayoutPanel8.Controls.Add(this.labelName, 4, 0);
            this.tableLayoutPanel8.Controls.Add(this.textBoxName, 5, 0);
            this.tableLayoutPanel8.Controls.Add(this.labelFolderName, 6, 0);
            this.tableLayoutPanel8.Controls.Add(this.labelWeight, 2, 1);
            this.tableLayoutPanel8.Controls.Add(this.labelInPack, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.labelID, 0, 0);
            this.tableLayoutPanel8.Location = new System.Drawing.Point(4, 547);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(1152, 61);
            this.tableLayoutPanel8.TabIndex = 32;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel9, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 1);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 27);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 3;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.25698F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.497207F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.24581F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1160, 716);
            this.tableLayoutPanel5.TabIndex = 33;
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Controls.Add(this.richTextBoxLogger, 0, 0);
            this.tableLayoutPanel9.Location = new System.Drawing.Point(4, 615);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 1;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(1152, 97);
            this.tableLayoutPanel9.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 755);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Yandex Sans Text Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "              ";
            this.tableLayoutPanel6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tableLayoutPanel8.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxItems;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxID_PRCG;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.TextBox textBoxInPack;
        private System.Windows.Forms.TextBox textBoxQTY;
        private System.Windows.Forms.TextBox textBoxCost1;
        private System.Windows.Forms.Button buttonSaveParameters;
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
        private System.Windows.Forms.ToolStripMenuItem fullImportWarehousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentUserImportWarehousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FoldersExportToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem WarehousExportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsPropertiesToolStripMenuItem;
        private System.Windows.Forms.ComboBox comboBoxFolders;
        private System.Windows.Forms.TreeView treeViewPrev;
        private System.Windows.Forms.Button buttonAddFolder;
        private System.Windows.Forms.Button buttonDeleteFolder;
        private System.Windows.Forms.ListBox listBoxNew;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
    }
}

