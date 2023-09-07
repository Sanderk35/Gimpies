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
            "€65",
            "32 paar",
            "48",
            "Zwart"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nike Air Max",
            "€90",
            "15 paar",
            "48",
            "Wit"}, -1);
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "Puma Shuffle",
            "€65",
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
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.sellCount = new System.Windows.Forms.NumericUpDown();
            this.addPanel = new System.Windows.Forms.Panel();
            this.colorText = new System.Windows.Forms.Label();
            this.colorSet = new System.Windows.Forms.TextBox();
            this.sizeSet = new System.Windows.Forms.NumericUpDown();
            this.sizeText = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.storageSet = new System.Windows.Forms.NumericUpDown();
            this.storageText = new System.Windows.Forms.Label();
            this.euroSymboleText = new System.Windows.Forms.Label();
            this.priceSet = new System.Windows.Forms.NumericUpDown();
            this.priceText = new System.Windows.Forms.Label();
            this.NaamSchoenText = new System.Windows.Forms.Label();
            this.nameShoeSet = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.Login.SuspendLayout();
            this.Incorrect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sellCount)).BeginInit();
            this.addPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSet)).BeginInit();
            this.SuspendLayout();
            // 
            // UsernameInput
            // 
            this.UsernameInput.Location = new System.Drawing.Point(22, 270);
            this.UsernameInput.Margin = new System.Windows.Forms.Padding(2);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(144, 20);
            this.UsernameInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(22, 310);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.Size = new System.Drawing.Size(144, 20);
            this.PasswordInput.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(242, 236);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 2;
            this.Logo.TabStop = false;
            // 
            // UsernameText
            // 
            this.UsernameText.AutoSize = true;
            this.UsernameText.Location = new System.Drawing.Point(20, 254);
            this.UsernameText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UsernameText.Name = "UsernameText";
            this.UsernameText.Size = new System.Drawing.Size(84, 13);
            this.UsernameText.TabIndex = 3;
            this.UsernameText.Text = "Gebruikersnaam";
            // 
            // PasswordText
            // 
            this.PasswordText.AutoSize = true;
            this.PasswordText.Location = new System.Drawing.Point(20, 296);
            this.PasswordText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(68, 13);
            this.PasswordText.TabIndex = 4;
            this.PasswordText.Text = "Wachtwoord";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(170, 271);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(55, 59);
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
            this.menuStrip1.MinimumSize = new System.Drawing.Size(600, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // schoenenToolStripMenuItem
            // 
            this.schoenenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voorraadBekijkenToolStripMenuItem,
            this.manageToolStripMenuItem});
            this.schoenenToolStripMenuItem.Name = "schoenenToolStripMenuItem";
            this.schoenenToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.schoenenToolStripMenuItem.Text = "Menu";
            this.schoenenToolStripMenuItem.ToolTipText = "Menu met pagina\'s";
            // 
            // voorraadBekijkenToolStripMenuItem
            // 
            this.voorraadBekijkenToolStripMenuItem.Enabled = false;
            this.voorraadBekijkenToolStripMenuItem.Name = "voorraadBekijkenToolStripMenuItem";
            this.voorraadBekijkenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.voorraadBekijkenToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.voorraadBekijkenToolStripMenuItem.Text = "Voorraad/Verkopen";
            this.voorraadBekijkenToolStripMenuItem.CheckedChanged += new System.EventHandler(this.voorraadBekijkenToolStripMenuItem_CheckedChanged);
            this.voorraadBekijkenToolStripMenuItem.Click += new System.EventHandler(this.voorraadBekijkenToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toevoegenToolStripMenuItem,
            this.aanpassenToolStripMenuItem,
            this.verwijderenToolStripMenuItem});
            this.manageToolStripMenuItem.Enabled = false;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.manageToolStripMenuItem.Text = "Schoen Beheer";
            this.manageToolStripMenuItem.Visible = false;
            // 
            // toevoegenToolStripMenuItem
            // 
            this.toevoegenToolStripMenuItem.Enabled = false;
            this.toevoegenToolStripMenuItem.Name = "toevoegenToolStripMenuItem";
            this.toevoegenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.toevoegenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.toevoegenToolStripMenuItem.Text = "Toevoegen";
            this.toevoegenToolStripMenuItem.CheckedChanged += new System.EventHandler(this.toevoegenToolStripMenuItem1_CheckedChanged);
            this.toevoegenToolStripMenuItem.Click += new System.EventHandler(this.toevoegenToolStripMenuItem_Click);
            // 
            // aanpassenToolStripMenuItem
            // 
            this.aanpassenToolStripMenuItem.Enabled = false;
            this.aanpassenToolStripMenuItem.Name = "aanpassenToolStripMenuItem";
            this.aanpassenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.aanpassenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aanpassenToolStripMenuItem.Text = "Aanpassen";
            this.aanpassenToolStripMenuItem.Click += new System.EventHandler(this.aanpassenToolStripMenuItem_Click);
            // 
            // verwijderenToolStripMenuItem
            // 
            this.verwijderenToolStripMenuItem.Enabled = false;
            this.verwijderenToolStripMenuItem.Name = "verwijderenToolStripMenuItem";
            this.verwijderenToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.verwijderenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.Login.Location = new System.Drawing.Point(9, 27);
            this.Login.Margin = new System.Windows.Forms.Padding(2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(242, 330);
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
            this.Storage.Location = new System.Drawing.Point(5, 24);
            this.Storage.Margin = new System.Windows.Forms.Padding(2);
            this.Storage.MinimumSize = new System.Drawing.Size(192, 4);
            this.Storage.MultiSelect = false;
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(426, 239);
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
            this.Incorrect.Location = new System.Drawing.Point(32, 360);
            this.Incorrect.Margin = new System.Windows.Forms.Padding(2);
            this.Incorrect.Name = "Incorrect";
            this.Incorrect.Size = new System.Drawing.Size(147, 44);
            this.Incorrect.TabIndex = 9;
            this.Incorrect.Visible = false;
            // 
            // IncorrectText
            // 
            this.IncorrectText.AutoSize = true;
            this.IncorrectText.Location = new System.Drawing.Point(3, 3);
            this.IncorrectText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IncorrectText.Name = "IncorrectText";
            this.IncorrectText.Size = new System.Drawing.Size(140, 39);
            this.IncorrectText.TabIndex = 0;
            this.IncorrectText.Text = "De gebruikersnaam of\r\nhet wachtwoord is onjuist\r\nJe hebt nog   pogingen over";
            this.IncorrectText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sellButton
            // 
            this.sellButton.Location = new System.Drawing.Point(433, 64);
            this.sellButton.Margin = new System.Windows.Forms.Padding(2);
            this.sellButton.Name = "sellButton";
            this.sellButton.Size = new System.Drawing.Size(143, 36);
            this.sellButton.TabIndex = 11;
            this.sellButton.Text = "Verkoop geselecteerde schoen";
            this.sellButton.UseVisualStyleBackColor = true;
            this.sellButton.Visible = false;
            this.sellButton.Click += new System.EventHandler(this.sellButton_Click);
            // 
            // paarText
            // 
            this.paarText.AutoSize = true;
            this.paarText.Location = new System.Drawing.Point(539, 40);
            this.paarText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.paarText.Name = "paarText";
            this.paarText.Size = new System.Drawing.Size(28, 13);
            this.paarText.TabIndex = 13;
            this.paarText.Text = "paar";
            this.paarText.Visible = false;
            // 
            // sellCount
            // 
            this.sellCount.Location = new System.Drawing.Point(433, 40);
            this.sellCount.Margin = new System.Windows.Forms.Padding(2);
            this.sellCount.Name = "sellCount";
            this.sellCount.Size = new System.Drawing.Size(100, 20);
            this.sellCount.TabIndex = 14;
            this.sellCount.Visible = false;
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.addButton);
            this.addPanel.Controls.Add(this.colorText);
            this.addPanel.Controls.Add(this.colorSet);
            this.addPanel.Controls.Add(this.sizeSet);
            this.addPanel.Controls.Add(this.sizeText);
            this.addPanel.Controls.Add(this.label4);
            this.addPanel.Controls.Add(this.storageSet);
            this.addPanel.Controls.Add(this.storageText);
            this.addPanel.Controls.Add(this.euroSymboleText);
            this.addPanel.Controls.Add(this.priceSet);
            this.addPanel.Controls.Add(this.priceText);
            this.addPanel.Controls.Add(this.NaamSchoenText);
            this.addPanel.Controls.Add(this.nameShoeSet);
            this.addPanel.Location = new System.Drawing.Point(5, 268);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(426, 168);
            this.addPanel.TabIndex = 15;
            this.addPanel.Visible = false;
            // 
            // colorText
            // 
            this.colorText.AutoSize = true;
            this.colorText.Location = new System.Drawing.Point(130, 85);
            this.colorText.Name = "colorText";
            this.colorText.Size = new System.Drawing.Size(31, 13);
            this.colorText.TabIndex = 12;
            this.colorText.Text = "Kleur";
            // 
            // colorSet
            // 
            this.colorSet.Location = new System.Drawing.Point(130, 101);
            this.colorSet.Name = "colorSet";
            this.colorSet.Size = new System.Drawing.Size(165, 20);
            this.colorSet.TabIndex = 11;
            // 
            // sizeSet
            // 
            this.sizeSet.Location = new System.Drawing.Point(23, 102);
            this.sizeSet.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sizeSet.Name = "sizeSet";
            this.sizeSet.Size = new System.Drawing.Size(66, 20);
            this.sizeSet.TabIndex = 10;
            // 
            // sizeText
            // 
            this.sizeText.AutoSize = true;
            this.sizeText.Location = new System.Drawing.Point(22, 86);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(67, 13);
            this.sizeText.TabIndex = 9;
            this.sizeText.Text = "Schoenmaat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "paar";
            // 
            // storageSet
            // 
            this.storageSet.Location = new System.Drawing.Point(326, 42);
            this.storageSet.Name = "storageSet";
            this.storageSet.Size = new System.Drawing.Size(49, 20);
            this.storageSet.TabIndex = 7;
            // 
            // storageText
            // 
            this.storageText.AutoSize = true;
            this.storageText.Location = new System.Drawing.Point(325, 26);
            this.storageText.Name = "storageText";
            this.storageText.Size = new System.Drawing.Size(50, 13);
            this.storageText.TabIndex = 6;
            this.storageText.Text = "Voorraad";
            // 
            // euroSymboleText
            // 
            this.euroSymboleText.AutoSize = true;
            this.euroSymboleText.Location = new System.Drawing.Point(218, 45);
            this.euroSymboleText.Name = "euroSymboleText";
            this.euroSymboleText.Size = new System.Drawing.Size(13, 13);
            this.euroSymboleText.TabIndex = 5;
            this.euroSymboleText.Text = "€";
            // 
            // priceSet
            // 
            this.priceSet.Location = new System.Drawing.Point(231, 42);
            this.priceSet.Name = "priceSet";
            this.priceSet.Size = new System.Drawing.Size(64, 20);
            this.priceSet.TabIndex = 4;
            // 
            // priceText
            // 
            this.priceText.AutoSize = true;
            this.priceText.Location = new System.Drawing.Point(230, 26);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(26, 13);
            this.priceText.TabIndex = 3;
            this.priceText.Text = "Prijs";
            // 
            // NaamSchoenText
            // 
            this.NaamSchoenText.AutoSize = true;
            this.NaamSchoenText.Location = new System.Drawing.Point(22, 26);
            this.NaamSchoenText.Name = "NaamSchoenText";
            this.NaamSchoenText.Size = new System.Drawing.Size(35, 13);
            this.NaamSchoenText.TabIndex = 1;
            this.NaamSchoenText.Text = "Naam";
            // 
            // nameShoeSet
            // 
            this.nameShoeSet.Location = new System.Drawing.Point(22, 42);
            this.nameShoeSet.Name = "nameShoeSet";
            this.nameShoeSet.Size = new System.Drawing.Size(165, 20);
            this.nameShoeSet.TabIndex = 0;
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(328, 86);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(81, 49);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Toevoegen";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(582, 474);
            this.Controls.Add(this.addPanel);
            this.Controls.Add(this.sellCount);
            this.Controls.Add(this.paarText);
            this.Controls.Add(this.sellButton);
            this.Controls.Add(this.Storage);
            this.Controls.Add(this.Incorrect);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(229, 39);
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
            ((System.ComponentModel.ISupportInitialize)(this.sellCount)).EndInit();
            this.addPanel.ResumeLayout(false);
            this.addPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sizeSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.priceSet)).EndInit();
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
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
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
        private System.Windows.Forms.NumericUpDown sellCount;
        private System.Windows.Forms.Panel addPanel;
        private System.Windows.Forms.ToolStripMenuItem toevoegenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aanpassenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verwijderenToolStripMenuItem;
        private System.Windows.Forms.Label NaamSchoenText;
        private System.Windows.Forms.TextBox nameShoeSet;
        private System.Windows.Forms.Label euroSymboleText;
        private System.Windows.Forms.NumericUpDown priceSet;
        private System.Windows.Forms.Label priceText;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown storageSet;
        private System.Windows.Forms.Label storageText;
        private System.Windows.Forms.Label colorText;
        private System.Windows.Forms.TextBox colorSet;
        private System.Windows.Forms.NumericUpDown sizeSet;
        private System.Windows.Forms.Label sizeText;
        private System.Windows.Forms.Button addButton;
    }
}

