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
            this.btn_SerialConnect = new System.Windows.Forms.Button();
            this.btn_Settings = new System.Windows.Forms.Button();
            this.pnl_Settings = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Receiving = new System.Windows.Forms.Panel();
            this.nmn_ByteSort = new System.Windows.Forms.NumericUpDown();
            this.cb_RxAutoscroll = new System.Windows.Forms.CheckBox();
            this.cb_Sort = new System.Windows.Forms.CheckBox();
            this.cb_Rx_Hex = new System.Windows.Forms.CheckBox();
            this.cb_Loging = new System.Windows.Forms.CheckBox();
            this.cb_LinesNum = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_PanelReceiving = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pnl_PortSettings = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rb_baudRate_460800 = new System.Windows.Forms.RadioButton();
            this.tb_baudRateCustome = new System.Windows.Forms.TextBox();
            this.rb_baudRate_custome = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_256000 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_128000 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_115200 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_57600 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_56000 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_38400 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_28800 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_19200 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_14400 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_9600 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_4800 = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_dataBits_8 = new System.Windows.Forms.RadioButton();
            this.rb_dataBits_7 = new System.Windows.Forms.RadioButton();
            this.rb_dataBits_6 = new System.Windows.Forms.RadioButton();
            this.rb_dataBits_5 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_parity_space = new System.Windows.Forms.RadioButton();
            this.rb_parity_mark = new System.Windows.Forms.RadioButton();
            this.rb_parity_even = new System.Windows.Forms.RadioButton();
            this.rb_parity_odd = new System.Windows.Forms.RadioButton();
            this.rb_parity_none = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rb_handshake_rts_xon = new System.Windows.Forms.RadioButton();
            this.rb_handshake_xon = new System.Windows.Forms.RadioButton();
            this.rb_handshake_rts = new System.Windows.Forms.RadioButton();
            this.rb_handshake_none = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rb_stopBits_2 = new System.Windows.Forms.RadioButton();
            this.rb_stopBits_1_5 = new System.Windows.Forms.RadioButton();
            this.rb_stopBits_1 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_PanelPortSettings = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_PortName = new System.Windows.Forms.Panel();
            this.btn_SerialPortRefresh = new System.Windows.Forms.Button();
            this.cmb_SerialPortList = new Terrarium.FlattenCombo();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btn_Transmiting = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnl_Transmiting = new System.Windows.Forms.Panel();
            this.cb_Tx_Hex = new System.Windows.Forms.CheckBox();
            this.cb_TxMacroSend = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_TxCounter = new System.Windows.Forms.Label();
            this.lbl_RxCounter = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tmr_MenuSlide = new System.Windows.Forms.Timer(this.components);
            this.rtb_Tx = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nrtb_Rx = new Terrarium.NumberedRTB();
            this.macroPannel = new Terrarium.MacroPanel();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertysToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_ToolBar.SuspendLayout();
            this.pnl_Settings.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.pnl_Receiving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmn_ByteSort)).BeginInit();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.pnl_PortSettings.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_PortName.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.pnl_Transmiting.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_ToolBar
            // 
            this.pnl_ToolBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnl_ToolBar.Controls.Add(this.btn_CleanRxField);
            this.pnl_ToolBar.Controls.Add(this.btn_CleanTxField);
            this.pnl_ToolBar.Controls.Add(this.btn_SerialConnect);
            this.pnl_ToolBar.Controls.Add(this.btn_Settings);
            this.pnl_ToolBar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_ToolBar.Location = new System.Drawing.Point(844, 0);
            this.pnl_ToolBar.Name = "pnl_ToolBar";
            this.pnl_ToolBar.Size = new System.Drawing.Size(40, 683);
            this.pnl_ToolBar.TabIndex = 1;
            // 
            // btn_CleanRxField
            // 
            this.btn_CleanRxField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CleanRxField.FlatAppearance.BorderSize = 0;
            this.btn_CleanRxField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CleanRxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CleanRxField.Image = ((System.Drawing.Image)(resources.GetObject("btn_CleanRxField.Image")));
            this.btn_CleanRxField.Location = new System.Drawing.Point(2, 519);
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
            this.btn_CleanTxField.Image = ((System.Drawing.Image)(resources.GetObject("btn_CleanTxField.Image")));
            this.btn_CleanTxField.Location = new System.Drawing.Point(2, 596);
            this.btn_CleanTxField.Name = "btn_CleanTxField";
            this.btn_CleanTxField.Size = new System.Drawing.Size(37, 41);
            this.btn_CleanTxField.TabIndex = 4;
            this.btn_CleanTxField.UseVisualStyleBackColor = true;
            this.btn_CleanTxField.Click += new System.EventHandler(this.btn_CleanTxField_Click);
            // 
            // btn_SerialConnect
            // 
            this.btn_SerialConnect.FlatAppearance.BorderSize = 0;
            this.btn_SerialConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SerialConnect.Image = global::Terrarium.Properties.Resources.icons8_Disconnected_32px;
            this.btn_SerialConnect.Location = new System.Drawing.Point(2, 19);
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
            this.btn_Settings.Image = global::Terrarium.Properties.Resources.icons8_Settings_32px;
            this.btn_Settings.Location = new System.Drawing.Point(2, 637);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(37, 41);
            this.btn_Settings.TabIndex = 0;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // pnl_Settings
            // 
            this.pnl_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnl_Settings.Controls.Add(this.tableLayoutPanel2);
            this.pnl_Settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Settings.Location = new System.Drawing.Point(619, 0);
            this.pnl_Settings.Name = "pnl_Settings";
            this.pnl_Settings.Size = new System.Drawing.Size(225, 683);
            this.pnl_Settings.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pnl_Receiving, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.panel6, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.pnl_PortSettings, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnl_PortName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.pnl_Transmiting, 0, 7);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 8;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 317F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(225, 683);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // pnl_Receiving
            // 
            this.pnl_Receiving.Controls.Add(this.nmn_ByteSort);
            this.pnl_Receiving.Controls.Add(this.cb_RxAutoscroll);
            this.pnl_Receiving.Controls.Add(this.cb_Sort);
            this.pnl_Receiving.Controls.Add(this.cb_Rx_Hex);
            this.pnl_Receiving.Controls.Add(this.cb_Loging);
            this.pnl_Receiving.Controls.Add(this.cb_LinesNum);
            this.pnl_Receiving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Receiving.Location = new System.Drawing.Point(0, 415);
            this.pnl_Receiving.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Receiving.Name = "pnl_Receiving";
            this.pnl_Receiving.Size = new System.Drawing.Size(225, 93);
            this.pnl_Receiving.TabIndex = 5;
            // 
            // nmn_ByteSort
            // 
            this.nmn_ByteSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.nmn_ByteSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmn_ByteSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmn_ByteSort.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nmn_ByteSort.Location = new System.Drawing.Point(56, 72);
            this.nmn_ByteSort.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nmn_ByteSort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmn_ByteSort.Name = "nmn_ByteSort";
            this.nmn_ByteSort.Size = new System.Drawing.Size(62, 17);
            this.nmn_ByteSort.TabIndex = 16;
            this.nmn_ByteSort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_RxAutoscroll
            // 
            this.cb_RxAutoscroll.AutoSize = true;
            this.cb_RxAutoscroll.Checked = true;
            this.cb_RxAutoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_RxAutoscroll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_RxAutoscroll.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_RxAutoscroll.Location = new System.Drawing.Point(128, 3);
            this.cb_RxAutoscroll.Name = "cb_RxAutoscroll";
            this.cb_RxAutoscroll.Size = new System.Drawing.Size(72, 17);
            this.cb_RxAutoscroll.TabIndex = 2;
            this.cb_RxAutoscroll.Text = "Autoscroll";
            this.cb_RxAutoscroll.UseVisualStyleBackColor = true;
            // 
            // cb_Sort
            // 
            this.cb_Sort.AutoSize = true;
            this.cb_Sort.Checked = true;
            this.cb_Sort.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Sort.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_Sort.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Sort.Location = new System.Drawing.Point(4, 73);
            this.cb_Sort.Name = "cb_Sort";
            this.cb_Sort.Size = new System.Drawing.Size(45, 17);
            this.cb_Sort.TabIndex = 6;
            this.cb_Sort.Text = "Sort";
            this.cb_Sort.UseVisualStyleBackColor = true;
            this.cb_Sort.CheckedChanged += new System.EventHandler(this.cb_Sort_CheckedChanged);
            // 
            // cb_Rx_Hex
            // 
            this.cb_Rx_Hex.AutoSize = true;
            this.cb_Rx_Hex.Checked = true;
            this.cb_Rx_Hex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Rx_Hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_Rx_Hex.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Rx_Hex.Location = new System.Drawing.Point(3, 3);
            this.cb_Rx_Hex.Name = "cb_Rx_Hex";
            this.cb_Rx_Hex.Size = new System.Drawing.Size(48, 17);
            this.cb_Rx_Hex.TabIndex = 3;
            this.cb_Rx_Hex.Text = "HEX";
            this.cb_Rx_Hex.UseVisualStyleBackColor = true;
            // 
            // cb_Loging
            // 
            this.cb_Loging.AutoSize = true;
            this.cb_Loging.Checked = true;
            this.cb_Loging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Loging.Enabled = false;
            this.cb_Loging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_Loging.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Loging.Location = new System.Drawing.Point(128, 49);
            this.cb_Loging.Name = "cb_Loging";
            this.cb_Loging.Size = new System.Drawing.Size(44, 17);
            this.cb_Loging.TabIndex = 5;
            this.cb_Loging.Text = "Log";
            this.cb_Loging.UseVisualStyleBackColor = true;
            // 
            // cb_LinesNum
            // 
            this.cb_LinesNum.AutoSize = true;
            this.cb_LinesNum.Checked = true;
            this.cb_LinesNum.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_LinesNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_LinesNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_LinesNum.Location = new System.Drawing.Point(128, 26);
            this.cb_LinesNum.Name = "cb_LinesNum";
            this.cb_LinesNum.Size = new System.Drawing.Size(91, 17);
            this.cb_LinesNum.TabIndex = 4;
            this.cb_LinesNum.Text = "Lines Number";
            this.cb_LinesNum.UseVisualStyleBackColor = true;
            this.cb_LinesNum.CheckedChanged += new System.EventHandler(this.cb_LinesNum_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel6.Controls.Add(this.btn_PanelReceiving);
            this.panel6.Controls.Add(this.label9);
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 395);
            this.panel6.Margin = new System.Windows.Forms.Padding(0);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(225, 20);
            this.panel6.TabIndex = 4;
            // 
            // btn_PanelReceiving
            // 
            this.btn_PanelReceiving.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_PanelReceiving.FlatAppearance.BorderSize = 0;
            this.btn_PanelReceiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PanelReceiving.Image = global::Terrarium.Properties.Resources.icons8_Sort_Left_16px;
            this.btn_PanelReceiving.Location = new System.Drawing.Point(198, 0);
            this.btn_PanelReceiving.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PanelReceiving.Name = "btn_PanelReceiving";
            this.btn_PanelReceiving.Size = new System.Drawing.Size(27, 20);
            this.btn_PanelReceiving.TabIndex = 4;
            this.btn_PanelReceiving.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label9.Location = new System.Drawing.Point(22, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Receiving";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Terrarium.Properties.Resources.icons8_Download_22px;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pnl_PortSettings
            // 
            this.pnl_PortSettings.Controls.Add(this.groupBox2);
            this.pnl_PortSettings.Controls.Add(this.groupBox3);
            this.pnl_PortSettings.Controls.Add(this.groupBox4);
            this.pnl_PortSettings.Controls.Add(this.groupBox6);
            this.pnl_PortSettings.Controls.Add(this.groupBox5);
            this.pnl_PortSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PortSettings.Location = new System.Drawing.Point(0, 78);
            this.pnl_PortSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_PortSettings.Name = "pnl_PortSettings";
            this.pnl_PortSettings.Size = new System.Drawing.Size(225, 317);
            this.pnl_PortSettings.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rb_baudRate_460800);
            this.groupBox2.Controls.Add(this.tb_baudRateCustome);
            this.groupBox2.Controls.Add(this.rb_baudRate_custome);
            this.groupBox2.Controls.Add(this.rb_baudRate_256000);
            this.groupBox2.Controls.Add(this.rb_baudRate_128000);
            this.groupBox2.Controls.Add(this.rb_baudRate_115200);
            this.groupBox2.Controls.Add(this.rb_baudRate_57600);
            this.groupBox2.Controls.Add(this.rb_baudRate_56000);
            this.groupBox2.Controls.Add(this.rb_baudRate_38400);
            this.groupBox2.Controls.Add(this.rb_baudRate_28800);
            this.groupBox2.Controls.Add(this.rb_baudRate_19200);
            this.groupBox2.Controls.Add(this.rb_baudRate_14400);
            this.groupBox2.Controls.Add(this.rb_baudRate_9600);
            this.groupBox2.Controls.Add(this.rb_baudRate_4800);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Location = new System.Drawing.Point(0, 1);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Baud rate";
            // 
            // rb_baudRate_460800
            // 
            this.rb_baudRate_460800.AutoSize = true;
            this.rb_baudRate_460800.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_460800.Location = new System.Drawing.Point(139, 32);
            this.rb_baudRate_460800.Name = "rb_baudRate_460800";
            this.rb_baudRate_460800.Size = new System.Drawing.Size(61, 17);
            this.rb_baudRate_460800.TabIndex = 13;
            this.rb_baudRate_460800.Text = "460800";
            this.rb_baudRate_460800.UseVisualStyleBackColor = true;
            // 
            // tb_baudRateCustome
            // 
            this.tb_baudRateCustome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_baudRateCustome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_baudRateCustome.ForeColor = System.Drawing.Color.White;
            this.tb_baudRateCustome.Location = new System.Drawing.Point(139, 77);
            this.tb_baudRateCustome.Margin = new System.Windows.Forms.Padding(0);
            this.tb_baudRateCustome.Name = "tb_baudRateCustome";
            this.tb_baudRateCustome.Size = new System.Drawing.Size(82, 22);
            this.tb_baudRateCustome.TabIndex = 12;
            this.tb_baudRateCustome.Text = "74880";
            this.tb_baudRateCustome.TextChanged += new System.EventHandler(this.tb_baudRateCustome_TextChanged);
            // 
            // rb_baudRate_custome
            // 
            this.rb_baudRate_custome.AutoSize = true;
            this.rb_baudRate_custome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_custome.Location = new System.Drawing.Point(139, 50);
            this.rb_baudRate_custome.Name = "rb_baudRate_custome";
            this.rb_baudRate_custome.Size = new System.Drawing.Size(66, 17);
            this.rb_baudRate_custome.TabIndex = 11;
            this.rb_baudRate_custome.Text = "Custome";
            this.rb_baudRate_custome.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_256000
            // 
            this.rb_baudRate_256000.AutoSize = true;
            this.rb_baudRate_256000.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_256000.Location = new System.Drawing.Point(139, 15);
            this.rb_baudRate_256000.Name = "rb_baudRate_256000";
            this.rb_baudRate_256000.Size = new System.Drawing.Size(61, 17);
            this.rb_baudRate_256000.TabIndex = 10;
            this.rb_baudRate_256000.Text = "256000";
            this.rb_baudRate_256000.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_128000
            // 
            this.rb_baudRate_128000.AutoSize = true;
            this.rb_baudRate_128000.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_128000.Location = new System.Drawing.Point(68, 86);
            this.rb_baudRate_128000.Name = "rb_baudRate_128000";
            this.rb_baudRate_128000.Size = new System.Drawing.Size(61, 17);
            this.rb_baudRate_128000.TabIndex = 9;
            this.rb_baudRate_128000.Text = "128000";
            this.rb_baudRate_128000.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_115200
            // 
            this.rb_baudRate_115200.AutoSize = true;
            this.rb_baudRate_115200.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_115200.Location = new System.Drawing.Point(68, 68);
            this.rb_baudRate_115200.Name = "rb_baudRate_115200";
            this.rb_baudRate_115200.Size = new System.Drawing.Size(61, 17);
            this.rb_baudRate_115200.TabIndex = 8;
            this.rb_baudRate_115200.Text = "115200";
            this.rb_baudRate_115200.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_57600
            // 
            this.rb_baudRate_57600.AutoSize = true;
            this.rb_baudRate_57600.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_57600.Location = new System.Drawing.Point(68, 50);
            this.rb_baudRate_57600.Name = "rb_baudRate_57600";
            this.rb_baudRate_57600.Size = new System.Drawing.Size(55, 17);
            this.rb_baudRate_57600.TabIndex = 7;
            this.rb_baudRate_57600.Text = "57600";
            this.rb_baudRate_57600.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_56000
            // 
            this.rb_baudRate_56000.AutoSize = true;
            this.rb_baudRate_56000.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_56000.Location = new System.Drawing.Point(68, 32);
            this.rb_baudRate_56000.Name = "rb_baudRate_56000";
            this.rb_baudRate_56000.Size = new System.Drawing.Size(55, 17);
            this.rb_baudRate_56000.TabIndex = 6;
            this.rb_baudRate_56000.Text = "56000";
            this.rb_baudRate_56000.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_38400
            // 
            this.rb_baudRate_38400.AutoSize = true;
            this.rb_baudRate_38400.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_38400.Location = new System.Drawing.Point(68, 15);
            this.rb_baudRate_38400.Name = "rb_baudRate_38400";
            this.rb_baudRate_38400.Size = new System.Drawing.Size(55, 17);
            this.rb_baudRate_38400.TabIndex = 5;
            this.rb_baudRate_38400.Text = "38400";
            this.rb_baudRate_38400.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_28800
            // 
            this.rb_baudRate_28800.AutoSize = true;
            this.rb_baudRate_28800.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_28800.Location = new System.Drawing.Point(4, 86);
            this.rb_baudRate_28800.Name = "rb_baudRate_28800";
            this.rb_baudRate_28800.Size = new System.Drawing.Size(55, 17);
            this.rb_baudRate_28800.TabIndex = 4;
            this.rb_baudRate_28800.Text = "28800";
            this.rb_baudRate_28800.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_19200
            // 
            this.rb_baudRate_19200.AutoSize = true;
            this.rb_baudRate_19200.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_19200.Location = new System.Drawing.Point(4, 68);
            this.rb_baudRate_19200.Name = "rb_baudRate_19200";
            this.rb_baudRate_19200.Size = new System.Drawing.Size(55, 17);
            this.rb_baudRate_19200.TabIndex = 3;
            this.rb_baudRate_19200.Text = "19200";
            this.rb_baudRate_19200.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_14400
            // 
            this.rb_baudRate_14400.AutoSize = true;
            this.rb_baudRate_14400.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_14400.Location = new System.Drawing.Point(4, 50);
            this.rb_baudRate_14400.Name = "rb_baudRate_14400";
            this.rb_baudRate_14400.Size = new System.Drawing.Size(55, 17);
            this.rb_baudRate_14400.TabIndex = 2;
            this.rb_baudRate_14400.Text = "14400";
            this.rb_baudRate_14400.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_9600
            // 
            this.rb_baudRate_9600.AutoSize = true;
            this.rb_baudRate_9600.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_9600.Location = new System.Drawing.Point(4, 32);
            this.rb_baudRate_9600.Name = "rb_baudRate_9600";
            this.rb_baudRate_9600.Size = new System.Drawing.Size(49, 17);
            this.rb_baudRate_9600.TabIndex = 1;
            this.rb_baudRate_9600.Text = "9600";
            this.rb_baudRate_9600.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_4800
            // 
            this.rb_baudRate_4800.AutoSize = true;
            this.rb_baudRate_4800.Checked = true;
            this.rb_baudRate_4800.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_4800.Location = new System.Drawing.Point(4, 15);
            this.rb_baudRate_4800.Name = "rb_baudRate_4800";
            this.rb_baudRate_4800.Size = new System.Drawing.Size(49, 17);
            this.rb_baudRate_4800.TabIndex = 0;
            this.rb_baudRate_4800.TabStop = true;
            this.rb_baudRate_4800.Text = "4800";
            this.rb_baudRate_4800.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rb_dataBits_8);
            this.groupBox3.Controls.Add(this.rb_dataBits_7);
            this.groupBox3.Controls.Add(this.rb_dataBits_6);
            this.groupBox3.Controls.Add(this.rb_dataBits_5);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox3.Location = new System.Drawing.Point(1, 114);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(66, 110);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            // 
            // rb_dataBits_8
            // 
            this.rb_dataBits_8.AutoSize = true;
            this.rb_dataBits_8.Checked = true;
            this.rb_dataBits_8.Location = new System.Drawing.Point(7, 83);
            this.rb_dataBits_8.Name = "rb_dataBits_8";
            this.rb_dataBits_8.Size = new System.Drawing.Size(31, 17);
            this.rb_dataBits_8.TabIndex = 4;
            this.rb_dataBits_8.TabStop = true;
            this.rb_dataBits_8.Text = "8";
            this.rb_dataBits_8.UseVisualStyleBackColor = true;
            // 
            // rb_dataBits_7
            // 
            this.rb_dataBits_7.AutoSize = true;
            this.rb_dataBits_7.Location = new System.Drawing.Point(7, 62);
            this.rb_dataBits_7.Name = "rb_dataBits_7";
            this.rb_dataBits_7.Size = new System.Drawing.Size(31, 17);
            this.rb_dataBits_7.TabIndex = 3;
            this.rb_dataBits_7.Text = "7";
            this.rb_dataBits_7.UseVisualStyleBackColor = true;
            // 
            // rb_dataBits_6
            // 
            this.rb_dataBits_6.AutoSize = true;
            this.rb_dataBits_6.Location = new System.Drawing.Point(7, 41);
            this.rb_dataBits_6.Name = "rb_dataBits_6";
            this.rb_dataBits_6.Size = new System.Drawing.Size(31, 17);
            this.rb_dataBits_6.TabIndex = 2;
            this.rb_dataBits_6.Text = "6";
            this.rb_dataBits_6.UseVisualStyleBackColor = true;
            // 
            // rb_dataBits_5
            // 
            this.rb_dataBits_5.AutoSize = true;
            this.rb_dataBits_5.Location = new System.Drawing.Point(7, 20);
            this.rb_dataBits_5.Name = "rb_dataBits_5";
            this.rb_dataBits_5.Size = new System.Drawing.Size(31, 17);
            this.rb_dataBits_5.TabIndex = 1;
            this.rb_dataBits_5.Text = "5";
            this.rb_dataBits_5.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data bits";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rb_parity_space);
            this.groupBox4.Controls.Add(this.rb_parity_mark);
            this.groupBox4.Controls.Add(this.rb_parity_even);
            this.groupBox4.Controls.Add(this.rb_parity_odd);
            this.groupBox4.Controls.Add(this.rb_parity_none);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox4.Location = new System.Drawing.Point(73, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(72, 110);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            // 
            // rb_parity_space
            // 
            this.rb_parity_space.AutoSize = true;
            this.rb_parity_space.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_parity_space.Location = new System.Drawing.Point(6, 84);
            this.rb_parity_space.Name = "rb_parity_space";
            this.rb_parity_space.Size = new System.Drawing.Size(54, 17);
            this.rb_parity_space.TabIndex = 9;
            this.rb_parity_space.Text = "space";
            this.rb_parity_space.UseVisualStyleBackColor = true;
            // 
            // rb_parity_mark
            // 
            this.rb_parity_mark.AutoSize = true;
            this.rb_parity_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rb_parity_mark.Location = new System.Drawing.Point(6, 67);
            this.rb_parity_mark.Name = "rb_parity_mark";
            this.rb_parity_mark.Size = new System.Drawing.Size(48, 17);
            this.rb_parity_mark.TabIndex = 8;
            this.rb_parity_mark.Text = "mark";
            this.rb_parity_mark.UseVisualStyleBackColor = true;
            // 
            // rb_parity_even
            // 
            this.rb_parity_even.AutoSize = true;
            this.rb_parity_even.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_parity_even.Location = new System.Drawing.Point(6, 50);
            this.rb_parity_even.Name = "rb_parity_even";
            this.rb_parity_even.Size = new System.Drawing.Size(49, 17);
            this.rb_parity_even.TabIndex = 7;
            this.rb_parity_even.Text = "even";
            this.rb_parity_even.UseVisualStyleBackColor = true;
            // 
            // rb_parity_odd
            // 
            this.rb_parity_odd.AutoSize = true;
            this.rb_parity_odd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_parity_odd.Location = new System.Drawing.Point(6, 33);
            this.rb_parity_odd.Name = "rb_parity_odd";
            this.rb_parity_odd.Size = new System.Drawing.Size(43, 17);
            this.rb_parity_odd.TabIndex = 6;
            this.rb_parity_odd.Text = "odd";
            this.rb_parity_odd.UseVisualStyleBackColor = true;
            // 
            // rb_parity_none
            // 
            this.rb_parity_none.AutoSize = true;
            this.rb_parity_none.Checked = true;
            this.rb_parity_none.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_parity_none.Location = new System.Drawing.Point(6, 16);
            this.rb_parity_none.Name = "rb_parity_none";
            this.rb_parity_none.Size = new System.Drawing.Size(49, 17);
            this.rb_parity_none.TabIndex = 5;
            this.rb_parity_none.TabStop = true;
            this.rb_parity_none.Text = "none";
            this.rb_parity_none.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(20, -1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parity";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rb_handshake_rts_xon);
            this.groupBox6.Controls.Add(this.rb_handshake_xon);
            this.groupBox6.Controls.Add(this.rb_handshake_rts);
            this.groupBox6.Controls.Add(this.rb_handshake_none);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox6.Location = new System.Drawing.Point(1, 224);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(144, 92);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            // 
            // rb_handshake_rts_xon
            // 
            this.rb_handshake_rts_xon.AutoSize = true;
            this.rb_handshake_rts_xon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rb_handshake_rts_xon.Location = new System.Drawing.Point(6, 67);
            this.rb_handshake_rts_xon.Name = "rb_handshake_rts_xon";
            this.rb_handshake_rts_xon.Size = new System.Drawing.Size(134, 17);
            this.rb_handshake_rts_xon.TabIndex = 8;
            this.rb_handshake_rts_xon.Text = "RTS/CTS+XON/XOFF";
            this.rb_handshake_rts_xon.UseVisualStyleBackColor = true;
            // 
            // rb_handshake_xon
            // 
            this.rb_handshake_xon.AutoSize = true;
            this.rb_handshake_xon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_handshake_xon.Location = new System.Drawing.Point(6, 50);
            this.rb_handshake_xon.Name = "rb_handshake_xon";
            this.rb_handshake_xon.Size = new System.Drawing.Size(80, 17);
            this.rb_handshake_xon.TabIndex = 7;
            this.rb_handshake_xon.Text = "XON/XOFF";
            this.rb_handshake_xon.UseVisualStyleBackColor = true;
            // 
            // rb_handshake_rts
            // 
            this.rb_handshake_rts.AutoSize = true;
            this.rb_handshake_rts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_handshake_rts.Location = new System.Drawing.Point(6, 33);
            this.rb_handshake_rts.Name = "rb_handshake_rts";
            this.rb_handshake_rts.Size = new System.Drawing.Size(73, 17);
            this.rb_handshake_rts.TabIndex = 6;
            this.rb_handshake_rts.Text = "RTS/CTS";
            this.rb_handshake_rts.UseVisualStyleBackColor = true;
            // 
            // rb_handshake_none
            // 
            this.rb_handshake_none.AutoSize = true;
            this.rb_handshake_none.Checked = true;
            this.rb_handshake_none.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_handshake_none.Location = new System.Drawing.Point(6, 16);
            this.rb_handshake_none.Name = "rb_handshake_none";
            this.rb_handshake_none.Size = new System.Drawing.Size(49, 17);
            this.rb_handshake_none.TabIndex = 5;
            this.rb_handshake_none.TabStop = true;
            this.rb_handshake_none.Text = "none";
            this.rb_handshake_none.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(20, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Handshaking";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rb_stopBits_2);
            this.groupBox5.Controls.Add(this.rb_stopBits_1_5);
            this.groupBox5.Controls.Add(this.rb_stopBits_1);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox5.Location = new System.Drawing.Point(151, 114);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(71, 110);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // rb_stopBits_2
            // 
            this.rb_stopBits_2.AutoSize = true;
            this.rb_stopBits_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_stopBits_2.Location = new System.Drawing.Point(6, 80);
            this.rb_stopBits_2.Name = "rb_stopBits_2";
            this.rb_stopBits_2.Size = new System.Drawing.Size(31, 17);
            this.rb_stopBits_2.TabIndex = 6;
            this.rb_stopBits_2.Text = "2";
            this.rb_stopBits_2.UseVisualStyleBackColor = true;
            // 
            // rb_stopBits_1_5
            // 
            this.rb_stopBits_1_5.AutoSize = true;
            this.rb_stopBits_1_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_stopBits_1_5.Location = new System.Drawing.Point(6, 50);
            this.rb_stopBits_1_5.Name = "rb_stopBits_1_5";
            this.rb_stopBits_1_5.Size = new System.Drawing.Size(40, 17);
            this.rb_stopBits_1_5.TabIndex = 5;
            this.rb_stopBits_1_5.Text = "1.5";
            this.rb_stopBits_1_5.UseVisualStyleBackColor = true;
            // 
            // rb_stopBits_1
            // 
            this.rb_stopBits_1.AutoSize = true;
            this.rb_stopBits_1.Checked = true;
            this.rb_stopBits_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_stopBits_1.Location = new System.Drawing.Point(6, 22);
            this.rb_stopBits_1.Name = "rb_stopBits_1";
            this.rb_stopBits_1.Size = new System.Drawing.Size(31, 17);
            this.rb_stopBits_1.TabIndex = 4;
            this.rb_stopBits_1.TabStop = true;
            this.rb_stopBits_1.Text = "1";
            this.rb_stopBits_1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(7, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stop bits";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.btn_PanelPortSettings);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.pictureBox2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 20);
            this.panel4.TabIndex = 2;
            // 
            // btn_PanelPortSettings
            // 
            this.btn_PanelPortSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_PanelPortSettings.FlatAppearance.BorderSize = 0;
            this.btn_PanelPortSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PanelPortSettings.Image = global::Terrarium.Properties.Resources.icons8_Sort_Left_16px;
            this.btn_PanelPortSettings.Location = new System.Drawing.Point(198, 0);
            this.btn_PanelPortSettings.Margin = new System.Windows.Forms.Padding(0);
            this.btn_PanelPortSettings.Name = "btn_PanelPortSettings";
            this.btn_PanelPortSettings.Size = new System.Drawing.Size(27, 20);
            this.btn_PanelPortSettings.TabIndex = 3;
            this.btn_PanelPortSettings.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(22, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Port settings";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Terrarium.Properties.Resources.icons8_Wrench_22px;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(225, 20);
            this.panel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label6.Location = new System.Drawing.Point(22, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Port name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Terrarium.Properties.Resources.icons8_RS_232_Male_22px;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_PortName
            // 
            this.pnl_PortName.Controls.Add(this.btn_SerialPortRefresh);
            this.pnl_PortName.Controls.Add(this.cmb_SerialPortList);
            this.pnl_PortName.Location = new System.Drawing.Point(0, 20);
            this.pnl_PortName.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_PortName.Name = "pnl_PortName";
            this.pnl_PortName.Size = new System.Drawing.Size(225, 38);
            this.pnl_PortName.TabIndex = 1;
            // 
            // btn_SerialPortRefresh
            // 
            this.btn_SerialPortRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SerialPortRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_SerialPortRefresh.FlatAppearance.BorderSize = 0;
            this.btn_SerialPortRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SerialPortRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SerialPortRefresh.Image = global::Terrarium.Properties.Resources.icons8_Refresh_22px;
            this.btn_SerialPortRefresh.Location = new System.Drawing.Point(188, 3);
            this.btn_SerialPortRefresh.Name = "btn_SerialPortRefresh";
            this.btn_SerialPortRefresh.Size = new System.Drawing.Size(32, 32);
            this.btn_SerialPortRefresh.TabIndex = 6;
            this.btn_SerialPortRefresh.UseVisualStyleBackColor = false;
            this.btn_SerialPortRefresh.Click += new System.EventHandler(this.btn_SerialPortRefresh_Click);
            // 
            // cmb_SerialPortList
            // 
            this.cmb_SerialPortList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cmb_SerialPortList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cmb_SerialPortList.BorderStyle = System.Windows.Forms.ButtonBorderStyle.Solid;
            this.cmb_SerialPortList.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.cmb_SerialPortList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SerialPortList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cmb_SerialPortList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cmb_SerialPortList.FormattingEnabled = true;
            this.cmb_SerialPortList.Location = new System.Drawing.Point(3, 6);
            this.cmb_SerialPortList.Name = "cmb_SerialPortList";
            this.cmb_SerialPortList.Size = new System.Drawing.Size(87, 23);
            this.cmb_SerialPortList.TabIndex = 8;
            this.cmb_SerialPortList.SelectedValueChanged += new System.EventHandler(this.cmb_SerialPortList_SelectedValueChanged);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel8.Controls.Add(this.btn_Transmiting);
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.pictureBox4);
            this.panel8.Location = new System.Drawing.Point(0, 508);
            this.panel8.Margin = new System.Windows.Forms.Padding(0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(225, 20);
            this.panel8.TabIndex = 6;
            // 
            // btn_Transmiting
            // 
            this.btn_Transmiting.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Transmiting.FlatAppearance.BorderSize = 0;
            this.btn_Transmiting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transmiting.Image = global::Terrarium.Properties.Resources.icons8_Sort_Left_16px;
            this.btn_Transmiting.Location = new System.Drawing.Point(198, 0);
            this.btn_Transmiting.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Transmiting.Name = "btn_Transmiting";
            this.btn_Transmiting.Size = new System.Drawing.Size(27, 20);
            this.btn_Transmiting.TabIndex = 4;
            this.btn_Transmiting.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label8.Location = new System.Drawing.Point(22, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Transmiting";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Terrarium.Properties.Resources.icons8_Upload_22px;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(20, 20);
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // pnl_Transmiting
            // 
            this.pnl_Transmiting.Controls.Add(this.cb_Tx_Hex);
            this.pnl_Transmiting.Controls.Add(this.cb_TxMacroSend);
            this.pnl_Transmiting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Transmiting.Location = new System.Drawing.Point(0, 528);
            this.pnl_Transmiting.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Transmiting.Name = "pnl_Transmiting";
            this.pnl_Transmiting.Size = new System.Drawing.Size(225, 155);
            this.pnl_Transmiting.TabIndex = 7;
            // 
            // cb_Tx_Hex
            // 
            this.cb_Tx_Hex.AutoSize = true;
            this.cb_Tx_Hex.Checked = true;
            this.cb_Tx_Hex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Tx_Hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_Tx_Hex.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Tx_Hex.Location = new System.Drawing.Point(5, 3);
            this.cb_Tx_Hex.Name = "cb_Tx_Hex";
            this.cb_Tx_Hex.Size = new System.Drawing.Size(48, 17);
            this.cb_Tx_Hex.TabIndex = 4;
            this.cb_Tx_Hex.Text = "HEX";
            this.cb_Tx_Hex.UseVisualStyleBackColor = true;
            // 
            // cb_TxMacroSend
            // 
            this.cb_TxMacroSend.AutoSize = true;
            this.cb_TxMacroSend.Checked = true;
            this.cb_TxMacroSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_TxMacroSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_TxMacroSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_TxMacroSend.Location = new System.Drawing.Point(5, 26);
            this.cb_TxMacroSend.Name = "cb_TxMacroSend";
            this.cb_TxMacroSend.Size = new System.Drawing.Size(56, 17);
            this.cb_TxMacroSend.TabIndex = 3;
            this.cb_TxMacroSend.Text = "Macro";
            this.cb_TxMacroSend.UseVisualStyleBackColor = true;
            this.cb_TxMacroSend.CheckedChanged += new System.EventHandler(this.cb_TxMacroSend_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.lbl_TxCounter);
            this.panel1.Controls.Add(this.lbl_RxCounter);
            this.panel1.Controls.Add(this.lbl_Status);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 659);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 24);
            this.panel1.TabIndex = 3;
            // 
            // lbl_TxCounter
            // 
            this.lbl_TxCounter.AutoSize = true;
            this.lbl_TxCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_TxCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TxCounter.Location = new System.Drawing.Point(212, 5);
            this.lbl_TxCounter.Name = "lbl_TxCounter";
            this.lbl_TxCounter.Size = new System.Drawing.Size(36, 13);
            this.lbl_TxCounter.TabIndex = 2;
            this.lbl_TxCounter.Text = "Tx: 0";
            this.lbl_TxCounter.DoubleClick += new System.EventHandler(this.lbl_TxCounter_DoubleClick);
            // 
            // lbl_RxCounter
            // 
            this.lbl_RxCounter.AutoSize = true;
            this.lbl_RxCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_RxCounter.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_RxCounter.Location = new System.Drawing.Point(139, 5);
            this.lbl_RxCounter.Name = "lbl_RxCounter";
            this.lbl_RxCounter.Size = new System.Drawing.Size(37, 13);
            this.lbl_RxCounter.TabIndex = 1;
            this.lbl_RxCounter.Text = "Rx: 0";
            this.lbl_RxCounter.DoubleClick += new System.EventHandler(this.lbl_RxCounter_DoubleClick);
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Status.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_Status.Location = new System.Drawing.Point(3, 5);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(43, 13);
            this.lbl_Status.TabIndex = 0;
            this.lbl_Status.Text = "Status";
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
            this.rtb_Tx.Location = new System.Drawing.Point(0, 489);
            this.rtb_Tx.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Tx.Name = "rtb_Tx";
            this.rtb_Tx.Size = new System.Drawing.Size(619, 70);
            this.rtb_Tx.TabIndex = 1;
            this.rtb_Tx.Text = "";
            this.rtb_Tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtb_Tx_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.nrtb_Rx, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Tx, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.macroPannel, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 659);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // nrtb_Rx
            // 
            this.nrtb_Rx.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nrtb_Rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nrtb_Rx.Location = new System.Drawing.Point(0, 0);
            this.nrtb_Rx.Margin = new System.Windows.Forms.Padding(0);
            this.nrtb_Rx.Name = "nrtb_Rx";
            this.nrtb_Rx.NumStripAutoscroll = false;
            this.nrtb_Rx.NumStripVisible = true;
            this.nrtb_Rx.Size = new System.Drawing.Size(619, 489);
            this.nrtb_Rx.TabIndex = 3;
            // 
            // macroPannel
            // 
            this.macroPannel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.macroPannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.macroPannel.BtnM10Text = "M10";
            this.macroPannel.BtnM11Text = "M11";
            this.macroPannel.BtnM12Text = "M12";
            this.macroPannel.BtnM13Text = "M13";
            this.macroPannel.BtnM14Text = "M14";
            this.macroPannel.BtnM15Text = "M15";
            this.macroPannel.BtnM16Text = "M16";
            this.macroPannel.BtnM17Text = "M17";
            this.macroPannel.BtnM18Text = "M18";
            this.macroPannel.BtnM19Text = "M19";
            this.macroPannel.BtnM1Text = "M1";
            this.macroPannel.BtnM20Text = "M20";
            this.macroPannel.BtnM2Text = "M2";
            this.macroPannel.BtnM3Text = "M3";
            this.macroPannel.BtnM4Text = "M4";
            this.macroPannel.BtnM5Text = "M5";
            this.macroPannel.BtnM6Text = "M6";
            this.macroPannel.BtnM7Text = "M7";
            this.macroPannel.BtnM8Text = "M8";
            this.macroPannel.BtnM9Text = "M9";
            this.macroPannel.Location = new System.Drawing.Point(0, 559);
            this.macroPannel.Margin = new System.Windows.Forms.Padding(0);
            this.macroPannel.MaximumSize = new System.Drawing.Size(0, 100);
            this.macroPannel.MinimumSize = new System.Drawing.Size(619, 100);
            this.macroPannel.Name = "macroPannel";
            this.macroPannel.Size = new System.Drawing.Size(619, 100);
            this.macroPannel.TabIndex = 4;
            this.macroPannel.VisibleMacroButtons = false;
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // propertysToolStripMenuItem
            // 
            this.propertysToolStripMenuItem.Name = "propertysToolStripMenuItem";
            this.propertysToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // copyToolStripMenuItem1
            // 
            this.copyToolStripMenuItem1.Name = "copyToolStripMenuItem1";
            this.copyToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(884, 683);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Settings);
            this.Controls.Add(this.pnl_ToolBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terrarium";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_ToolBar.ResumeLayout(false);
            this.pnl_Settings.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.pnl_Receiving.ResumeLayout(false);
            this.pnl_Receiving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmn_ByteSort)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.pnl_PortSettings.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_PortName.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.pnl_Transmiting.ResumeLayout(false);
            this.pnl_Transmiting.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_ToolBar;
        private System.Windows.Forms.Panel pnl_Settings;
        private System.Windows.Forms.Button btn_Settings;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer tmr_MenuSlide;
        private System.Windows.Forms.RichTextBox rtb_Tx;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btn_SerialConnect;
        private System.Windows.Forms.Button btn_CleanTxField;
        private System.Windows.Forms.Button btn_CleanRxField;
        private System.Windows.Forms.Button btn_SerialPortRefresh;
        private FlattenCombo cmb_SerialPortList;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rb_baudRate_14400;
        private System.Windows.Forms.RadioButton rb_baudRate_9600;
        private System.Windows.Forms.RadioButton rb_baudRate_4800;
        private System.Windows.Forms.RadioButton rb_baudRate_custome;
        private System.Windows.Forms.RadioButton rb_baudRate_256000;
        private System.Windows.Forms.RadioButton rb_baudRate_128000;
        private System.Windows.Forms.RadioButton rb_baudRate_115200;
        private System.Windows.Forms.RadioButton rb_baudRate_57600;
        private System.Windows.Forms.RadioButton rb_baudRate_38400;
        private System.Windows.Forms.RadioButton rb_baudRate_28800;
        private System.Windows.Forms.RadioButton rb_baudRate_19200;
        private System.Windows.Forms.TextBox tb_baudRateCustome;
        private System.Windows.Forms.RadioButton rb_baudRate_460800;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rb_stopBits_2;
        private System.Windows.Forms.RadioButton rb_stopBits_1_5;
        private System.Windows.Forms.RadioButton rb_stopBits_1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb_parity_space;
        private System.Windows.Forms.RadioButton rb_parity_mark;
        private System.Windows.Forms.RadioButton rb_parity_even;
        private System.Windows.Forms.RadioButton rb_parity_odd;
        private System.Windows.Forms.RadioButton rb_parity_none;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rb_handshake_rts_xon;
        private System.Windows.Forms.RadioButton rb_handshake_xon;
        private System.Windows.Forms.RadioButton rb_handshake_rts;
        private System.Windows.Forms.RadioButton rb_handshake_none;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_baudRate_56000;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_TxCounter;
        private System.Windows.Forms.Label lbl_RxCounter;
        private System.Windows.Forms.CheckBox cb_RxAutoscroll;
        private System.Windows.Forms.CheckBox cb_Rx_Hex;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propertysToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem1;
        private System.Windows.Forms.CheckBox cb_Sort;
        private System.Windows.Forms.CheckBox cb_Loging;
        private System.Windows.Forms.CheckBox cb_LinesNum;
        private NumberedRTB nrtb_Rx;
        private System.Windows.Forms.NumericUpDown nmn_ByteSort;
        private System.Windows.Forms.CheckBox cb_TxMacroSend;
        private MacroPanel macroPannel;
        private System.Windows.Forms.CheckBox cb_Tx_Hex;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel pnl_Receiving;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel pnl_PortSettings;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel pnl_PortName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_PanelReceiving;
        private System.Windows.Forms.Button btn_PanelPortSettings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rb_dataBits_8;
        private System.Windows.Forms.RadioButton rb_dataBits_7;
        private System.Windows.Forms.RadioButton rb_dataBits_6;
        private System.Windows.Forms.RadioButton rb_dataBits_5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btn_Transmiting;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel pnl_Transmiting;
    }
}

