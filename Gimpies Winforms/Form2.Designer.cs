namespace Gimpies_Winforms
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.voorraadBekijkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verkoperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voorraadBekijkenToolStripMenuItem,
            this.verkoperToolStripMenuItem,
            this.afsluitenToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(668, 65);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // voorraadBekijkenToolStripMenuItem
            // 
            this.voorraadBekijkenToolStripMenuItem.Name = "voorraadBekijkenToolStripMenuItem";
            this.voorraadBekijkenToolStripMenuItem.Size = new System.Drawing.Size(143, 61);
            this.voorraadBekijkenToolStripMenuItem.Text = "Voorraad bekijken";
            // 
            // verkoperToolStripMenuItem
            // 
            this.verkoperToolStripMenuItem.Name = "verkoperToolStripMenuItem";
            this.verkoperToolStripMenuItem.Size = new System.Drawing.Size(82, 61);
            this.verkoperToolStripMenuItem.Text = "Verkoper";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(81, 61);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 65);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.TopMost = true;
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem voorraadBekijkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verkoperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
    }
}