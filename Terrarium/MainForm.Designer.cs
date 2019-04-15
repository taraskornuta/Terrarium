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
            this.mainLayoutPanelSettings = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_Receiving = new System.Windows.Forms.Panel();
            this.dataFormatPanel = new Terrarium.DataFormaterSwitch();
            this.nmn_ByteSort = new System.Windows.Forms.NumericUpDown();
            this.cb_RxAutoscroll = new System.Windows.Forms.CheckBox();
            this.cb_Sort = new System.Windows.Forms.CheckBox();
            this.cb_Loging = new System.Windows.Forms.CheckBox();
            this.cb_LinesNum = new System.Windows.Forms.CheckBox();
            this.pnl_PortSettings = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.rb_handshake_rts_xon = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rb_handshake_xon = new System.Windows.Forms.RadioButton();
            this.rb_handshake_none = new System.Windows.Forms.RadioButton();
            this.rb_handshake_rts = new System.Windows.Forms.RadioButton();
            this.panel10 = new System.Windows.Forms.Panel();
            this.rb_stopBits_2 = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rb_stopBits_1_5 = new System.Windows.Forms.RadioButton();
            this.rb_stopBits_1 = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.rb_parity_space = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_parity_mark = new System.Windows.Forms.RadioButton();
            this.rb_parity_none = new System.Windows.Forms.RadioButton();
            this.rb_parity_even = new System.Windows.Forms.RadioButton();
            this.rb_parity_odd = new System.Windows.Forms.RadioButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rb_dataBits_8 = new System.Windows.Forms.RadioButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rb_dataBits_7 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_dataBits_6 = new System.Windows.Forms.RadioButton();
            this.rb_dataBits_5 = new System.Windows.Forms.RadioButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rb_baudRate_460800 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_4800 = new System.Windows.Forms.RadioButton();
            this.tb_baudRateCustome = new System.Windows.Forms.TextBox();
            this.rb_baudRate_9600 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_custome = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_14400 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_256000 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_19200 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_128000 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_28800 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_115200 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_38400 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_57600 = new System.Windows.Forms.RadioButton();
            this.rb_baudRate_56000 = new System.Windows.Forms.RadioButton();
            this.pnl_PortName = new System.Windows.Forms.Panel();
            this.btn_SerialPortRefresh = new System.Windows.Forms.Button();
            this.cmb_SerialPortList = new Terrarium.FlattenCombo();
            this.dropDownPanelSettings = new Terrarium.DropDownPanel();
            this.dropDownPanelReceiving = new Terrarium.DropDownPanel();
            this.dropDownPanel4 = new Terrarium.DropDownPanel();
            this.dropDownPanelTransmiting = new Terrarium.DropDownPanel();
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
            this.mainLayoutPanelSettings.SuspendLayout();
            this.pnl_Receiving.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmn_ByteSort)).BeginInit();
            this.pnl_PortSettings.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnl_PortName.SuspendLayout();
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
            this.pnl_ToolBar.Size = new System.Drawing.Size(40, 591);
            this.pnl_ToolBar.TabIndex = 1;
            // 
            // btn_CleanRxField
            // 
            this.btn_CleanRxField.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_CleanRxField.FlatAppearance.BorderSize = 0;
            this.btn_CleanRxField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CleanRxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CleanRxField.Image = ((System.Drawing.Image)(resources.GetObject("btn_CleanRxField.Image")));
            this.btn_CleanRxField.Location = new System.Drawing.Point(2, 427);
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
            this.btn_CleanTxField.Location = new System.Drawing.Point(2, 504);
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
            this.btn_Settings.Location = new System.Drawing.Point(2, 545);
            this.btn_Settings.Name = "btn_Settings";
            this.btn_Settings.Size = new System.Drawing.Size(37, 41);
            this.btn_Settings.TabIndex = 0;
            this.btn_Settings.UseVisualStyleBackColor = true;
            this.btn_Settings.Click += new System.EventHandler(this.btn_Settings_Click);
            // 
            // pnl_Settings
            // 
            this.pnl_Settings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.pnl_Settings.Controls.Add(this.mainLayoutPanelSettings);
            this.pnl_Settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Settings.Location = new System.Drawing.Point(619, 0);
            this.pnl_Settings.Name = "pnl_Settings";
            this.pnl_Settings.Size = new System.Drawing.Size(225, 591);
            this.pnl_Settings.TabIndex = 2;
            // 
            // mainLayoutPanelSettings
            // 
            this.mainLayoutPanelSettings.ColumnCount = 1;
            this.mainLayoutPanelSettings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainLayoutPanelSettings.Controls.Add(this.pnl_Receiving, 0, 5);
            this.mainLayoutPanelSettings.Controls.Add(this.pnl_PortSettings, 0, 3);
            this.mainLayoutPanelSettings.Controls.Add(this.pnl_PortName, 0, 1);
            this.mainLayoutPanelSettings.Controls.Add(this.dropDownPanelSettings, 0, 2);
            this.mainLayoutPanelSettings.Controls.Add(this.dropDownPanelReceiving, 0, 4);
            this.mainLayoutPanelSettings.Controls.Add(this.dropDownPanel4, 0, 0);
            this.mainLayoutPanelSettings.Controls.Add(this.dropDownPanelTransmiting, 0, 6);
            this.mainLayoutPanelSettings.Controls.Add(this.pnl_Transmiting, 0, 7);
            this.mainLayoutPanelSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainLayoutPanelSettings.Location = new System.Drawing.Point(0, 0);
            this.mainLayoutPanelSettings.Margin = new System.Windows.Forms.Padding(0);
            this.mainLayoutPanelSettings.Name = "mainLayoutPanelSettings";
            this.mainLayoutPanelSettings.RowCount = 8;
            this.mainLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.mainLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 316F));
            this.mainLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.mainLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainLayoutPanelSettings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.mainLayoutPanelSettings.Size = new System.Drawing.Size(225, 591);
            this.mainLayoutPanelSettings.TabIndex = 16;
            // 
            // pnl_Receiving
            // 
            this.pnl_Receiving.Controls.Add(this.dataFormatPanel);
            this.pnl_Receiving.Controls.Add(this.nmn_ByteSort);
            this.pnl_Receiving.Controls.Add(this.cb_RxAutoscroll);
            this.pnl_Receiving.Controls.Add(this.cb_Sort);
            this.pnl_Receiving.Controls.Add(this.cb_Loging);
            this.pnl_Receiving.Controls.Add(this.cb_LinesNum);
            this.pnl_Receiving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Receiving.Location = new System.Drawing.Point(0, 414);
            this.pnl_Receiving.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Receiving.Name = "pnl_Receiving";
            this.pnl_Receiving.Size = new System.Drawing.Size(225, 100);
            this.pnl_Receiving.TabIndex = 5;
            // 
            // dataFormatPanel
            // 
            this.dataFormatPanel.DataFormat = Terrarium.eDataFormat.ASCII;
            this.dataFormatPanel.DoubleClickInterval = 50;
            this.dataFormatPanel.Location = new System.Drawing.Point(0, 2);
            this.dataFormatPanel.Margin = new System.Windows.Forms.Padding(0);
            this.dataFormatPanel.Name = "dataFormatPanel";
            this.dataFormatPanel.Size = new System.Drawing.Size(225, 25);
            this.dataFormatPanel.TabIndex = 17;
            // 
            // nmn_ByteSort
            // 
            this.nmn_ByteSort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.nmn_ByteSort.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nmn_ByteSort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nmn_ByteSort.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.nmn_ByteSort.Location = new System.Drawing.Point(56, 76);
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
            this.cb_RxAutoscroll.Location = new System.Drawing.Point(128, 45);
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
            this.cb_Sort.Location = new System.Drawing.Point(4, 77);
            this.cb_Sort.Name = "cb_Sort";
            this.cb_Sort.Size = new System.Drawing.Size(45, 17);
            this.cb_Sort.TabIndex = 6;
            this.cb_Sort.Text = "Sort";
            this.cb_Sort.UseVisualStyleBackColor = true;
            this.cb_Sort.CheckedChanged += new System.EventHandler(this.cb_Sort_CheckedChanged);
            // 
            // cb_Loging
            // 
            this.cb_Loging.AutoSize = true;
            this.cb_Loging.Checked = true;
            this.cb_Loging.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Loging.Enabled = false;
            this.cb_Loging.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.cb_Loging.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.cb_Loging.Location = new System.Drawing.Point(128, 78);
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
            this.cb_LinesNum.Location = new System.Drawing.Point(128, 61);
            this.cb_LinesNum.Name = "cb_LinesNum";
            this.cb_LinesNum.Size = new System.Drawing.Size(91, 17);
            this.cb_LinesNum.TabIndex = 4;
            this.cb_LinesNum.Text = "Lines Number";
            this.cb_LinesNum.UseVisualStyleBackColor = true;
            this.cb_LinesNum.CheckedChanged += new System.EventHandler(this.cb_LinesNum_CheckedChanged);
            // 
            // pnl_PortSettings
            // 
            this.pnl_PortSettings.Controls.Add(this.panel11);
            this.pnl_PortSettings.Controls.Add(this.panel10);
            this.pnl_PortSettings.Controls.Add(this.panel9);
            this.pnl_PortSettings.Controls.Add(this.panel5);
            this.pnl_PortSettings.Controls.Add(this.panel3);
            this.pnl_PortSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_PortSettings.Location = new System.Drawing.Point(0, 78);
            this.pnl_PortSettings.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_PortSettings.Name = "pnl_PortSettings";
            this.pnl_PortSettings.Size = new System.Drawing.Size(225, 316);
            this.pnl_PortSettings.TabIndex = 3;
            // 
            // panel11
            // 
            this.panel11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel11.Controls.Add(this.rb_handshake_rts_xon);
            this.panel11.Controls.Add(this.label5);
            this.panel11.Controls.Add(this.rb_handshake_xon);
            this.panel11.Controls.Add(this.rb_handshake_none);
            this.panel11.Controls.Add(this.rb_handshake_rts);
            this.panel11.Location = new System.Drawing.Point(0, 220);
            this.panel11.Margin = new System.Windows.Forms.Padding(0);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(225, 96);
            this.panel11.TabIndex = 18;
            // 
            // rb_handshake_rts_xon
            // 
            this.rb_handshake_rts_xon.AutoSize = true;
            this.rb_handshake_rts_xon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rb_handshake_rts_xon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_handshake_rts_xon.Location = new System.Drawing.Point(12, 72);
            this.rb_handshake_rts_xon.Name = "rb_handshake_rts_xon";
            this.rb_handshake_rts_xon.Size = new System.Drawing.Size(134, 17);
            this.rb_handshake_rts_xon.TabIndex = 8;
            this.rb_handshake_rts_xon.Text = "RTS/CTS+XON/XOFF";
            this.rb_handshake_rts_xon.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(76, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Handshaking";
            // 
            // rb_handshake_xon
            // 
            this.rb_handshake_xon.AutoSize = true;
            this.rb_handshake_xon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_handshake_xon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_handshake_xon.Location = new System.Drawing.Point(12, 55);
            this.rb_handshake_xon.Name = "rb_handshake_xon";
            this.rb_handshake_xon.Size = new System.Drawing.Size(80, 17);
            this.rb_handshake_xon.TabIndex = 7;
            this.rb_handshake_xon.Text = "XON/XOFF";
            this.rb_handshake_xon.UseVisualStyleBackColor = true;
            // 
            // rb_handshake_none
            // 
            this.rb_handshake_none.AutoSize = true;
            this.rb_handshake_none.Checked = true;
            this.rb_handshake_none.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_handshake_none.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_handshake_none.Location = new System.Drawing.Point(12, 21);
            this.rb_handshake_none.Name = "rb_handshake_none";
            this.rb_handshake_none.Size = new System.Drawing.Size(49, 17);
            this.rb_handshake_none.TabIndex = 5;
            this.rb_handshake_none.TabStop = true;
            this.rb_handshake_none.Text = "none";
            this.rb_handshake_none.UseVisualStyleBackColor = true;
            // 
            // rb_handshake_rts
            // 
            this.rb_handshake_rts.AutoSize = true;
            this.rb_handshake_rts.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_handshake_rts.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_handshake_rts.Location = new System.Drawing.Point(12, 38);
            this.rb_handshake_rts.Name = "rb_handshake_rts";
            this.rb_handshake_rts.Size = new System.Drawing.Size(73, 17);
            this.rb_handshake_rts.TabIndex = 6;
            this.rb_handshake_rts.Text = "RTS/CTS";
            this.rb_handshake_rts.UseVisualStyleBackColor = true;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel10.Controls.Add(this.rb_stopBits_2);
            this.panel10.Controls.Add(this.label4);
            this.panel10.Controls.Add(this.rb_stopBits_1_5);
            this.panel10.Controls.Add(this.rb_stopBits_1);
            this.panel10.Location = new System.Drawing.Point(148, 110);
            this.panel10.Margin = new System.Windows.Forms.Padding(0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(77, 110);
            this.panel10.TabIndex = 17;
            // 
            // rb_stopBits_2
            // 
            this.rb_stopBits_2.AutoSize = true;
            this.rb_stopBits_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_stopBits_2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_stopBits_2.Location = new System.Drawing.Point(8, 80);
            this.rb_stopBits_2.Name = "rb_stopBits_2";
            this.rb_stopBits_2.Size = new System.Drawing.Size(31, 17);
            this.rb_stopBits_2.TabIndex = 6;
            this.rb_stopBits_2.Text = "2";
            this.rb_stopBits_2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(14, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stop bits";
            // 
            // rb_stopBits_1_5
            // 
            this.rb_stopBits_1_5.AutoSize = true;
            this.rb_stopBits_1_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_stopBits_1_5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_stopBits_1_5.Location = new System.Drawing.Point(8, 50);
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
            this.rb_stopBits_1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_stopBits_1.Location = new System.Drawing.Point(8, 22);
            this.rb_stopBits_1.Name = "rb_stopBits_1";
            this.rb_stopBits_1.Size = new System.Drawing.Size(31, 17);
            this.rb_stopBits_1.TabIndex = 4;
            this.rb_stopBits_1.TabStop = true;
            this.rb_stopBits_1.Text = "1";
            this.rb_stopBits_1.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel9.Controls.Add(this.rb_parity_space);
            this.panel9.Controls.Add(this.label3);
            this.panel9.Controls.Add(this.rb_parity_mark);
            this.panel9.Controls.Add(this.rb_parity_none);
            this.panel9.Controls.Add(this.rb_parity_even);
            this.panel9.Controls.Add(this.rb_parity_odd);
            this.panel9.Location = new System.Drawing.Point(74, 110);
            this.panel9.Margin = new System.Windows.Forms.Padding(0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(75, 110);
            this.panel9.TabIndex = 16;
            // 
            // rb_parity_space
            // 
            this.rb_parity_space.AutoSize = true;
            this.rb_parity_space.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_parity_space.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_parity_space.Location = new System.Drawing.Point(6, 84);
            this.rb_parity_space.Name = "rb_parity_space";
            this.rb_parity_space.Size = new System.Drawing.Size(54, 17);
            this.rb_parity_space.TabIndex = 9;
            this.rb_parity_space.Text = "space";
            this.rb_parity_space.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(20, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parity";
            // 
            // rb_parity_mark
            // 
            this.rb_parity_mark.AutoSize = true;
            this.rb_parity_mark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.rb_parity_mark.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_parity_mark.Location = new System.Drawing.Point(6, 67);
            this.rb_parity_mark.Name = "rb_parity_mark";
            this.rb_parity_mark.Size = new System.Drawing.Size(48, 17);
            this.rb_parity_mark.TabIndex = 8;
            this.rb_parity_mark.Text = "mark";
            this.rb_parity_mark.UseVisualStyleBackColor = true;
            // 
            // rb_parity_none
            // 
            this.rb_parity_none.AutoSize = true;
            this.rb_parity_none.Checked = true;
            this.rb_parity_none.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_parity_none.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_parity_none.Location = new System.Drawing.Point(6, 16);
            this.rb_parity_none.Name = "rb_parity_none";
            this.rb_parity_none.Size = new System.Drawing.Size(49, 17);
            this.rb_parity_none.TabIndex = 5;
            this.rb_parity_none.TabStop = true;
            this.rb_parity_none.Text = "none";
            this.rb_parity_none.UseVisualStyleBackColor = true;
            // 
            // rb_parity_even
            // 
            this.rb_parity_even.AutoSize = true;
            this.rb_parity_even.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_parity_even.ForeColor = System.Drawing.Color.WhiteSmoke;
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
            this.rb_parity_odd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_parity_odd.Location = new System.Drawing.Point(6, 33);
            this.rb_parity_odd.Name = "rb_parity_odd";
            this.rb_parity_odd.Size = new System.Drawing.Size(43, 17);
            this.rb_parity_odd.TabIndex = 6;
            this.rb_parity_odd.Text = "odd";
            this.rb_parity_odd.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel5.Controls.Add(this.rb_dataBits_8);
            this.panel5.Controls.Add(this.panel7);
            this.panel5.Controls.Add(this.rb_dataBits_7);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.rb_dataBits_6);
            this.panel5.Controls.Add(this.rb_dataBits_5);
            this.panel5.Location = new System.Drawing.Point(0, 110);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(75, 110);
            this.panel5.TabIndex = 15;
            // 
            // rb_dataBits_8
            // 
            this.rb_dataBits_8.AutoSize = true;
            this.rb_dataBits_8.Checked = true;
            this.rb_dataBits_8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_dataBits_8.Location = new System.Drawing.Point(12, 82);
            this.rb_dataBits_8.Name = "rb_dataBits_8";
            this.rb_dataBits_8.Size = new System.Drawing.Size(31, 17);
            this.rb_dataBits_8.TabIndex = 4;
            this.rb_dataBits_8.TabStop = true;
            this.rb_dataBits_8.Text = "8";
            this.rb_dataBits_8.UseVisualStyleBackColor = true;
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(77, 1);
            this.panel7.Margin = new System.Windows.Forms.Padding(0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(77, 100);
            this.panel7.TabIndex = 16;
            // 
            // rb_dataBits_7
            // 
            this.rb_dataBits_7.AutoSize = true;
            this.rb_dataBits_7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_dataBits_7.Location = new System.Drawing.Point(12, 61);
            this.rb_dataBits_7.Name = "rb_dataBits_7";
            this.rb_dataBits_7.Size = new System.Drawing.Size(31, 17);
            this.rb_dataBits_7.TabIndex = 3;
            this.rb_dataBits_7.Text = "7";
            this.rb_dataBits_7.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(12, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data bits";
            // 
            // rb_dataBits_6
            // 
            this.rb_dataBits_6.AutoSize = true;
            this.rb_dataBits_6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_dataBits_6.Location = new System.Drawing.Point(12, 40);
            this.rb_dataBits_6.Name = "rb_dataBits_6";
            this.rb_dataBits_6.Size = new System.Drawing.Size(31, 17);
            this.rb_dataBits_6.TabIndex = 2;
            this.rb_dataBits_6.Text = "6";
            this.rb_dataBits_6.UseVisualStyleBackColor = true;
            // 
            // rb_dataBits_5
            // 
            this.rb_dataBits_5.AutoSize = true;
            this.rb_dataBits_5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_dataBits_5.Location = new System.Drawing.Point(12, 19);
            this.rb_dataBits_5.Name = "rb_dataBits_5";
            this.rb_dataBits_5.Size = new System.Drawing.Size(31, 17);
            this.rb_dataBits_5.TabIndex = 1;
            this.rb_dataBits_5.Text = "5";
            this.rb_dataBits_5.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.rb_baudRate_460800);
            this.panel3.Controls.Add(this.rb_baudRate_4800);
            this.panel3.Controls.Add(this.tb_baudRateCustome);
            this.panel3.Controls.Add(this.rb_baudRate_9600);
            this.panel3.Controls.Add(this.rb_baudRate_custome);
            this.panel3.Controls.Add(this.rb_baudRate_14400);
            this.panel3.Controls.Add(this.rb_baudRate_256000);
            this.panel3.Controls.Add(this.rb_baudRate_19200);
            this.panel3.Controls.Add(this.rb_baudRate_128000);
            this.panel3.Controls.Add(this.rb_baudRate_28800);
            this.panel3.Controls.Add(this.rb_baudRate_115200);
            this.panel3.Controls.Add(this.rb_baudRate_38400);
            this.panel3.Controls.Add(this.rb_baudRate_57600);
            this.panel3.Controls.Add(this.rb_baudRate_56000);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(225, 110);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(86, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Baudrate";
            // 
            // rb_baudRate_460800
            // 
            this.rb_baudRate_460800.AutoSize = true;
            this.rb_baudRate_460800.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_460800.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_460800.Location = new System.Drawing.Point(141, 33);
            this.rb_baudRate_460800.Name = "rb_baudRate_460800";
            this.rb_baudRate_460800.Size = new System.Drawing.Size(61, 17);
            this.rb_baudRate_460800.TabIndex = 13;
            this.rb_baudRate_460800.Text = "460800";
            this.rb_baudRate_460800.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_4800
            // 
            this.rb_baudRate_4800.AutoSize = true;
            this.rb_baudRate_4800.Checked = true;
            this.rb_baudRate_4800.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_4800.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_4800.Location = new System.Drawing.Point(6, 16);
            this.rb_baudRate_4800.Name = "rb_baudRate_4800";
            this.rb_baudRate_4800.Size = new System.Drawing.Size(49, 17);
            this.rb_baudRate_4800.TabIndex = 0;
            this.rb_baudRate_4800.TabStop = true;
            this.rb_baudRate_4800.Text = "4800";
            this.rb_baudRate_4800.UseVisualStyleBackColor = true;
            // 
            // tb_baudRateCustome
            // 
            this.tb_baudRateCustome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.tb_baudRateCustome.Enabled = false;
            this.tb_baudRateCustome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_baudRateCustome.ForeColor = System.Drawing.Color.White;
            this.tb_baudRateCustome.Location = new System.Drawing.Point(139, 78);
            this.tb_baudRateCustome.Margin = new System.Windows.Forms.Padding(0);
            this.tb_baudRateCustome.Name = "tb_baudRateCustome";
            this.tb_baudRateCustome.Size = new System.Drawing.Size(82, 22);
            this.tb_baudRateCustome.TabIndex = 12;
            this.tb_baudRateCustome.Text = "74880";
            this.tb_baudRateCustome.TextChanged += new System.EventHandler(this.tb_baudRateCustome_TextChanged);
            // 
            // rb_baudRate_9600
            // 
            this.rb_baudRate_9600.AutoSize = true;
            this.rb_baudRate_9600.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_9600.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_9600.Location = new System.Drawing.Point(6, 33);
            this.rb_baudRate_9600.Name = "rb_baudRate_9600";
            this.rb_baudRate_9600.Size = new System.Drawing.Size(49, 17);
            this.rb_baudRate_9600.TabIndex = 1;
            this.rb_baudRate_9600.Text = "9600";
            this.rb_baudRate_9600.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_custome
            // 
            this.rb_baudRate_custome.AutoSize = true;
            this.rb_baudRate_custome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_custome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_custome.Location = new System.Drawing.Point(141, 51);
            this.rb_baudRate_custome.Name = "rb_baudRate_custome";
            this.rb_baudRate_custome.Size = new System.Drawing.Size(66, 17);
            this.rb_baudRate_custome.TabIndex = 11;
            this.rb_baudRate_custome.Text = "Custome";
            this.rb_baudRate_custome.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_14400
            // 
            this.rb_baudRate_14400.AutoSize = true;
            this.rb_baudRate_14400.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_14400.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_14400.Location = new System.Drawing.Point(6, 51);
            this.rb_baudRate_14400.Name = "rb_baudRate_14400";
            this.rb_baudRate_14400.Size = new System.Drawing.Size(55, 17);
            this.rb_baudRate_14400.TabIndex = 2;
            this.rb_baudRate_14400.Text = "14400";
            this.rb_baudRate_14400.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_256000
            // 
            this.rb_baudRate_256000.AutoSize = true;
            this.rb_baudRate_256000.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_256000.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_256000.Location = new System.Drawing.Point(141, 16);
            this.rb_baudRate_256000.Name = "rb_baudRate_256000";
            this.rb_baudRate_256000.Size = new System.Drawing.Size(61, 17);
            this.rb_baudRate_256000.TabIndex = 10;
            this.rb_baudRate_256000.Text = "256000";
            this.rb_baudRate_256000.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_19200
            // 
            this.rb_baudRate_19200.AutoSize = true;
            this.rb_baudRate_19200.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_19200.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_19200.Location = new System.Drawing.Point(6, 69);
            this.rb_baudRate_19200.Name = "rb_baudRate_19200";
            this.rb_baudRate_19200.Size = new System.Drawing.Size(55, 17);
            this.rb_baudRate_19200.TabIndex = 3;
            this.rb_baudRate_19200.Text = "19200";
            this.rb_baudRate_19200.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_128000
            // 
            this.rb_baudRate_128000.AutoSize = true;
            this.rb_baudRate_128000.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_128000.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_128000.Location = new System.Drawing.Point(70, 87);
            this.rb_baudRate_128000.Name = "rb_baudRate_128000";
            this.rb_baudRate_128000.Size = new System.Drawing.Size(61, 17);
            this.rb_baudRate_128000.TabIndex = 9;
            this.rb_baudRate_128000.Text = "128000";
            this.rb_baudRate_128000.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_28800
            // 
            this.rb_baudRate_28800.AutoSize = true;
            this.rb_baudRate_28800.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_28800.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_28800.Location = new System.Drawing.Point(6, 87);
            this.rb_baudRate_28800.Name = "rb_baudRate_28800";
            this.rb_baudRate_28800.Size = new System.Drawing.Size(55, 17);
            this.rb_baudRate_28800.TabIndex = 4;
            this.rb_baudRate_28800.Text = "28800";
            this.rb_baudRate_28800.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_115200
            // 
            this.rb_baudRate_115200.AutoSize = true;
            this.rb_baudRate_115200.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_115200.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_115200.Location = new System.Drawing.Point(70, 69);
            this.rb_baudRate_115200.Name = "rb_baudRate_115200";
            this.rb_baudRate_115200.Size = new System.Drawing.Size(61, 17);
            this.rb_baudRate_115200.TabIndex = 8;
            this.rb_baudRate_115200.Text = "115200";
            this.rb_baudRate_115200.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_38400
            // 
            this.rb_baudRate_38400.AutoSize = true;
            this.rb_baudRate_38400.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_38400.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_38400.Location = new System.Drawing.Point(70, 16);
            this.rb_baudRate_38400.Name = "rb_baudRate_38400";
            this.rb_baudRate_38400.Size = new System.Drawing.Size(55, 17);
            this.rb_baudRate_38400.TabIndex = 5;
            this.rb_baudRate_38400.Text = "38400";
            this.rb_baudRate_38400.UseVisualStyleBackColor = true;
            // 
            // rb_baudRate_57600
            // 
            this.rb_baudRate_57600.AutoSize = true;
            this.rb_baudRate_57600.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rb_baudRate_57600.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_57600.Location = new System.Drawing.Point(70, 51);
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
            this.rb_baudRate_56000.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rb_baudRate_56000.Location = new System.Drawing.Point(70, 33);
            this.rb_baudRate_56000.Name = "rb_baudRate_56000";
            this.rb_baudRate_56000.Size = new System.Drawing.Size(55, 17);
            this.rb_baudRate_56000.TabIndex = 6;
            this.rb_baudRate_56000.Text = "56000";
            this.rb_baudRate_56000.UseVisualStyleBackColor = true;
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
            // dropDownPanelSettings
            // 
            this.dropDownPanelSettings.ButtonEnable = true;
            this.dropDownPanelSettings.Location = new System.Drawing.Point(0, 58);
            this.dropDownPanelSettings.Margin = new System.Windows.Forms.Padding(0);
            this.dropDownPanelSettings.Name = "dropDownPanelSettings";
            this.dropDownPanelSettings.PanelIcon = global::Terrarium.Properties.Resources.icons8_Wrench_22px;
            this.dropDownPanelSettings.PanelOpened = true;
            this.dropDownPanelSettings.PanelText = "Port settings";
            this.dropDownPanelSettings.Size = new System.Drawing.Size(225, 20);
            this.dropDownPanelSettings.TabIndex = 8;
            // 
            // dropDownPanelReceiving
            // 
            this.dropDownPanelReceiving.ButtonEnable = true;
            this.dropDownPanelReceiving.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropDownPanelReceiving.Location = new System.Drawing.Point(0, 394);
            this.dropDownPanelReceiving.Margin = new System.Windows.Forms.Padding(0);
            this.dropDownPanelReceiving.Name = "dropDownPanelReceiving";
            this.dropDownPanelReceiving.PanelIcon = global::Terrarium.Properties.Resources.icons8_Download_22px;
            this.dropDownPanelReceiving.PanelOpened = true;
            this.dropDownPanelReceiving.PanelText = "Receiving";
            this.dropDownPanelReceiving.Size = new System.Drawing.Size(225, 20);
            this.dropDownPanelReceiving.TabIndex = 9;
            // 
            // dropDownPanel4
            // 
            this.dropDownPanel4.ButtonEnable = false;
            this.dropDownPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dropDownPanel4.Location = new System.Drawing.Point(0, 0);
            this.dropDownPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.dropDownPanel4.Name = "dropDownPanel4";
            this.dropDownPanel4.PanelIcon = global::Terrarium.Properties.Resources.icons8_RS_232_Male_22px;
            this.dropDownPanel4.PanelOpened = false;
            this.dropDownPanel4.PanelText = "Port";
            this.dropDownPanel4.Size = new System.Drawing.Size(225, 20);
            this.dropDownPanel4.TabIndex = 11;
            // 
            // dropDownPanelTransmiting
            // 
            this.dropDownPanelTransmiting.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dropDownPanelTransmiting.ButtonEnable = true;
            this.dropDownPanelTransmiting.Location = new System.Drawing.Point(0, 514);
            this.dropDownPanelTransmiting.Margin = new System.Windows.Forms.Padding(0);
            this.dropDownPanelTransmiting.Name = "dropDownPanelTransmiting";
            this.dropDownPanelTransmiting.PanelIcon = global::Terrarium.Properties.Resources.icons8_Upload_22px;
            this.dropDownPanelTransmiting.PanelOpened = true;
            this.dropDownPanelTransmiting.PanelText = "Transmiting";
            this.dropDownPanelTransmiting.Size = new System.Drawing.Size(225, 20);
            this.dropDownPanelTransmiting.TabIndex = 10;
            // 
            // pnl_Transmiting
            // 
            this.pnl_Transmiting.Controls.Add(this.cb_Tx_Hex);
            this.pnl_Transmiting.Controls.Add(this.cb_TxMacroSend);
            this.pnl_Transmiting.Location = new System.Drawing.Point(0, 534);
            this.pnl_Transmiting.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_Transmiting.Name = "pnl_Transmiting";
            this.pnl_Transmiting.Size = new System.Drawing.Size(225, 56);
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
            this.cb_TxMacroSend.Location = new System.Drawing.Point(5, 19);
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
            this.panel1.Location = new System.Drawing.Point(0, 567);
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
            this.rtb_Tx.Location = new System.Drawing.Point(0, 397);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 567);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // nrtb_Rx
            // 
            this.nrtb_Rx.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.nrtb_Rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nrtb_Rx.Location = new System.Drawing.Point(0, 0);
            this.nrtb_Rx.Margin = new System.Windows.Forms.Padding(0);
            this.nrtb_Rx.Name = "nrtb_Rx";
            this.nrtb_Rx.NumStripVisible = true;
            this.nrtb_Rx.Size = new System.Drawing.Size(619, 397);
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
            this.macroPannel.Location = new System.Drawing.Point(0, 467);
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
            this.ClientSize = new System.Drawing.Size(884, 591);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_Settings);
            this.Controls.Add(this.pnl_ToolBar);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 500);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Terrarium";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_ToolBar.ResumeLayout(false);
            this.pnl_Settings.ResumeLayout(false);
            this.mainLayoutPanelSettings.ResumeLayout(false);
            this.pnl_Receiving.ResumeLayout(false);
            this.pnl_Receiving.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmn_ByteSort)).EndInit();
            this.pnl_PortSettings.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.pnl_PortName.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel mainLayoutPanelSettings;
        private System.Windows.Forms.Panel pnl_Receiving;
        private System.Windows.Forms.Panel pnl_PortSettings;
        private System.Windows.Forms.Panel pnl_PortName;
        private System.Windows.Forms.RadioButton rb_dataBits_8;
        private System.Windows.Forms.RadioButton rb_dataBits_7;
        private System.Windows.Forms.RadioButton rb_dataBits_6;
        private System.Windows.Forms.RadioButton rb_dataBits_5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_Transmiting;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel11;
        private DropDownPanel dropDownPanelSettings;
        private DropDownPanel dropDownPanelReceiving;
        private DropDownPanel dropDownPanelTransmiting;
        private DropDownPanel dropDownPanel4;
        private DataFormaterSwitch dataFormatPanel;
    }
}

