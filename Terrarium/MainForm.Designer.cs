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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.cb_RxAutoscroll = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rb_parity_space = new System.Windows.Forms.RadioButton();
            this.rb_parity_mark = new System.Windows.Forms.RadioButton();
            this.rb_parity_even = new System.Windows.Forms.RadioButton();
            this.rb_parity_odd = new System.Windows.Forms.RadioButton();
            this.rb_parity_none = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rb_dataBits_8 = new System.Windows.Forms.RadioButton();
            this.rb_dataBits_7 = new System.Windows.Forms.RadioButton();
            this.rb_dataBits_6 = new System.Windows.Forms.RadioButton();
            this.rb_dataBits_5 = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_SerialPortRefresh = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.tmr_MenuSlide = new System.Windows.Forms.Timer(this.components);
            this.rtb_Tx = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_TxString = new System.Windows.Forms.TextBox();
            this.btn_SerialSend = new System.Windows.Forms.Button();
            this.rtb_Rx = new Terrarium.MyRichTextBox();
            this.cmb_SerialPortList = new Terrarium.FlattenCombo();
            this.pnl_ToolBar.SuspendLayout();
            this.pnl_Settings.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.btn_CleanRxField.Image = ((System.Drawing.Image)(resources.GetObject("btn_CleanRxField.Image")));
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
            this.btn_CleanTxField.Image = ((System.Drawing.Image)(resources.GetObject("btn_CleanTxField.Image")));
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
            this.lbl_ComNumber.Enabled = false;
            this.lbl_ComNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_ComNumber.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_ComNumber.Location = new System.Drawing.Point(7, 62);
            this.lbl_ComNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ComNumber.Name = "lbl_ComNumber";
            this.lbl_ComNumber.Size = new System.Drawing.Size(21, 13);
            this.lbl_ComNumber.TabIndex = 3;
            this.lbl_ComNumber.Text = "25";
            this.lbl_ComNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_ComNumber.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(3, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "COM";
            this.label1.Visible = false;
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
            this.btn_Settings.Image = global::Terrarium.Properties.Resources.icons8_Settings_32px;
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
            this.pnl_Settings.Controls.Add(this.groupBox7);
            this.pnl_Settings.Controls.Add(this.groupBox6);
            this.pnl_Settings.Controls.Add(this.groupBox5);
            this.pnl_Settings.Controls.Add(this.groupBox4);
            this.pnl_Settings.Controls.Add(this.groupBox3);
            this.pnl_Settings.Controls.Add(this.groupBox2);
            this.pnl_Settings.Controls.Add(this.groupBox1);
            this.pnl_Settings.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnl_Settings.Location = new System.Drawing.Point(619, 0);
            this.pnl_Settings.Name = "pnl_Settings";
            this.pnl_Settings.Size = new System.Drawing.Size(225, 561);
            this.pnl_Settings.TabIndex = 2;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.cb_RxAutoscroll);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox7.Location = new System.Drawing.Point(0, 367);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(144, 92);
            this.groupBox7.TabIndex = 14;
            this.groupBox7.TabStop = false;
            // 
            // cb_RxAutoscroll
            // 
            this.cb_RxAutoscroll.AutoSize = true;
            this.cb_RxAutoscroll.Checked = true;
            this.cb_RxAutoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_RxAutoscroll.Location = new System.Drawing.Point(7, 19);
            this.cb_RxAutoscroll.Name = "cb_RxAutoscroll";
            this.cb_RxAutoscroll.Size = new System.Drawing.Size(82, 17);
            this.cb_RxAutoscroll.TabIndex = 2;
            this.cb_RxAutoscroll.Text = "Autoscroll";
            this.cb_RxAutoscroll.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(20, 2);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Receive";
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
            this.groupBox6.Location = new System.Drawing.Point(0, 275);
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
            this.groupBox5.Location = new System.Drawing.Point(150, 166);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(75, 110);
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
            this.label4.Location = new System.Drawing.Point(7, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Stop bits";
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
            this.groupBox4.Location = new System.Drawing.Point(72, 166);
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
            this.label3.Location = new System.Drawing.Point(20, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Parity";
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
            this.groupBox3.Location = new System.Drawing.Point(0, 166);
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
            this.groupBox2.Location = new System.Drawing.Point(0, 55);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 112);
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
            this.rb_baudRate_custome.Size = new System.Drawing.Size(65, 17);
            this.rb_baudRate_custome.TabIndex = 11;
            this.rb_baudRate_custome.Text = "custome";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmb_SerialPortList);
            this.groupBox1.Controls.Add(this.btn_SerialPortRefresh);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 55);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM port";
            // 
            // btn_SerialPortRefresh
            // 
            this.btn_SerialPortRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SerialPortRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_SerialPortRefresh.FlatAppearance.BorderSize = 0;
            this.btn_SerialPortRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SerialPortRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SerialPortRefresh.Image = global::Terrarium.Properties.Resources.icons8_Refresh_22px;
            this.btn_SerialPortRefresh.Location = new System.Drawing.Point(189, 14);
            this.btn_SerialPortRefresh.Name = "btn_SerialPortRefresh";
            this.btn_SerialPortRefresh.Size = new System.Drawing.Size(32, 32);
            this.btn_SerialPortRefresh.TabIndex = 6;
            this.btn_SerialPortRefresh.UseVisualStyleBackColor = false;
            this.btn_SerialPortRefresh.Click += new System.EventHandler(this.btn_SerialPortRefresh_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lbl_Status);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 537);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 24);
            this.panel1.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(212, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Tx: 0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(139, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Rx: 0";
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
            this.rtb_Tx.Location = new System.Drawing.Point(0, 438);
            this.rtb_Tx.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Tx.Name = "rtb_Tx";
            this.rtb_Tx.Size = new System.Drawing.Size(619, 75);
            this.rtb_Tx.TabIndex = 1;
            this.rtb_Tx.Text = "";
            this.rtb_Tx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rtb_Tx_KeyPress);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.rtb_Tx, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rtb_Rx, 0, 0);
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
            this.tb_TxString.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_TxString_KeyPress);
            // 
            // btn_SerialSend
            // 
            this.btn_SerialSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_SerialSend.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_SerialSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SerialSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_SerialSend.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_SerialSend.Image = global::Terrarium.Properties.Resources.icons8_Sent_22px;
            this.btn_SerialSend.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SerialSend.Location = new System.Drawing.Point(502, 0);
            this.btn_SerialSend.Margin = new System.Windows.Forms.Padding(0);
            this.btn_SerialSend.Name = "btn_SerialSend";
            this.btn_SerialSend.Size = new System.Drawing.Size(117, 24);
            this.btn_SerialSend.TabIndex = 1;
            this.btn_SerialSend.Text = "Send";
            this.btn_SerialSend.UseVisualStyleBackColor = false;
            this.btn_SerialSend.Click += new System.EventHandler(this.btn_SerialSend_Click);
            // 
            // rtb_Rx
            // 
            this.rtb_Rx.Autoscroll = false;
            this.rtb_Rx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.rtb_Rx.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtb_Rx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtb_Rx.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.rtb_Rx.ForeColor = System.Drawing.Color.White;
            this.rtb_Rx.Location = new System.Drawing.Point(0, 0);
            this.rtb_Rx.Margin = new System.Windows.Forms.Padding(0);
            this.rtb_Rx.Name = "rtb_Rx";
            this.rtb_Rx.Size = new System.Drawing.Size(619, 438);
            this.rtb_Rx.TabIndex = 3;
            this.rtb_Rx.Text = "";
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
            this.cmb_SerialPortList.Location = new System.Drawing.Point(6, 19);
            this.cmb_SerialPortList.Name = "cmb_SerialPortList";
            this.cmb_SerialPortList.Size = new System.Drawing.Size(87, 23);
            this.cmb_SerialPortList.TabIndex = 8;
            this.cmb_SerialPortList.SelectedValueChanged += new System.EventHandler(this.cmb_SerialPortList_SelectedValueChanged);
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
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnl_ToolBar.ResumeLayout(false);
            this.pnl_ToolBar.PerformLayout();
            this.pnl_Settings.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox tb_TxString;
        private System.Windows.Forms.Button btn_SerialSend;
        private System.Windows.Forms.Button btn_SerialConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_ComNumber;
        private System.Windows.Forms.Button btn_CleanTxField;
        private System.Windows.Forms.Button btn_CleanRxField;
        private System.Windows.Forms.Button btn_SerialPortRefresh;
        private FlattenCombo cmb_SerialPortList;
        private System.Windows.Forms.GroupBox groupBox1;
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
        private System.Windows.Forms.GroupBox groupBox3;
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
        private System.Windows.Forms.RadioButton rb_dataBits_8;
        private System.Windows.Forms.RadioButton rb_dataBits_7;
        private System.Windows.Forms.RadioButton rb_dataBits_6;
        private System.Windows.Forms.RadioButton rb_dataBits_5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rb_handshake_rts_xon;
        private System.Windows.Forms.RadioButton rb_handshake_xon;
        private System.Windows.Forms.RadioButton rb_handshake_rts;
        private System.Windows.Forms.RadioButton rb_handshake_none;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rb_baudRate_56000;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox cb_RxAutoscroll;
        private System.Windows.Forms.Label label8;
        private MyRichTextBox rtb_Rx;
    }
}

