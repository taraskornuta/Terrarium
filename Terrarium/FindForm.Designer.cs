namespace Terrarium
{
    partial class FindForm
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
            this.txb_Find = new System.Windows.Forms.TextBox();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_GetFromClipbrd = new System.Windows.Forms.Button();
            this.btn_Find = new System.Windows.Forms.Button();
            this.lbl_FindCount = new System.Windows.Forms.Label();
            this.dataFormatSwitch = new Terrarium.DataFormaterSwitch();
            this.SuspendLayout();
            // 
            // txb_Find
            // 
            this.txb_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.txb_Find.Location = new System.Drawing.Point(1, 1);
            this.txb_Find.Margin = new System.Windows.Forms.Padding(3, 0, 1, 1);
            this.txb_Find.Name = "txb_Find";
            this.txb_Find.Size = new System.Drawing.Size(225, 24);
            this.txb_Find.TabIndex = 0;
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Delete.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Delete.Image = global::Terrarium.Properties.Resources.icons8_Trash_22px;
            this.btn_Delete.Location = new System.Drawing.Point(228, 1);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(44, 25);
            this.btn_Delete.TabIndex = 3;
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_GetFromClipbrd
            // 
            this.btn_GetFromClipbrd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_GetFromClipbrd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_GetFromClipbrd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GetFromClipbrd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_GetFromClipbrd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_GetFromClipbrd.Image = global::Terrarium.Properties.Resources.icons8_Clipboard_22px;
            this.btn_GetFromClipbrd.Location = new System.Drawing.Point(274, 1);
            this.btn_GetFromClipbrd.Margin = new System.Windows.Forms.Padding(0);
            this.btn_GetFromClipbrd.Name = "btn_GetFromClipbrd";
            this.btn_GetFromClipbrd.Size = new System.Drawing.Size(41, 25);
            this.btn_GetFromClipbrd.TabIndex = 4;
            this.btn_GetFromClipbrd.UseVisualStyleBackColor = false;
            this.btn_GetFromClipbrd.Click += new System.EventHandler(this.btn_GetFromClipbrd_Click);
            // 
            // btn_Find
            // 
            this.btn_Find.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_Find.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btn_Find.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Find.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Find.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Find.Location = new System.Drawing.Point(228, 28);
            this.btn_Find.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Find.Name = "btn_Find";
            this.btn_Find.Size = new System.Drawing.Size(87, 50);
            this.btn_Find.TabIndex = 5;
            this.btn_Find.Text = "Find";
            this.btn_Find.UseVisualStyleBackColor = false;
            this.btn_Find.Click += new System.EventHandler(this.btn_Find_Click);
            // 
            // lbl_FindCount
            // 
            this.lbl_FindCount.AutoSize = true;
            this.lbl_FindCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_FindCount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_FindCount.Location = new System.Drawing.Point(5, 59);
            this.lbl_FindCount.Name = "lbl_FindCount";
            this.lbl_FindCount.Size = new System.Drawing.Size(0, 13);
            this.lbl_FindCount.TabIndex = 6;
            // 
            // dataFormatSwitch
            // 
            this.dataFormatSwitch.AllowCombyneKeys = false;
            this.dataFormatSwitch.DataFormat = Terrarium.eDataFormat.NONE;
            this.dataFormatSwitch.DoubleClickInterval = 50;
            this.dataFormatSwitch.Location = new System.Drawing.Point(1, 28);
            this.dataFormatSwitch.Margin = new System.Windows.Forms.Padding(0);
            this.dataFormatSwitch.Name = "dataFormatSwitch";
            this.dataFormatSwitch.Size = new System.Drawing.Size(225, 25);
            this.dataFormatSwitch.TabIndex = 2;
            // 
            // FindForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(318, 80);
            this.Controls.Add(this.lbl_FindCount);
            this.Controls.Add(this.btn_Find);
            this.Controls.Add(this.btn_GetFromClipbrd);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.dataFormatSwitch);
            this.Controls.Add(this.txb_Find);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find";
            this.TopMost = true;
            this.Activated += new System.EventHandler(this.FindForm_Activated);
            this.Deactivate += new System.EventHandler(this.FindForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FindForm_FormClosed);
            this.Load += new System.EventHandler(this.FindForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Find;
        private DataFormaterSwitch dataFormatSwitch;
        public System.Windows.Forms.Button btn_Delete;
        public System.Windows.Forms.Button btn_GetFromClipbrd;
        public System.Windows.Forms.Button btn_Find;
        private System.Windows.Forms.Label lbl_FindCount;
    }
}