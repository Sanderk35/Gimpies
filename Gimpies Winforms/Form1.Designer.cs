namespace Gimpies_Winforms
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.UsernameInput = new System.Windows.Forms.TextBox();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.UsernameText = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.schoenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voorraadBekijkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verkopenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toevoegenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aanpassenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verwijderenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afsluitenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Login = new System.Windows.Forms.Panel();
            this.Incorrect = new System.Windows.Forms.Panel();
            this.IncorrectText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Login.SuspendLayout();
            this.Incorrect.SuspendLayout();
            this.SuspendLayout();
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(30, 332);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(190, 22);
            this.UsernameInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(30, 381);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(190, 22);
            this.PasswordInput.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(322, 291);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.Location = new System.Drawing.Point(27, 313);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(107, 16);
            this.UsernameText.TabIndex = 3;
            this.UsernameText.Text = "Gebruikersnaam";
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Location = new System.Drawing.Point(27, 364);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(82, 16);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.Text = "Wachtwoord";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(226, 333);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(73, 73);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schoenenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MinimumSize = new System.Drawing.Size(800, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // schoenenToolStripMenuItem
            // 
            this.schoenenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voorraadBekijkenToolStripMenuItem,
            this.verkopenToolStripMenuItem,
            this.toevoegenToolStripMenuItem,
            this.aanpassenToolStripMenuItem,
            this.verwijderenToolStripMenuItem,
            this.afsluitenToolStripMenuItem});
            this.schoenenToolStripMenuItem.Name = "schoenenToolStripMenuItem";
            this.schoenenToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.schoenenToolStripMenuItem.Text = "Menu";
            // 
            // voorraadBekijkenToolStripMenuItem
            // 
            this.voorraadBekijkenToolStripMenuItem.Enabled = false;
            this.voorraadBekijkenToolStripMenuItem.Name = "voorraadBekijkenToolStripMenuItem";
            this.voorraadBekijkenToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.voorraadBekijkenToolStripMenuItem.Text = "Voorraad bekijken";
            // 
            // verkopenToolStripMenuItem
            // 
            this.verkopenToolStripMenuItem.Enabled = false;
            this.verkopenToolStripMenuItem.Name = "verkopenToolStripMenuItem";
            this.verkopenToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.verkopenToolStripMenuItem.Text = "Verkopen";
            // 
            // toevoegenToolStripMenuItem
            // 
            this.toevoegenToolStripMenuItem.Enabled = false;
            this.toevoegenToolStripMenuItem.Name = "toevoegenToolStripMenuItem";
            this.toevoegenToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.toevoegenToolStripMenuItem.Text = "Toevoegen";
            // 
            // aanpassenToolStripMenuItem
            // 
            this.aanpassenToolStripMenuItem.Enabled = false;
            this.aanpassenToolStripMenuItem.Name = "aanpassenToolStripMenuItem";
            this.aanpassenToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.aanpassenToolStripMenuItem.Text = "Aanpassen";
            // 
            // verwijderenToolStripMenuItem
            // 
            this.verwijderenToolStripMenuItem.Enabled = false;
            this.verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
            this.verwijderenToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.verwijderenToolStripMenuItem.Text = "Verwijderen";
            // 
            // afsluitenToolStripMenuItem
            // 
            this.afsluitenToolStripMenuItem.Name = "afsluitenToolStripMenuItem";
            this.afsluitenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.afsluitenToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.afsluitenToolStripMenuItem.Text = "Afsluiten";
            this.afsluitenToolStripMenuItem.ToolTipText = "Alt + F4";
            this.afsluitenToolStripMenuItem.Click += new System.EventHandler(this.afsluitenToolStripMenuItem_Click);
            // 
            // Login
            // 
            this.Login.BackColor = System.Drawing.Color.Transparent;
            this.Login.Controls.Add(this.LoginButton);
            this.Login.Controls.Add(this.Logo);
            this.Login.Controls.Add(this.PasswordInput);
            this.Login.Controls.Add(this.PasswordText);
            this.Login.Controls.Add(this.UsernameText);
            this.Login.Controls.Add(this.UsernameInput);
            this.Login.Location = new System.Drawing.Point(12, 33);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(322, 406);
            this.Login.TabIndex = 8;
            // 
            // Incorrect
            // 
            this.Incorrect.AutoSize = true;
            this.Incorrect.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Incorrect.BackColor = System.Drawing.Color.Red;
            this.Incorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Incorrect.Controls.Add(this.IncorrectText);
            this.Incorrect.Location = new System.Drawing.Point(42, 443);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(182, 54);
            this.Incorrect.TabIndex = 9;
            this.Incorrect.Visible = false;
            // 
            // IncorrectText
            // 
            this.IncorrectText.AutoSize = true;
            this.IncorrectText.Location = new System.Drawing.Point(4, 4);
            this.IncorrectText.Name = "IncorrectText";
            this.IncorrectText.Size = new System.Drawing.Size(173, 48);
            this.IncorrectText.TabIndex = 0;
            this.IncorrectText.Text = "De gebruikersnaam of\r\nhet wachtwoord is onjuist\r\nJe hebt nog   pogingen over";
            this.IncorrectText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.ControlBox = false;
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inloggen";
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            this.Incorrect.ResumeLayout(false);
            this.Incorrect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UsernameInput;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label UsernameText;
        private System.Windows.Forms.Label PasswordText;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem schoenenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voorraadBekijkenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verkopenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toevoegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aanpassenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verwijderenToolStripMenuItem;
        private System.Windows.Forms.Panel Login;
        private System.Windows.Forms.ToolStripMenuItem afsluitenToolStripMenuItem;
        private System.Windows.Forms.Panel Incorrect;
        private System.Windows.Forms.Label IncorrectText;
    }
}

