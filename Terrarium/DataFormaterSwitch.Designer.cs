namespace Terrarium
{
    partial class DataFormaterSwitch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_bin = new System.Windows.Forms.Button();
            this.btn_ascii = new System.Windows.Forms.Button();
            this.btn_hex = new System.Windows.Forms.Button();
            this.btn_dec = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btn_dec, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_hex, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_ascii, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btn_bin, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(225, 25);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btn_bin
            // 
            this.btn_bin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_bin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_bin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_bin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_bin.Location = new System.Drawing.Point(56, 0);
            this.btn_bin.Margin = new System.Windows.Forms.Padding(0);
            this.btn_bin.Name = "btn_bin";
            this.btn_bin.Size = new System.Drawing.Size(56, 25);
            this.btn_bin.TabIndex = 1;
            this.btn_bin.Text = "BIN";
            this.btn_bin.UseVisualStyleBackColor = false;
            this.btn_bin.Click += new System.EventHandler(this.btn_bin_Click);
            // 
            // btn_ascii
            // 
            this.btn_ascii.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_ascii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_ascii.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ascii.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_ascii.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_ascii.Location = new System.Drawing.Point(0, 0);
            this.btn_ascii.Margin = new System.Windows.Forms.Padding(0);
            this.btn_ascii.Name = "btn_ascii";
            this.btn_ascii.Size = new System.Drawing.Size(56, 25);
            this.btn_ascii.TabIndex = 2;
            this.btn_ascii.Text = "ASCII";
            this.btn_ascii.UseVisualStyleBackColor = false;
            this.btn_ascii.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_ascii_MouseDown);
            // 
            // btn_hex
            // 
            this.btn_hex.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_hex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_hex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_hex.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_hex.Location = new System.Drawing.Point(168, 0);
            this.btn_hex.Margin = new System.Windows.Forms.Padding(0);
            this.btn_hex.Name = "btn_hex";
            this.btn_hex.Size = new System.Drawing.Size(57, 25);
            this.btn_hex.TabIndex = 3;
            this.btn_hex.Text = "HEX";
            this.btn_hex.UseVisualStyleBackColor = false;
            this.btn_hex.Click += new System.EventHandler(this.btn_hex_Click);
            // 
            // btn_dec
            // 
            this.btn_dec.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_dec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_dec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_dec.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_dec.Location = new System.Drawing.Point(112, 0);
            this.btn_dec.Margin = new System.Windows.Forms.Padding(0);
            this.btn_dec.Name = "btn_dec";
            this.btn_dec.Size = new System.Drawing.Size(56, 25);
            this.btn_dec.TabIndex = 4;
            this.btn_dec.Text = "DEC";
            this.btn_dec.UseVisualStyleBackColor = false;
            this.btn_dec.Click += new System.EventHandler(this.btn_dec_Click);
            // 
            // DataFormaterSwitch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "DataFormaterSwitch";
            this.Size = new System.Drawing.Size(225, 25);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        public System.Windows.Forms.Button btn_dec;
        public System.Windows.Forms.Button btn_hex;
        public System.Windows.Forms.Button btn_ascii;
        public System.Windows.Forms.Button btn_bin;
    }
}
