namespace Dc_connect
{
    partial class ip
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
            this.txtip = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(98, 63);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(130, 20);
            this.txtip.TabIndex = 0;
            // 
            // ip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 441);
            this.Controls.Add(this.txtip);
            this.Name = "ip";
            this.Text = "ip";
            this.Load += new System.EventHandler(this.ip_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtip;
    }
}