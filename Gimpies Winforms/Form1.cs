using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            if (Storage.SelectedItems.Count > 0 && sellCount.Value > 0) { sellButton.Enabled = true; }
            else { sellButton.Enabled = false; }
            if (nameShoeSet.Text.Length > 0 && priceSet.Value > 0 && storageSet.Value > 0 && sizeSet.Value > 0 && colorSet.Text.Length > 0) {  addButton.Enabled = true; }
            else { addButton.Enabled = false; }
        }

        public void EnableAll()
        {
            voorraadBekijkenToolStripMenuItem.Checked = false;
            toevoegenToolStripMenuItem.Checked = false;
            aanpassenToolStripMenuItem.Checked = false;
            verwijderenToolStripMenuItem.Checked = false;

            voorraadBekijkenToolStripMenuItem.Enabled = true;
            if (UsernameInput.Text == "m")
            {
                manageToolStripMenuItem.Enabled = true;
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
                EnableAll();
                menuStrip1.Visible = true;
                this.Text = "Menu";
                countShoe[0] = 32;
                countShoe[1] = 15;
                countShoe[2] = 23;
            }
            else if (username == manager && password == passwordManager)
            {
                Login.Visible = false;
                Refresh();
                EnableAll();
                menuStrip1.Visible = true;
                manageToolStripMenuItem.Visible = true;
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
            this.Text = "Voorraad bekijken en verkopen";
            voorraadBekijkenToolStripMenuItem.Checked = true;
            voorraadBekijkenToolStripMenuItem.Enabled = false;
        }

        private void toevoegenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnableAll();
            this.Text = "Toevoegen";
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

                sellCount.Visible = true;
                sellButton.Visible = true;
                paarText.Visible = true;
            }
            else
            {
                sellCount.Visible = false;
                sellButton.Visible = false;
                paarText.Visible = false;
            }
        }

        private void sellButton_Click(object sender, EventArgs e)
        {
            decimal count = sellCount.Value;
            ListViewItem selectedItem = Storage.SelectedItems[0];
            string input = selectedItem.SubItems[2].Text;
            string[] parts = input.Split(' '); // Split de string op spaties

            // De eerste deel (index 0) is het getal
            if (parts.Length > 0)
            {
                string numberPart = parts[0]; // Haal het getal deel uit de array
                int.TryParse(numberPart, out int shoeCount);

                if (count < (shoeCount + 1))
                {
                    int intCount = (int)count;
                    int newShoeCount = shoeCount - intCount;
                    string newShoeCountString = newShoeCount.ToString();
                    selectedItem.SubItems[2].Text = newShoeCountString + " paar";
                }
                else
                {
                    TooMuchError tooMuch = new TooMuchError();
                    SystemSounds.Exclamation.Play();
                    tooMuch.ShowDialog();
                }
            }
        }

        private void toevoegenToolStripMenuItem1_CheckedChanged(object sender, EventArgs e)
        {
            if (toevoegenToolStripMenuItem.Checked == true)
            {
                Storage.Visible = true;
                addPanel.Visible = true;
                Refresh();
            }
            else
            {
                addPanel.Visible = false;
                Refresh();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            // Haal de waarden op uit de TextBoxes en NumericUpDowns
            string naam = nameShoeSet.Text;
            int prijs = (int)priceSet.Value;
            int voorraad = (int)storageSet.Value;
            decimal schoenmaat = sizeSet.Value;
            string kleur = colorSet.Text;

            string voorraadTekst = voorraad + " paar";

            ListViewItem item = new ListViewItem(naam);
            item.SubItems.Add("€" + prijs.ToString());
            item.SubItems.Add(voorraadTekst.ToString());
            item.SubItems.Add(schoenmaat.ToString());
            item.SubItems.Add(kleur);

            Storage.Items.Add(item);

            nameShoeSet.Clear();
            priceSet.Value = 0;
            storageSet.Value = 0;
            sizeSet.Value = 0;
            colorSet.Clear();
        }
    }
}
