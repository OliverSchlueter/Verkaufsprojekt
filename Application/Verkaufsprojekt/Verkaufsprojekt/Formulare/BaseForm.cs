using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verkaufsprojekt.Formulare {
    public partial class BaseForm : Form {
        public BaseForm() {
            InitializeComponent();
        }

        public void updateMenuStrip() {
            Console.WriteLine("Updating menu strip");
            if(Program.BENUTZER == null) {
                tsm_profil_login.Enabled = true;
                tsm_profil_registieren.Enabled = true;
                tsm_profil_logout.Enabled = false;
                tsm_profil_einstellungen.Enabled = false;
                tsm_geheZu_produkte.Enabled = false;
                tsm_geheZu_gekaufte_produkte.Enabled = false;
            } else {
                tsm_profil_login.Enabled = false;
                tsm_profil_registieren.Enabled = false;
                tsm_profil_logout.Enabled = true;
                tsm_profil_einstellungen.Enabled = true;
                tsm_geheZu_produkte.Enabled = true;
                if (Benutzer.Kunde.getKundeFromID(Program.BENUTZER.BenutzerID) != null) {
                    tsm_geheZu_gekaufte_produkte.Enabled = true;
                }
            }
        }

        private void tsm_geheZu_startseite_Click(object sender, EventArgs e) {
            Console.WriteLine("Navigating to Startseite");
            Visible = false;
            Program.STARTSEITEFORM.Visible = true;
        }

        private void tsm_geheZu_produkte_Click(object sender, EventArgs e) {
            Console.WriteLine("Navigating to Produkte");
            ProdukteForm produkteForm = new ProdukteForm();
            produkteForm.Show();
            Visible = false;
        }

        private void tsm_profil_login_Click(object sender, EventArgs e) {
            Console.WriteLine("Navigating to Login");
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Visible = false;
        }

        private void tsm_geheZu_gekaufte_produkte_Click(object sender, EventArgs e) {
            Console.WriteLine("Navigating to Gekaufte produkte");
            GekaufteProdukteForm gekaufteProdukteForm = new GekaufteProdukteForm();
            gekaufteProdukteForm.Show();
            Visible = false;
        }

        private void tsm_profil_logout_Click(object sender, EventArgs e) {

            DialogResult logoutDialog = MessageBox.Show("Wollen sie sich wirklich ausloggen?", "Ausloggen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(logoutDialog != DialogResult.Yes) {
                return;
            }

            Console.WriteLine("Logging out Benutzer: " + Program.BENUTZER.BenutzerID);
            Program.BENUTZER = null;
            
            if(Name != Program.STARTSEITEFORM.Name) {
                Program.STARTSEITEFORM.Visible = true;
                Visible = false;
            }

            Program.STARTSEITEFORM.updateMenuStrip();
            MessageBox.Show("Erfolgreich ausgeloggt", "Ausloggen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tsm_profil_registieren_Click(object sender, EventArgs e) {
            Console.WriteLine("Navigating to Registieren");
            RegistierenForm registierenForm = new RegistierenForm();
            registierenForm.Show();
            Visible = false;
        }

        private void tsm_profil_einstellungen_Click(object sender, EventArgs e) {
            Console.WriteLine("Navigating to Einstellungen");
            EinstellungForm einstellungForm = new EinstellungForm();
            einstellungForm.Show();
            Visible = false;
        }
    }
}
