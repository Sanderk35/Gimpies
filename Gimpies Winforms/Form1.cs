﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimpies_Winforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string verkoper = "Verkoper";
            string passwordVerkoper = "Gimpies_Verkoper";
            if (usernameText.Text == verkoper && passwordInput.Text == passwordVerkoper)
            {
                Environment.Exit(0);
            }
        }
    }
}
