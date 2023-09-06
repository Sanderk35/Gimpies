using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        int tries = 3;

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = UsernameInput.Text;
            string password = PasswordInput.Text;
            string verkoper = "v";
            string manager = "m";
            string passwordVerkoper = "";
            string passwordManager = "";

            if (username == verkoper && password == passwordVerkoper)
            {
                Login.Visible = false;
                Refresh();
                voorraadBekijkenToolStripMenuItem.Enabled = true;
                verkopenToolStripMenuItem.Enabled = true;
            }
            else if (username == manager && password == passwordManager)
            {
                Login.Visible = false;
                Refresh();
                voorraadBekijkenToolStripMenuItem.Enabled = true;
                verkopenToolStripMenuItem.Enabled = true;
                toevoegenToolStripMenuItem.Enabled = true;
                aanpassenToolStripMenuItem.Enabled = true;
                verwijderenToolStripMenuItem.Enabled = true;
            }
            else
            {
                tries--;
                if (tries == 0)
                {
                    IncorrectText.Text = "Je hebt geen pogingen meer\nDoei doei";
                    Incorrect.Visible = true;
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                }
                else
                {
                    IncorrectText.Text = "De gebruikersnaam of\nhet wachtwoord is onjuist\nJe hebt nog " + tries + " poging(en) over";
                    Incorrect.Visible = true; 
                    Refresh();
                    Thread.Sleep(3000);
                    Incorrect.Visible = false;
                    Refresh();
                }
            }
        }

        private void afsluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
