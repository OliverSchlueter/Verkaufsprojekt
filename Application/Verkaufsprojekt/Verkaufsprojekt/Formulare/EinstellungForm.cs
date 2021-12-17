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
    public partial class EinstellungForm : BaseForm {

        private bool changedValue;

        public EinstellungForm() {
            InitializeComponent();
            updateMenuStrip();
            refreshTextboxes();
            changedValue = false;
        }

        private void EinstellungForm_FormClosing(object sender, FormClosingEventArgs e) {
            Program.STARTSEITEFORM.Visible = true;
        }

        private void refreshTextboxes() {
            tb_id.Text = Program.BENUTZER.BenutzerID;
            tb_vorname.Text = Program.BENUTZER.Vorname;
            tb_nachname.Text = Program.BENUTZER.Nachname;
            tb_nickname.Text = Program.BENUTZER.Nickname;
            tb_email.Text = Program.BENUTZER.Email;
            dtp_geburtsdatum.Value = Program.BENUTZER.Geburtsdatum;
        }

        private void btn_aendern_Click(object sender, EventArgs e) {
            string id = tb_id.Text;
            string vorname = tb_vorname.Text;
            string nachname = tb_nachname.Text;
            string email = tb_email.Text;
            string nickname = tb_nickname.Text;
            string passwort = tb_passwort.Text;
            string geburtsdatum = dtp_geburtsdatum.Value.ToString();

            //TODO: check if valid

            if(passwort.Length == 0) {
                passwort = Program.BENUTZER.Passwort;
            }

            if(id.Length == 0) {
                MessageBox.Show("Bitte füllen sie das Feld: Benutzer ID", "Leeres Feld", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (vorname.Length == 0) {
                MessageBox.Show("Bitte füllen sie das Feld: Vorname", "Leeres Feld", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nachname.Length == 0) {
                MessageBox.Show("Bitte füllen sie das Feld: Nachname", "Leeres Feld", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (email.Length == 0) {
                MessageBox.Show("Bitte füllen sie das Feld: Email", "Leeres Feld", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (nickname.Length == 0) {
                MessageBox.Show("Bitte füllen sie das Feld: Nickname", "Leeres Feld", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DatabaseManager.Database.execute(
                "UPDATE benutzer SET " +
                "benutzerID='" + id + "', " +
                "vorname='" + vorname + "', " +
                "nachname='" + nachname + "', " +
                "nickname='" + nickname + "', " +
                "email='" + email + "', " +
                "geburtsdatum='" + geburtsdatum + "', " +
                "passwort='" + passwort + "' " +
                "WHERE benutzerID='" + Program.BENUTZER.BenutzerID + "'");

            MessageBox.Show("Erfolgreich Daten geändert", "Änderung", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_zuruecksetzen_Click(object sender, EventArgs e) {
            refreshTextboxes();
            changedValue = false;
        }

        private void tb_dtp_valueChanged(object sender, EventArgs e) {
            changedValue = true;
        }
    }
}
