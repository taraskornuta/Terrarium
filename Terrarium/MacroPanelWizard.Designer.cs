namespace Terrarium
{
    partial class MacroPanelWizard
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
            this.macroField4 = new Terrarium.MacroField();
            this.macroField3 = new Terrarium.MacroField();
            this.macroField2 = new Terrarium.MacroField();
            this.macroField1 = new Terrarium.MacroField();
            this.SuspendLayout();
            // 
            // macroField4
            // 
            this.macroField4.BackColor = System.Drawing.Color.Red;
            this.macroField4.Location = new System.Drawing.Point(11, 120);
            this.macroField4.Name = "macroField4";
            this.macroField4.Size = new System.Drawing.Size(510, 30);
            this.macroField4.TabIndex = 3;
            // 
            // macroField3
            // 
            this.macroField3.BackColor = System.Drawing.Color.Red;
            this.macroField3.Location = new System.Drawing.Point(11, 84);
            this.macroField3.Name = "macroField3";
            this.macroField3.Size = new System.Drawing.Size(510, 30);
            this.macroField3.TabIndex = 2;
            // 
            // macroField2
            // 
            this.macroField2.BackColor = System.Drawing.Color.Red;
            this.macroField2.Location = new System.Drawing.Point(11, 48);
            this.macroField2.Name = "macroField2";
            this.macroField2.Size = new System.Drawing.Size(510, 30);
            this.macroField2.TabIndex = 1;
            // 
            // macroField1
            // 
            this.macroField1.BackColor = System.Drawing.Color.Red;
            this.macroField1.Location = new System.Drawing.Point(12, 12);
            this.macroField1.Name = "macroField1";
            this.macroField1.Size = new System.Drawing.Size(510, 30);
            this.macroField1.TabIndex = 0;
            // 
            // MacroPanelWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 611);
            this.Controls.Add(this.macroField4);
            this.Controls.Add(this.macroField3);
            this.Controls.Add(this.macroField2);
            this.Controls.Add(this.macroField1);
            this.Name = "MacroPanelWizard";
            this.Text = "MacroPanelWizard";
            this.ResumeLayout(false);

        }

        #endregion

        private MacroField macroField1;
        private MacroField macroField2;
        private MacroField macroField3;
        private MacroField macroField4;
    }
}