﻿namespace Gimpies_Winforms
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.usernameText = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 82);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 22);
            this.textBox1.TabIndex = 0;
            // 
            // usernameText
            // 
            this.usernameText.AutoSize = true;
            this.usernameText.Location = new System.Drawing.Point(86, 63);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(107, 16);
            this.usernameText.TabIndex = 1;
            this.usernameText.Text = "Gebruikersnaam";
            // 
            // passwordText
            // 
            this.passwordText.AutoSize = true;
            this.passwordText.Location = new System.Drawing.Point(91, 163);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(82, 16);
            this.passwordText.TabIndex = 2;
            this.passwordText.Text = "Wachtwoord";
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(89, 183);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.Size = new System.Drawing.Size(207, 22);
            this.passwordInput.TabIndex = 3;
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(94, 253);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(202, 23);
            this.login.TabIndex = 4;
            this.login.Text = "Log in";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 319);
            this.Controls.Add(this.login);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.passwordText);
            this.Controls.Add(this.usernameText);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label usernameText;
        private System.Windows.Forms.Label passwordText;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Button login;
    }
}
