using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gimpies_Winforms
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer selectionTimer;
        public Form1()
        {
            InitializeComponent();
            selectionTimer = new System.Windows.Forms.Timer();
            selectionTimer.Interval = 1;
            selectionTimer.Tick += SelectionTimer_Tick;
            selectionTimer.Start();
        }

        public void SelectionTimer_Tick(object sender, EventArgs e)
        {
            if (Storage.SelectedItems.Count > 0 && count.Text.Length > 0)
            {
                sellButton.Enabled = true;
            }
            else
            {
                sellButton.Enabled = false;
            }
        }

        public void EnableAll()
        {
            voorraadBekijkenToolStripMenuItem.Checked = false;
            verkopenToolStripMenuItem.Checked = false;
            toevoegenToolStripMenuItem.Checked = false;
            aanpassenToolStripMenuItem.Checked = false;
            verwijderenToolStripMenuItem.Checked = false;

            voorraadBekijkenToolStripMenuItem.Enabled = true;
            verkopenToolStripMenuItem.Enabled = true;
            if (UsernameInput.Text == "m")
            {
                toevoegenToolStripMenuItem.Enabled = true;
                aanpassenToolStripMenuItem.Enabled = true;
                verwijderenToolStripMenuItem.Enabled = true;
            }
        }

        int tries = 3;
        string[] shoe = new string[20];
        int[] countShoe = new int[20];

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
                this.Text = "Menu";
                countShoe[0] = 32;
                countShoe[1] = 15;
                countShoe[2] = 23;
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
                this.Text = "Menu";
                countShoe[0] = 32;
                countShoe[1] = 15;
                countShoe[2] = 23;
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

        private void voorraadBekijkenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAll();
            voorraadBekijkenToolStripMenuItem.Checked = true;
            voorraadBekijkenToolStripMenuItem.Enabled = false;
        }

        private void verkopenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAll();
            verkopenToolStripMenuItem.Checked = true;
            verkopenToolStripMenuItem.Enabled = false;
        }

        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAll();
            toevoegenToolStripMenuItem.Checked = true;
            toevoegenToolStripMenuItem.Enabled = false;
        }

        private void aanpassenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAll();
            aanpassenToolStripMenuItem.Checked = true;
            aanpassenToolStripMenuItem.Enabled = false;
        }

        private void verwijderenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAll();
            verwijderenToolStripMenuItem.Checked = true;
            verwijderenToolStripMenuItem.Enabled = false;
        }

        private void voorraadBekijkenToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            if (voorraadBekijkenToolStripMenuItem.Checked == true)
            {
                Storage.Visible = true;
                Storage.Items[0].SubItems[2].Text = countShoe[0] + " paar";
                Storage.Items[1].SubItems[2].Text = countShoe[1] + " paar";
                Storage.Items[2].SubItems[2].Text = countShoe[2] + " paar";

                count.Visible = true;
                sellButton.Visible = true;
                paarText.Visible = true;
            }
            else
            {
                Storage.Visible = false;
                count.Visible = false;
                sellButton.Visible = false;
                paarText.Visible = false;
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {

        }
    }
}
