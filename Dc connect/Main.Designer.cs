namespace Dc_connect
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.عملیاتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملیاتپینگToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.عملیاتتغییرآیپیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عملیاتToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // عملیاتToolStripMenuItem
            // 
            this.عملیاتToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.عملیاتپینگToolStripMenuItem,
            this.عملیاتتغییرآیپیToolStripMenuItem});
            this.عملیاتToolStripMenuItem.Name = "عملیاتToolStripMenuItem";
            this.عملیاتToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.عملیاتToolStripMenuItem.Text = "عملیات";
            // 
            // عملیاتپینگToolStripMenuItem
            // 
            this.عملیاتپینگToolStripMenuItem.Name = "عملیاتپینگToolStripMenuItem";
            this.عملیاتپینگToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.عملیاتپینگToolStripMenuItem.Text = "عملیات پینگ";
            this.عملیاتپینگToolStripMenuItem.Click += new System.EventHandler(this.عملیاتپینگToolStripMenuItem_Click);
            // 
            // عملیاتتغییرآیپیToolStripMenuItem
            // 
            this.عملیاتتغییرآیپیToolStripMenuItem.Name = "عملیاتتغییرآیپیToolStripMenuItem";
            this.عملیاتتغییرآیپیToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.عملیاتتغییرآیپیToolStripMenuItem.Text = "عملیات تغییر آی پی";
            this.عملیاتتغییرآیپیToolStripMenuItem.Click += new System.EventHandler(this.عملیاتتغییرآیپیToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(284, 434);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "صفحه اصلی";
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem عملیاتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عملیاتپینگToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem عملیاتتغییرآیپیToolStripMenuItem;
    }
}