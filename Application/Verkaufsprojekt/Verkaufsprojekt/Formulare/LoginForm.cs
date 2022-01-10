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
    public partial class LoginForm : BaseForm {
        public LoginForm() {
            InitializeComponent();
            updateMenuStrip();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e) {
            Program.STARTSEITEFORM.Visible = true;
        }

        private void btn_login_Click(object sender, EventArgs e) {
            if(tb_benutzerID.Text == "") {
                MessageBox.Show("Bitte füllen Sie das Feld 'Benutzer ID' aus", "Login Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (tb_passwort.Text == "") {
                MessageBox.Show("Bitte füllen Sie das Feld 'Passwort' aus", "Login Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string benutzerRolle = cb_benutzer.Text;

            if (cb_benutzer.Text.Length > 0) {
                bool found = false;
                foreach(string i in cb_benutzer.Items) {
                    if(i == benutzerRolle) {
                        found = true;
                        break;
                    }
                }

                if (!found) {
                    MessageBox.Show("Bitte wählen sie eine valide Rolle", "Login Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            } else {
                MessageBox.Show("Bitte wählen sie eine Rolle", "Login Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string benutzerID = tb_benutzerID.Text;
            string passwort = tb_passwort.Text;
            bool login = false;

            foreach(Benutzer.Benutzer benutzer in Benutzer.Benutzer.BENUTZER) {
                if (benutzer.BenutzerID.Equals(benutzerID)) {
                    if (benutzer.Passwort.Equals(Hasher.hashPassword(benutzer.BenutzerID, passwort))) {
                        Program.BENUTZER = benutzer;
                        login = true;
                        Console.WriteLine("Login als " + benutzer.Vorname + " " + benutzer.Nachname + " - " + benutzer.BenutzerID);
                        MessageBox.Show("Erfolgreich als " + benutzer.Vorname + " " + benutzer.Nachname + " eingeloggt", "Login", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Program.STARTSEITEFORM.Visible = true;
                        Program.STARTSEITEFORM.updateMenuStrip();
                        Close();
                    } else {
                        MessageBox.Show("Falsches Passwort", "Login Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    break;
                }
            }

            if (!login) {
                MessageBox.Show("Benutzer ID nicht gefunden", "Login Fehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
