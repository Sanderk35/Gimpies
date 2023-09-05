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
            this.incorrect.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(67, 67);
            this.usernameInput.Margin = new System.Windows.Forms.Padding(2);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(156, 20);
            this.usernameInput.TabIndex = 0;
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Location = new System.Drawing.Point(64, 51);
            this.usernameText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(84, 13);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "Gebruikersnaam";
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(64, 134);
            this.passwordText.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(68, 13);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "Wachtwoord";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(67, 149);
            this.passwordInput.Margin = new System.Windows.Forms.Padding(2);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(156, 20);
            this.passwordInput.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(70, 206);
            this.login.Margin = new System.Windows.Forms.Padding(2);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(152, 29);
            this.login.TabIndex = 4;
            this.login.Text = "Log in";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // incorrectText
            // 
            this.incorrectText.AutoSize = true;
            this.incorrectText.Location = new System.Drawing.Point(5, 5);
            this.incorrectText.Name = "incorrectText";
            this.incorrectText.Size = new System.Drawing.Size(190, 26);
            this.incorrectText.TabIndex = 0;
            this.incorrectText.Text = "De gebruikersnaam of het wachtwoord\r\nis incorrect";
            this.incorrectText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // incorrect
            // 
            this.incorrect.BackColor = System.Drawing.Color.Red;
            this.incorrect.Controls.Add(this.incorrectText);
            this.incorrect.Location = new System.Drawing.Point(45, 11);
            this.incorrect.Name = "incorrect";
            this.incorrect.Size = new System.Drawing.Size(199, 36);
            this.incorrect.TabIndex = 5;
            this.incorrect.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 259);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.incorrect);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
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
    }
}

