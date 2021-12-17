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
    public partial class RegistierenForm : BaseForm {
        public RegistierenForm() {
            InitializeComponent();
            updateMenuStrip();
        }

        private void RegistierenForm_FormClosing(object sender, FormClosingEventArgs e) {
            Program.STARTSEITEFORM.Visible = true;
        }

        private void btn_registieren_Click(object sender, EventArgs e) {
            string vorname = tb_vorname.Text;
            string nachname = tb_nachname.Text;
            string nickname = tb_nickname.Text;
            string email = tb_email.Text;
            string passwort = tb_passwort.Text;
            DateTime geburtsdatum = dtp_geburtsdatum.Value;
            DateTime erstelldatum = DateTime.Now;

            if(vorname.Length <= 0) {
                MessageBox.Show("Bitte füllen sie das Feld Vorname aus", "Registieren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nachname.Length <= 0) {
                MessageBox.Show("Bitte füllen sie das Feld Nachname aus", "Registieren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (nickname.Length <= 0) {
                MessageBox.Show("Bitte füllen sie das Feld Nickname aus", "Registieren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (email.Length <= 0) {
                MessageBox.Show("Bitte füllen sie das Feld Email aus", "Registieren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (passwort.Length <= 0) {
                MessageBox.Show("Bitte füllen sie das Feld Passwort aus", "Registieren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if(passwort.Length < 8) {
                MessageBox.Show("Bitte wählen sie ein Passwort, welches länger als 8 Zeichen ist", "Registieren", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            //TODO: further checks if valid

            Benutzer.Benutzer benutzer = new Benutzer.Benutzer(Benutzer.Benutzer.GenerateNewBenutzerID(), vorname, nachname, nickname, email, geburtsdatum, erstelldatum, passwort);
            
            Benutzer.Benutzer.BENUTZER.Add(benutzer);
            Program.BENUTZER = benutzer;

            DatabaseManager.Database.execute("INSERT INTO benutzer VALUES('"+benutzer.BenutzerID+"', '"+benutzer.Vorname+"', '"+benutzer.Nachname+"', '"+benutzer.Nickname+"', '"+benutzer.Email+"', '"+benutzer.Geburtsdatum.ToString()+"', '"+benutzer.Erstelldatum.ToString()+"', '"+benutzer.Passwort+"')");

            Program.STARTSEITEFORM.Visible = true;
            Visible = false;
            MessageBox.Show("Erfolgreich registiert!\nIhre Benutzer ID lautet: " + benutzer.BenutzerID + "\nBitte merken oder notieren sie sich diese", "Registierung", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Program.STARTSEITEFORM.updateMenuStrip();
            Close();
        }
    }
}
