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
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.incorrectText = new System.Windows.Forms.Label();
            this.incorrect = new System.Windows.Forms.Panel();
            this.welkom = new System.Windows.Forms.Label();
            this.incorrect.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(89, 82);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(207, 22);
            this.usernameInput.TabIndex = 0;
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Location = new System.Drawing.Point(85, 63);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(107, 16);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "Gebruikersnaam";
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(85, 165);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(82, 16);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "Wachtwoord";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(89, 183);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(207, 22);
            this.passwordInput.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(93, 254);
            this.login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(203, 36);
            this.login.TabIndex = 4;
            this.login.Text = "Log in";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // incorrectText
            // 
            this.incorrectText.AutoSize = true;
            this.incorrectText.Location = new System.Drawing.Point(7, 6);
            this.incorrectText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.incorrectText.Name = "incorrectText";
            this.incorrectText.Size = new System.Drawing.Size(235, 32);
            this.incorrectText.TabIndex = 0;
            this.incorrectText.Text = "De gebruikersnaam of het wachtwoord\r\nis incorrect";
            this.incorrectText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incorrect
            // 
            this.incorrect.BackColor = System.Drawing.Color.Red;
            this.incorrect.Controls.Add(this.incorrectText);
            this.incorrect.Location = new System.Drawing.Point(60, 14);
            this.incorrect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.incorrect.Name = "incorrect";
            this.incorrect.Size = new System.Drawing.Size(265, 44);
            this.incorrect.TabIndex = 5;
            this.incorrect.Visible = false;
            // 
            // welkom
            // 
            this.welkom.AutoSize = true;
            this.welkom.Location = new System.Drawing.Point(133, 128);
            this.welkom.Name = "welkom";
            this.welkom.Size = new System.Drawing.Size(116, 16);
            this.welkom.TabIndex = 6;
            this.welkom.Text = "Welkom Verkoper";
            this.welkom.Visible = false;
            // 
            // Form1
            // 
            this.AcceptButton = this.login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 319);
            this.Controls.Add(this.welkom);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.incorrect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.incorrect.ResumeLayout(false);
            this.incorrect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Label incorrectText;
        private System.Windows.Forms.Panel incorrect;
        private System.Windows.Forms.Label welkom;
    }
}

