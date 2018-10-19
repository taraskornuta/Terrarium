namespace Terrarium
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnl_ToolBar = new System.Windows.Forms.Panel();
            this.btn_CleanRxField = new System.Windows.Forms.Button();
            this.btn_CleanTxField = new System.Windows.Forms.Button();
            this.lbl_ComNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_SerialConnect = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.pnl_Settings = new System.Windows.Forms.Panel();
            this.flattenCombo1 = new Terrarium.FlattenCombo();
            this.btn_SerialPortRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tmr_MenuSlide = new System.Windows.Forms.Timer(this.components);
            this.rtb_Tx = new System.Windows.Forms.RichTextBox();
            this.rtb_Rx = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_TxString = new System.Windows.Forms.TextBox();
            this.btn_SerialSend = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnl_ToolBar.SuspendLayout();
            this.pnl_Settings.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ToolBar
            // 
            this.pnl_ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnl_ToolBar.Controls.Add(this.btn_CleanRxField);
            this.pnl_ToolBar.Controls.Add(this.btn_CleanTxField);
            this.pnl_ToolBar.Controls.Add(this.lbl_ComNumber);
            this.pnl_ToolBar.Controls.Add(this.label1);
            this.pnl_ToolBar.Controls.Add(this.btn_SerialConnect);
            this.pnl_ToolBar.Controls.Add(this.btn_Settings);
            this.pnl_ToolBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_ToolBar.Location = new System.Drawing.Point(844, 0);
            this.pnl_ToolBar.Name = "pnl_ToolBar";
            this.pnl_ToolBar.Size = new System.Drawing.Size(40, 561);
            this.pnl_ToolBar.TabIndex = 1;
            // 
            // btn_CleanRxField
            // 
            this.btn_CleanRxField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CleanRxField.FlatAppearance.BorderSize = 0;
            this.btn_CleanRxField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CleanRxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CleanRxField.Image = global::Terrarium.Properties.Resources.icons8_Trash_32px;
            this.btn_CleanRxField.Location = new System.Drawing.Point(2, 397);
            this.btn_CleanRxField.Name = "btn_CleanRxField";
            this.btn_CleanRxField.Size = new System.Drawing.Size(37, 41);
            this.btn_CleanRxField.TabIndex = 5;
            this.btn_CleanRxField.UseVisualStyleBackColor = true;
            this.btn_CleanRxField.Click += new System.EventHandler(this.btn_CleanRxField_Click);
            // 
            // btn_CleanTxField
            // 
            this.btn_CleanTxField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CleanTxField.FlatAppearance.BorderSize = 0;
            this.btn_CleanTxField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CleanTxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CleanTxField.Image = global::Terrarium.Properties.Resources.icons8_Trash_32px;
            this.btn_CleanTxField.Location = new System.Drawing.Point(2, 474);
            this.btn_CleanTxField.Name = "btn_CleanTxField";
            this.btn_CleanTxField.Size = new System.Drawing.Size(37, 41);
            this.btn_CleanTxField.TabIndex = 4;
            this.btn_CleanTxField.UseVisualStyleBackColor = true;
            this.btn_CleanTxField.Click += new System.EventHandler(this.btn_CleanTxField_Click);
            // 
            // lbl_ComNumber
            // 
            this.lbl_ComNumber.AutoSize = true;
            this.lbl_ComNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ComNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.lbl_ComNumber.Location = new System.Drawing.Point(7, 62);
            this.lbl_ComNumber.Name = "lbl_ComNumber";
            this.lbl_ComNumber.Size = new System.Drawing.Size(21, 13);
            this.lbl_ComNumber.TabIndex = 3;
            this.lbl_ComNumber.Text = "25";
            this.lbl_ComNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM";
            // 
            // btn_SerialConnect
            // 
            this.btn_SerialConnect.FlatAppearance.BorderSize = 0;
            this.btn_SerialConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SerialConnect.Image = global::Terrarium.Properties.Resources.icons8_Disconnected_32px;
            this.btn_SerialConnect.Location = new System.Drawing.Point(2, 5);
            this.btn_SerialConnect.Name = "btn_SerialConnect";
            this.btn_SerialConnect.Size = new System.Drawing.Size(37, 41);
            this.btn_SerialConnect.TabIndex = 1;
            this.btn_SerialConnect.UseVisualStyleBackColor = true;
            this.btn_SerialConnect.Click += new System.EventHandler(this.btn_SerialConnect_Click);
            // 
            // btn_Settings
            // 
            this.btn_Settings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Settings.FlatAppearance.BorderSize = 0;
            this.btn_Settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Settings.Image = ((System.Drawing.Image)(resources.GetObject("btn_Settings.Image")));
            this.btn_Settings.Location = new System.Drawing.Point(2, 515);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(37, 41);
            this.btn_Settings.TabIndex = 0;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // pnl_Settings
            // 
            this.pnl_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnl_Settings.Controls.Add(this.groupBox1);
            this.pnl_Settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Settings.Location = new System.Drawing.Point(619, 0);
            this.pnl_Settings.Name = "pnl_Settings";
            this.pnl_Settings.Size = new System.Drawing.Size(225, 561);
            this.pnl_Settings.TabIndex = 2;
            // 
            // flattenCombo1
            // 
            this.flattenCombo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.flattenCombo1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.flattenCombo1.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.flattenCombo1.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.flattenCombo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.flattenCombo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.flattenCombo1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.flattenCombo1.FormattingEnabled = true;
            this.flattenCombo1.Items.AddRange(new object[] {
            "COM25",
            "COM12",
            "COM32",
            "COM43",
            "COM54",
            "COM32",
            "COM45"});
            this.flattenCombo1.Location = new System.Drawing.Point(6, 19);
            this.flattenCombo1.Name = "flattenCombo1";
            this.flattenCombo1.Size = new System.Drawing.Size(87, 23);
            this.flattenCombo1.TabIndex = 8;
            // 
            // btn_SerialPortRefresh
            // 
            this.btn_SerialPortRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SerialPortRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_SerialPortRefresh.FlatAppearance.BorderSize = 0;
            this.btn_SerialPortRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SerialPortRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SerialPortRefresh.Image = global::Terrarium.Properties.Resources.icons8_Refresh_22px;
            this.btn_SerialPortRefresh.Location = new System.Drawing.Point(189, 15);
            this.btn_SerialPortRefresh.Name = "btn_SerialPortRefresh";
            this.btn_SerialPortRefresh.Size = new System.Drawing.Size(32, 32);
            this.btn_SerialPortRefresh.TabIndex = 6;
            this.btn_SerialPortRefresh.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 24);
            this.panel1.TabIndex = 3;
            // 
            // tmr_MenuSlide
            // 
            this.tmr_MenuSlide.Interval = 10;
            this.tmr_MenuSlide.Tick += new System.EventHandler(this.tmr_MenuSlide_Tick);
            // 
            // rtb_Tx
            // 
            this.rtb_Tx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.rtb_Tx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Tx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Tx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_Tx.ForeColor = System.Drawing.Color.White;
            this.rtb_Tx.Location = new System.Drawing.Point(0, 438);
            this.rtb_Tx.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Tx.Name = "rtb_Tx";
            this.rtb_Tx.Size = new System.Drawing.Size(619, 75);
            this.rtb_Tx.TabIndex = 1;
            this.rtb_Tx.Text = resources.GetString("rtb_Tx.Text");
            // 
            // rtb_Rx
            // 
            this.rtb_Rx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.rtb_Rx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rtb_Rx.ForeColor = System.Drawing.Color.White;
            this.rtb_Rx.Location = new System.Drawing.Point(0, 0);
            this.rtb_Rx.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Rx.Name = "rtb_Rx";
            this.rtb_Rx.Size = new System.Drawing.Size(619, 438);
            this.rtb_Rx.TabIndex = 0;
            this.rtb_Rx.Text = resources.GetString("rtb_Rx.Text");
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.rtb_Rx, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Tx, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 537);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel2.Controls.Add(this.tb_TxString, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btn_SerialSend, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 513);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(619, 24);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tb_TxString
            // 
            this.tb_TxString.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_TxString.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_TxString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_TxString.ForeColor = System.Drawing.Color.White;
            this.tb_TxString.Location = new System.Drawing.Point(0, 0);
            this.tb_TxString.Margin = new System.Windows.Forms.Padding(0);
            this.tb_TxString.Name = "tb_TxString";
            this.tb_TxString.Size = new System.Drawing.Size(502, 24);
            this.tb_TxString.TabIndex = 0;
            // 
            // btn_SerialSend
            // 
            this.btn_SerialSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_SerialSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SerialSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SerialSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SerialSend.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.btn_SerialSend.Image = global::Terrarium.Properties.Resources.icons8_Sent_22px;
            this.btn_SerialSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SerialSend.Location = new System.Drawing.Point(502, 0);
            this.btn_SerialSend.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SerialSend.Name = "btn_SerialSend";
            this.btn_SerialSend.Size = new System.Drawing.Size(117, 24);
            this.btn_SerialSend.TabIndex = 1;
            this.btn_SerialSend.Text = "Send";
            this.btn_SerialSend.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flattenCombo1);
            this.groupBox1.Controls.Add(this.btn_SerialPortRefresh);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 61);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM PORT";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Settings);
            this.Controls.Add(this.pnl_ToolBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terrarium";
            this.pnl_ToolBar.ResumeLayout(false);
            this.pnl_ToolBar.PerformLayout();
            this.pnl_Settings.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_ToolBar;
        private System.Windows.Forms.Panel pnl_Settings;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmr_MenuSlide;
        private System.Windows.Forms.RichTextBox rtb_Tx;
        private System.Windows.Forms.RichTextBox rtb_Rx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_TxString;
        private System.Windows.Forms.Button btn_SerialSend;
        private System.Windows.Forms.Button btn_SerialConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ComNumber;
        private System.Windows.Forms.Button btn_CleanTxField;
        private System.Windows.Forms.Button btn_CleanRxField;
        private System.Windows.Forms.Button btn_SerialPortRefresh;
        private FlattenCombo flattenCombo1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

