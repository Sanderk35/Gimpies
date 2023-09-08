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
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem(new string[] {
            "Addidas Daily 3.0",
            "€65",
            "32 paar",
            "48",
            "Zwart"}, -1);
            System.Windows.Forms.ListViewItem listViewItem11 = new System.Windows.Forms.ListViewItem(new string[] {
            "Nike Air Max",
            "€90",
            "15 paar",
            "48",
            "Wit"}, -1);
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem(new string[] {
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
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
            this.uitloggenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.UsernameInput.Location = new System.Drawing.Point(29, 332);
            this.UsernameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UsernameInput.Name = "UsernameInput";
            this.UsernameInput.Size = new System.Drawing.Size(191, 22);
            this.UsernameInput.TabIndex = 0;
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(29, 382);
            this.PasswordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(191, 22);
            this.PasswordInput.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(323, 290);
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
            this.LoginButton.Enabled = false;
            this.LoginButton.Location = new System.Drawing.Point(227, 334);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // schoenenToolStripMenuItem
            // 
            this.schoenenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voorraadBekijkenToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.uitloggenToolStripMenuItem});
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
            this.voorraadBekijkenToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.voorraadBekijkenToolStripMenuItem.Text = "Voorraad/Verkopen";
            this.voorraadBekijkenToolStripMenuItem.CheckedChanged += new System.EventHandler(this.voorraadBekijkenToolStripMenuItem_CheckedChanged);
            this.voorraadBekijkenToolStripMenuItem.Click += new System.EventHandler(this.voorraadBekijkenToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.Enabled = false;
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.manageToolStripMenuItem.Text = "Schoen Beheer";
            this.manageToolStripMenuItem.Visible = false;
            this.manageToolStripMenuItem.CheckedChanged += new System.EventHandler(this.manageToolStripMenuItem_CheckedChanged);
            this.manageToolStripMenuItem.Click += new System.EventHandler(this.manageToolStripMenuItem_Click);
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
            this.Login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(323, 406);
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
            listViewItem10,
            listViewItem11,
            listViewItem12});
            this.Storage.Location = new System.Drawing.Point(7, 30);
            this.Storage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Storage.MinimumSize = new System.Drawing.Size(255, 4);
            this.Storage.MultiSelect = false;
            this.Storage.Name = "Storage";
            this.Storage.Size = new System.Drawing.Size(567, 293);
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
            this.Incorrect.Location = new System.Drawing.Point(43, 443);
            this.Incorrect.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.sellButton.Location = new System.Drawing.Point(577, 79);
            this.sellButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.paarText.Location = new System.Drawing.Point(719, 49);
            this.paarText.Name = "paarText";
            this.paarText.Size = new System.Drawing.Size(35, 16);
            this.paarText.TabIndex = 13;
            this.paarText.Text = "paar";
            this.paarText.Visible = false;
            // 
            // sellCount
            // 
            this.sellCount.Location = new System.Drawing.Point(577, 49);
            this.sellCount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sellCount.Name = "sellCount";
            this.sellCount.Size = new System.Drawing.Size(133, 22);
            this.sellCount.TabIndex = 14;
            this.sellCount.Visible = false;
            // 
            // addPanel
            // 
            this.addPanel.Controls.Add(this.deleteButton);
            this.addPanel.Controls.Add(this.editButton);
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
            this.addPanel.Location = new System.Drawing.Point(7, 329);
            this.addPanel.Margin = new System.Windows.Forms.Padding(4);
            this.addPanel.Name = "addPanel";
            this.addPanel.Size = new System.Drawing.Size(567, 207);
            this.addPanel.TabIndex = 15;
            this.addPanel.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(437, 171);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 27);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Verwijderen";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(437, 138);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(108, 27);
            this.editButton.TabIndex = 14;
            this.editButton.Text = "Aanpassen";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // addButton
            // 
            this.addButton.Enabled = false;
            this.addButton.Location = new System.Drawing.Point(437, 106);
            this.addButton.Margin = new System.Windows.Forms.Padding(4);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(108, 27);
            this.addButton.TabIndex = 13;
            this.addButton.Text = "Toevoegen";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // colorText
            // 
            this.colorText.AutoSize = true;
            this.colorText.Location = new System.Drawing.Point(173, 105);
            this.colorText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.colorText.Name = "colorText";
            this.colorText.Size = new System.Drawing.Size(37, 16);
            this.colorText.TabIndex = 12;
            this.colorText.Text = "Kleur";
            // 
            // colorSet
            // 
            this.colorSet.Location = new System.Drawing.Point(173, 124);
            this.colorSet.Margin = new System.Windows.Forms.Padding(4);
            this.colorSet.Name = "colorSet";
            this.colorSet.Size = new System.Drawing.Size(219, 22);
            this.colorSet.TabIndex = 11;
            // 
            // sizeSet
            // 
            this.sizeSet.Location = new System.Drawing.Point(31, 126);
            this.sizeSet.Margin = new System.Windows.Forms.Padding(4);
            this.sizeSet.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.sizeSet.Name = "sizeSet";
            this.sizeSet.Size = new System.Drawing.Size(88, 22);
            this.sizeSet.TabIndex = 10;
            // 
            // sizeText
            // 
            this.sizeText.AutoSize = true;
            this.sizeText.Location = new System.Drawing.Point(29, 106);
            this.sizeText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeText.Name = "sizeText";
            this.sizeText.Size = new System.Drawing.Size(83, 16);
            this.sizeText.TabIndex = 9;
            this.sizeText.Text = "Schoenmaat";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(508, 55);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "paar";
            // 
            // storageSet
            // 
            this.storageSet.Location = new System.Drawing.Point(435, 52);
            this.storageSet.Margin = new System.Windows.Forms.Padding(4);
            this.storageSet.Name = "storageSet";
            this.storageSet.Size = new System.Drawing.Size(65, 22);
            this.storageSet.TabIndex = 7;
            // 
            // storageText
            // 
            this.storageText.AutoSize = true;
            this.storageText.Location = new System.Drawing.Point(433, 32);
            this.storageText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storageText.Name = "storageText";
            this.storageText.Size = new System.Drawing.Size(64, 16);
            this.storageText.TabIndex = 6;
            this.storageText.Text = "Voorraad";
            // 
            // euroSymboleText
            // 
            this.euroSymboleText.AutoSize = true;
            this.euroSymboleText.Location = new System.Drawing.Point(291, 55);
            this.euroSymboleText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.euroSymboleText.Name = "euroSymboleText";
            this.euroSymboleText.Size = new System.Drawing.Size(14, 16);
            this.euroSymboleText.TabIndex = 5;
            this.euroSymboleText.Text = "€";
            // 
            // priceSet
            // 
            this.priceSet.Location = new System.Drawing.Point(308, 52);
            this.priceSet.Margin = new System.Windows.Forms.Padding(4);
            this.priceSet.Name = "priceSet";
            this.priceSet.Size = new System.Drawing.Size(85, 22);
            this.priceSet.TabIndex = 4;
            // 
            // priceText
            // 
            this.priceText.AutoSize = true;
            this.priceText.Location = new System.Drawing.Point(307, 32);
            this.priceText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priceText.Name = "priceText";
            this.priceText.Size = new System.Drawing.Size(33, 16);
            this.priceText.TabIndex = 3;
            this.priceText.Text = "Prijs";
            // 
            // NaamSchoenText
            // 
            this.NaamSchoenText.AutoSize = true;
            this.NaamSchoenText.Location = new System.Drawing.Point(29, 32);
            this.NaamSchoenText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NaamSchoenText.Name = "NaamSchoenText";
            this.NaamSchoenText.Size = new System.Drawing.Size(44, 16);
            this.NaamSchoenText.TabIndex = 1;
            this.NaamSchoenText.Text = "Naam";
            // 
            // nameShoeSet
            // 
            this.nameShoeSet.Location = new System.Drawing.Point(29, 52);
            this.nameShoeSet.Margin = new System.Windows.Forms.Padding(4);
            this.nameShoeSet.Name = "nameShoeSet";
            this.nameShoeSet.Size = new System.Drawing.Size(219, 22);
            this.nameShoeSet.TabIndex = 0;
            // 
            // uitloggenToolStripMenuItem
            // 
            this.uitloggenToolStripMenuItem.Name = "uitloggenToolStripMenuItem";
            this.uitloggenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F1)));
            this.uitloggenToolStripMenuItem.Size = new System.Drawing.Size(245, 26);
            this.uitloggenToolStripMenuItem.Text = "Uitloggen";
            this.uitloggenToolStripMenuItem.Click += new System.EventHandler(this.uitloggenToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.LoginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(776, 583);
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(299, 47);
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
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.ToolStripMenuItem uitloggenToolStripMenuItem;
    }
}

