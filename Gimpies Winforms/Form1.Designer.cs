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
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "Addidas Daily 3.0",
            "€64,99",
            "32 paar",
            "48",
            "Zwart"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nike Air Max",
            "€89,99",
            "15 paar",
            "48",
            "Wit"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Puma Shuffle",
            "€64,99",
            "23 paar",
            "48",
            "Zwart"}, -1);
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
            this.Login = new System.Windows.Forms.Panel();
            this.Storage = new System.Windows.Forms.ListView();
            this.name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.opslag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.color = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Incorrect = new System.Windows.Forms.Panel();
            this.IncorrectText = new System.Windows.Forms.Label();
            this.sellButton = new System.Windows.Forms.Button();
            this.paarText = new System.Windows.Forms.Label();
            this.count = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Login.SuspendLayout();
            this.Incorrect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.count)).BeginInit();
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
            this.verwijderenToolStripMenuItem});
            this.schoenenToolStripMenuItem.Name = "schoenenToolStripMenuItem";
            this.schoenenToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.schoenenToolStripMenuItem.Text = "Menu";
            this.schoenenToolStripMenuItem.ToolTipText = "Menu met pagina\'s";
            // 
            // voorraadBekijkenToolStripMenuItem
            // 
            this.voorraadBekijkenToolStripMenuItem.Enabled = false;
            this.voorraadBekijkenToolStripMenuItem.Name = "voorraadBekijkenToolStripMenuItem";
            this.voorraadBekijkenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.voorraadBekijkenToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.voorraadBekijkenToolStripMenuItem.Text = "Voorraad bekijken";
            this.voorraadBekijkenToolStripMenuItem.CheckedChanged += new System.EventHandler(this.voorraadBekijkenToolStripMenuItem_CheckedChanged);
            this.voorraadBekijkenToolStripMenuItem.Click += new System.EventHandler(this.voorraadBekijkenToolStripMenuItem_Click);
            // 
            // verkopenToolStripMenuItem
            // 
            this.verkopenToolStripMenuItem.Enabled = false;
            this.verkopenToolStripMenuItem.Name = "verkopenToolStripMenuItem";
            this.verkopenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.verkopenToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.verkopenToolStripMenuItem.Text = "Verkopen";
            this.verkopenToolStripMenuItem.Click += new System.EventHandler(this.verkopenToolStripMenuItem_Click);
            // 
            // toevoegenToolStripMenuItem
            // 
            this.toevoegenToolStripMenuItem.Enabled = false;
            this.toevoegenToolStripMenuItem.Name = "toevoegenToolStripMenuItem";
            this.toevoegenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.toevoegenToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.toevoegenToolStripMenuItem.Text = "Toevoegen";
            this.toevoegenToolStripMenuItem.Click += new System.EventHandler(this.toevoegenToolStripMenuItem_Click);
            // 
            // aanpassenToolStripMenuItem
            // 
            this.aanpassenToolStripMenuItem.Enabled = false;
            this.aanpassenToolStripMenuItem.Name = "aanpassenToolStripMenuItem";
            this.aanpassenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.aanpassenToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.aanpassenToolStripMenuItem.Text = "Aanpassen";
            this.aanpassenToolStripMenuItem.Click += new System.EventHandler(this.aanpassenToolStripMenuItem_Click);
            // 
            // verwijderenToolStripMenuItem
            // 
            this.verwijderenToolStripMenuItem.Enabled = false;
            this.verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
            this.verwijderenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.verwijderenToolStripMenuItem.Size = new System.Drawing.Size(236, 26);
            this.verwijderenToolStripMenuItem.Text = "Verwijderen";
            this.verwijderenToolStripMenuItem.Click += new System.EventHandler(this.verwijderenToolStripMenuItem_Click);
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
            // Storage
            // 
            this.Storage.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.name,
            this.price,
            this.opslag,
            this.size,
            this.color});
            this.Storage.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Storage.HideSelection = false;
            this.Storage.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.Storage.Location = new System.Drawing.Point(0, 30);
            this.Storage.MinimumSize = new System.Drawing.Size(254, 4);
            this.Storage.MultiSelect = false;
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(567, 541);
            this.Storage.TabIndex = 10;
            this.Storage.UseCompatibleStateImageBehavior = false;
            this.Storage.View = System.Windows.Forms.View.Details;
            this.Storage.Visible = false;
            // 
            // name
            // 
            this.name.Text = "Naam";
            this.name.Width = 120;
            // 
            // price
            // 
            this.price.Text = "Prijs";
            // 
            // opslag
            // 
            this.opslag.Text = "Voorraad";
            this.opslag.Width = 70;
            // 
            // size
            // 
            this.size.Text = "Maat";
            // 
            // color
            // 
            this.color.Text = "Kleur";
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
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(573, 79);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(191, 44);
            this.sellButton.TabIndex = 11;
            this.sellButton.Text = "Verkoop geselecteerde schoen";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Visible = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // paarText
            // 
            this.paarText.AutoSize = true;
            this.paarText.Location = new System.Drawing.Point(714, 49);
            this.paarText.Name = "paarText";
            this.paarText.Size = new System.Drawing.Size(35, 16);
            this.paarText.TabIndex = 13;
            this.paarText.Text = "paar";
            this.paarText.Visible = false;
            // 
            // count
            // 
            this.count.Location = new System.Drawing.Point(574, 49);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(134, 22);
            this.count.TabIndex = 14;
            this.count.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(776, 583);
            this.Controls.Add(this.count);
            this.Controls.Add(this.paarText);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.Storage);
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 0);
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
            ((System.ComponentModel.ISupportInitialize)(this.count)).EndInit();
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
        private System.Windows.Forms.Panel Incorrect;
        private System.Windows.Forms.Label IncorrectText;
        private System.Windows.Forms.ListView Storage;
        private System.Windows.Forms.ColumnHeader name;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader opslag;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader color;
        private System.Windows.Forms.Button sellButton;
        private System.Windows.Forms.Label paarText;
        private System.Windows.Forms.NumericUpDown count;
    }
}

