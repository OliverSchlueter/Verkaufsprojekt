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
            } else {
                tsm_profil_login.Enabled = false;
                tsm_profil_registieren.Enabled = false;
                tsm_profil_logout.Enabled = true;
                tsm_profil_einstellungen.Enabled = true;
                tsm_geheZu_produkte.Enabled = true;
            }
        }

        private void tsm_geheZu_startseite_Click(object sender, EventArgs e) {
            Console.WriteLine("Navigating to Startseite");
            //TODO: open startseite
        }

        private void tsm_geheZu_produkte_Click(object sender, EventArgs e) {
            Console.WriteLine("Navigating to Produkte");
            //TODO: open produkte
        }

        private void tsm_profil_login_Click(object sender, EventArgs e) {
            Console.WriteLine("Navigating to Login");
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            Visible = false;
        }
    }
}
