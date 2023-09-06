using System;
using System.Threading;
using System.Windows.Forms;

namespace Gimpies_Winforms
{
    public partial class Form1 : Form
    {
        int tries = 3;
        public Form1()
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string verkoper = "";
            string passwordVerkoper = "";
            string manager = "Manager";
            string passwordManager = "Gimpies_Manager";
            string username = usernameInput.Text;
            string password = passwordInput.Text;
            if (username == verkoper && password == passwordVerkoper)
            {
                // Inloggen als verkoper
                // Voeg hier de logica toe om de verkoper te laten inloggen
                Form2 verkopersForm = new Form2();
                verkopersForm.Show();
                this.Hide();
            }
            else if (username == manager && password == passwordManager)
            {
                // Inloggen als manager
                // Voeg hier de logica toe om de manager te laten inloggen
                welkom.Text = "Welkom Manager";
                welkom.Visible = true;
                Refresh();
                Thread.Sleep(3000);
                Application.Exit();
            }
            else
            {
                // Onjuiste inloggegevens
                tries--;

                if (tries == 0)
                {
                    incorrect.Visible = true;
                    incorrectText.Visible = true;
                    incorrectText.Text = "Je deed er teveel pogingen over";
                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                }
                else
                {
                    // Geef een foutmelding weer of neem andere actie voor mislukte inlogpogingen
                    incorrectText.Text = "De gebruikersnaam of het wachtwoord\nis onjuist. Je hebt nog " + tries + " pogingen over";
                    incorrect.Visible = true;
                    Refresh();
                    Thread.Sleep(3000);
                    incorrect.Visible = false;
                    Refresh();
                }
            }
        }
    }
}
