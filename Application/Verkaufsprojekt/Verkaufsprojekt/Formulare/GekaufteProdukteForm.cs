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
            foreach (Produkt p in Kunde.getKundeFromID(Program.BENUTZER.BenutzerID).GekaufteProdukte) {
                dgv_produkte.Rows.Add(p.ID, p.Name, p.Preis + " €");
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
        }
    }
}
