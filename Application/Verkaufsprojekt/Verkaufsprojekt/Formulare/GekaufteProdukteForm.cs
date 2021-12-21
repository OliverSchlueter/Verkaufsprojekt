using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verkaufsprojekt.Benutzer;

namespace Verkaufsprojekt.Formulare {
    public partial class GekaufteProdukteForm : BaseForm {

        private Produkt selectedProduct;

        public GekaufteProdukteForm() {
            InitializeComponent();
        }

        private void GekaufteProdukteForm_Load(object sender, EventArgs e) {
            refreshDgv();
            if (dgv_produkte.Rows.Count > 0) {
                refreshCurrentSelected((string)dgv_produkte.Rows[0].Cells[0].Value);
            }
        }

        private void GekaufteProdukteForm_FormClosing(object sender, FormClosingEventArgs e) {
            Program.STARTSEITEFORM.Visible = true;
        }

        private void dgv_produkte_CellClick(object sender, DataGridViewCellEventArgs e) {
            string id = (string)dgv_produkte.Rows[e.RowIndex].Cells[0].Value;
            refreshCurrentSelected(id);
        }

        /**
        * Refreshes the datagrid-view with all products
        */
        private void refreshDgv() {
            dgv_produkte.Rows.Clear();
            try {
                foreach (Produkt p in Kunde.getKundeFromID(Program.BENUTZER.BenutzerID).GekaufteProdukte) {
                    dgv_produkte.Rows.Add(p.ID, p.Name, p.Preis + " €");
                }
            } catch(Exception e) {
                MessageBox.Show("Ein Fehler ist aufgetreten.");
            }

        }

        /**
         * Fill lables and textboxes with details about a certain product
         */
        private void refreshCurrentSelected(string id) {
            Produkt produkt = Produkt.GetProduktFromID(id);

            if (produkt == null) {
                MessageBox.Show("Es ist ein Fehler aufgetreten", "Fehler", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            selectedProduct = produkt;

            lbl_id.Text = produkt.ID;
            lbl_name.Text = produkt.Name;
            lbl_preis.Text = produkt.Preis + " €";
            lbl_datum.Text = produkt.Veröffenetlichungsdatum.ToShortDateString();
            rtb_beschreibung.Text = produkt.Beschreibung;

            foreach(Bewertung bewertung in produkt.Bewertungen) {
                dgv_bewertungen.Rows.Add(bewertung.Kunde.BenutzerID, bewertung.Sterne, bewertung.Kommentar);
            }
        }

        private void btn_bewerten_Click(object sender, EventArgs e) {
            string kommentar = rtb_bewertung.Text;
            int sterne = tb_bewertung_sterne.Value;

            Bewertung bewertung = new Bewertung(
                Kunde.getKundeFromID(Program.BENUTZER.BenutzerID),
                (byte)sterne, 
                kommentar,
                true
            );

            bool alreadyBewertet = ((int)DatabaseManager.Database.GetData("SELECT COUNT(*) FROM kunde_bewertet_produkt WHERE benutzerID='"+Program.BENUTZER.BenutzerID+"' AND produktID='"+selectedProduct.ID+"'")[0][0]) > 0;

            if (alreadyBewertet) {
                MessageBox.Show("Sie haben dieses Produkt schon bewertet", "Bewertung", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmBewertung = MessageBox.Show("Wollen sie das Produkt wirklich mit " + sterne + " Sterne bewerten?", "Bewerten", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(confirmBewertung != DialogResult.Yes) {
                MessageBox.Show("Bewertung abgebrochen", "Bewertung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(selectedProduct != null) {
                selectedProduct.Bewertungen.Add(bewertung);
                DatabaseManager.Database.execute("INSERT INTO kunde_bewertet_produkt VALUES('" + Program.BENUTZER.BenutzerID + "','" + selectedProduct.ID + "'," + bewertung.Sterne + ",'" + bewertung.Kommentar + "'," + (bewertung.VerifizierterKauf ? 1 : 0) + ",'" + DateTime.Now.ToString() + "')");
                MessageBox.Show("Bewertung abgeschickt", "Bewertung", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tb_bewertung_sterne.Value = 1;
                rtb_bewertung.Text = "Hier Kommentar einfügen.";

            } else {
                MessageBox.Show("Kein Produkt ausgewählt", "Bewerten fehlgeschlagen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
