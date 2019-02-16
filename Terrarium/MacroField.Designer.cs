namespace Terrarium
{
    partial class MacroField
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
            this.tb_MacroData = new System.Windows.Forms.TextBox();
            this.numBox = new System.Windows.Forms.NumericUpDown();
            this.cb_Repeat = new System.Windows.Forms.CheckBox();
            this.cb_HEX = new System.Windows.Forms.CheckBox();
            this.btntb_Send = new textboxInsideButton.ButtonTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_MacroData
            // 
            this.tb_MacroData.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tb_MacroData.Location = new System.Drawing.Point(3, 3);
            this.tb_MacroData.Name = "tb_MacroData";
            this.tb_MacroData.Size = new System.Drawing.Size(284, 24);
            this.tb_MacroData.TabIndex = 2;
            // 
            // numBox
            // 
            this.numBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numBox.Location = new System.Drawing.Point(318, 3);
            this.numBox.Maximum = new decimal(new int[] {
            600000,
            0,
            0,
            0});
            this.numBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBox.Name = "numBox";
            this.numBox.Size = new System.Drawing.Size(69, 23);
            this.numBox.TabIndex = 5;
            this.numBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cb_Repeat
            // 
            this.cb_Repeat.AutoSize = true;
            this.cb_Repeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cb_Repeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cb_Repeat.Location = new System.Drawing.Point(393, 8);
            this.cb_Repeat.Name = "cb_Repeat";
            this.cb_Repeat.Size = new System.Drawing.Size(15, 14);
            this.cb_Repeat.TabIndex = 6;
            this.cb_Repeat.UseVisualStyleBackColor = false;
            // 
            // cb_HEX
            // 
            this.cb_HEX.AutoSize = true;
            this.cb_HEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.cb_HEX.Location = new System.Drawing.Point(292, 8);
            this.cb_HEX.Margin = new System.Windows.Forms.Padding(0);
            this.cb_HEX.Name = "cb_HEX";
            this.cb_HEX.Size = new System.Drawing.Size(15, 14);
            this.cb_HEX.TabIndex = 7;
            this.cb_HEX.UseVisualStyleBackColor = false;
            // 
            // btntb_Send
            // 
            this.btntb_Send.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(85)))));
            this.btntb_Send.Location = new System.Drawing.Point(421, 3);
            this.btntb_Send.MaximumSize = new System.Drawing.Size(85, 24);
            this.btntb_Send.MinimumSize = new System.Drawing.Size(85, 24);
            this.btntb_Send.Name = "btntb_Send";
            this.btntb_Send.Size = new System.Drawing.Size(85, 24);
            this.btntb_Send.TabIndex = 8;
            // 
            // MacroField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.btntb_Send);
            this.Controls.Add(this.cb_HEX);
            this.Controls.Add(this.cb_Repeat);
            this.Controls.Add(this.numBox);
            this.Controls.Add(this.tb_MacroData);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(510, 30);
            this.MinimumSize = new System.Drawing.Size(510, 30);
            this.Name = "MacroField";
            this.Size = new System.Drawing.Size(510, 30);
            ((System.ComponentModel.ISupportInitialize)(this.numBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox tb_MacroData;
        private System.Windows.Forms.NumericUpDown numBox;
        private System.Windows.Forms.CheckBox cb_Repeat;
        private System.Windows.Forms.CheckBox cb_HEX;
        private textboxInsideButton.ButtonTextbox btntb_Send;
    }
}
