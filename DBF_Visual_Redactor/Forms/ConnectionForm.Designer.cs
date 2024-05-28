namespace DBF_Visual_Redactor
{
    partial class ConnectionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCheckConnection = new System.Windows.Forms.Button();
            this.buttonChangePortIP = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.textBoxPort = new System.Windows.Forms.TextBox();
            this.labelIP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCheckConnection
            // 
            this.buttonCheckConnection.Location = new System.Drawing.Point(4, 3);
            this.buttonCheckConnection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCheckConnection.Name = "buttonCheckConnection";
            this.buttonCheckConnection.Size = new System.Drawing.Size(157, 27);
            this.buttonCheckConnection.TabIndex = 0;
            this.buttonCheckConnection.Text = "Проверить соединение";
            this.buttonCheckConnection.UseVisualStyleBackColor = true;
            this.buttonCheckConnection.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonChangePortIP
            // 
            this.buttonChangePortIP.Location = new System.Drawing.Point(169, 3);
            this.buttonChangePortIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonChangePortIP.Name = "buttonChangePortIP";
            this.buttonChangePortIP.Size = new System.Drawing.Size(157, 27);
            this.buttonChangePortIP.TabIndex = 1;
            this.buttonChangePortIP.Text = "Изменить IP/Port";
            this.buttonChangePortIP.UseVisualStyleBackColor = true;
            this.buttonChangePortIP.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxIP
            // 
            this.textBoxIP.Font = new System.Drawing.Font("Yandex Sans Display Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIP.Location = new System.Drawing.Point(62, 3);
            this.textBoxIP.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxIP.Multiline = true;
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(264, 29);
            this.textBoxIP.TabIndex = 2;
            this.textBoxIP.Text = "localhost";
            // 
            // textBoxPort
            // 
            this.textBoxPort.Font = new System.Drawing.Font("Yandex Sans Display Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPort.Location = new System.Drawing.Point(62, 38);
            this.textBoxPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPort.Multiline = true;
            this.textBoxPort.Name = "textBoxPort";
            this.textBoxPort.Size = new System.Drawing.Size(264, 27);
            this.textBoxPort.TabIndex = 3;
            this.textBoxPort.Text = "8000";
            // 
            // labelIP
            // 
            this.labelIP.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelIP.AutoSize = true;
            this.labelIP.Font = new System.Drawing.Font("Yandex Sans Display Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIP.Location = new System.Drawing.Point(3, 0);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(52, 35);
            this.labelIP.TabIndex = 4;
            this.labelIP.Text = "IP:";
            this.labelIP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Yandex Sans Display Regular", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 35);
            this.label2.TabIndex = 5;
            this.label2.Text = "Port:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.57576F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.42424F));
            this.tableLayoutPanel1.Controls.Add(this.labelIP, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPort, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxIP, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 9);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(330, 70);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 165F));
            this.tableLayoutPanel2.Controls.Add(this.buttonCheckConnection, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonChangePortIP, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 80);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(330, 37);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // ConnectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 121);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yandex Sans Display Regular", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ConnectionForm";
            this.Text = "ConnectionForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ConnectionForm_FormClosing);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCheckConnection;
        private System.Windows.Forms.Button buttonChangePortIP;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.TextBox textBoxPort;
        private System.Windows.Forms.Label labelIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}