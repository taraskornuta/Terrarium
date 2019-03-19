namespace Terrarium
{
    partial class DropDownPanel
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
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_Open = new System.Windows.Forms.Button();
            this.lbl_Text = new System.Windows.Forms.Label();
            this.iconBox = new System.Windows.Forms.PictureBox();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.panel4.Controls.Add(this.btn_Open);
            this.panel4.Controls.Add(this.lbl_Text);
            this.panel4.Controls.Add(this.iconBox);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(225, 20);
            this.panel4.TabIndex = 3;
            // 
            // btn_Open
            // 
            this.btn_Open.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Open.FlatAppearance.BorderSize = 0;
            this.btn_Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Open.Image = global::Terrarium.Properties.Resources.icons8_Sort_Left_16px;
            this.btn_Open.Location = new System.Drawing.Point(198, 0);
            this.btn_Open.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Open.Name = "btn_Open";
            this.btn_Open.Size = new System.Drawing.Size(27, 20);
            this.btn_Open.TabIndex = 3;
            this.btn_Open.UseVisualStyleBackColor = true;
            this.btn_Open.Click += new System.EventHandler(this.btn_Open_Click);
            // 
            // lbl_Text
            // 
            this.lbl_Text.AutoSize = true;
            this.lbl_Text.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_Text.Location = new System.Drawing.Point(22, 4);
            this.lbl_Text.Name = "lbl_Text";
            this.lbl_Text.Size = new System.Drawing.Size(28, 13);
            this.lbl_Text.TabIndex = 2;
            this.lbl_Text.Text = "Text";
            // 
            // iconBox
            // 
            this.iconBox.Location = new System.Drawing.Point(0, 0);
            this.iconBox.Margin = new System.Windows.Forms.Padding(0);
            this.iconBox.Name = "iconBox";
            this.iconBox.Size = new System.Drawing.Size(20, 20);
            this.iconBox.TabIndex = 1;
            this.iconBox.TabStop = false;
            // 
            // DropDownPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "DropDownPanel";
            this.Size = new System.Drawing.Size(225, 20);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btn_Open;
        private System.Windows.Forms.Label lbl_Text;
        private System.Windows.Forms.PictureBox iconBox;
    }
}
