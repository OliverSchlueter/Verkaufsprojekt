using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verkaufsprojekt.Formulare {
    public partial class StartseiteForm : BaseForm {
        public StartseiteForm() {

            InitializeComponent();
            updateMenuStrip();
		}

        private void panel1_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.DrawLine(
                new Pen(Color.Black), 
                lbl_neueProdukteHeadline.Location.X, 
                lbl_neueProdukteHeadline.Location.Y + lbl_neueProdukteHeadline.Height + 1, 
                lbl_neueProdukteHeadline.Location.X + lbl_neueProdukteHeadline.Width, 
                lbl_neueProdukteHeadline.Location.Y + lbl_neueProdukteHeadline.Height + 1
            );
        }

        private void panel2_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;
            g.DrawLine(
                new Pen(Color.Black),
                lbl_meistGekauftHeadline.Location.X,
                lbl_meistGekauftHeadline.Location.Y + lbl_meistGekauftHeadline.Height + 1,
                lbl_meistGekauftHeadline.Location.X + lbl_meistGekauftHeadline.Width,
                lbl_meistGekauftHeadline.Location.Y + lbl_meistGekauftHeadline.Height + 1
            );
        }

        private void StartseiteForm_Load(object sender, EventArgs e) {
            List<object[]> neueProdukteData = DatabaseManager.Database.GetData("SELECT name, preis FROM produkt ORDER BY veroeffentlichungsdatum");

            lbl_produkt1.Text = neueProdukteData[0][0] + " (" + neueProdukteData[0][1] + " €)";

            for (int i = 2; i <= 5; i++) {
                if (neueProdukteData.Count < i) {
                    break;
                }

                Label l = new Label();
                l.Width = lbl_produkt1.Width;
                l.Height = lbl_produkt1.Height;
                l.Name = "Produkt" + i;
                string name = neueProdukteData[i - 1][0].ToString();
                string preis = neueProdukteData[i - 1][1].ToString() + " €";
                l.Text = name + " (" + preis + ")";
                l.Location = new Point(lbl_produkt1.Location.X, lbl_produkt1.Location.Y + (lbl_produkt1.Height*(i-1)) + 5);
                panel1.Controls.Add(l);
            }

            List<object[]> meistGekaufteProdukteData = DatabaseManager.Database.GetData(
                "SELECT produktID, COUNT(*) FROM kunde_kauft_produkt GROUP BY produktID ORDER BY COUNT(*) DESC"
                );

            lbl_mg_1.Text = Produkt.GetProduktFromID((string)meistGekaufteProdukteData[0][0]).Name + " (x" + meistGekaufteProdukteData[0][1] + ")";

            for (int i = 2; i <= 5; i++) {
                if (meistGekaufteProdukteData.Count < i) {
                    break;
                }

                Label l = new Label();
                l.Width = lbl_mg_1.Width;
                l.Height = lbl_mg_1.Height;
                l.Name = "Produkt" + i;
                string name = Produkt.GetProduktFromID((string)meistGekaufteProdukteData[i-1][0]).Name;
                int amount = (int)meistGekaufteProdukteData[i - 1][1];
                l.Text = name + " (x" + amount + ")";
                l.Location = new Point(lbl_mg_1.Location.X, lbl_mg_1.Location.Y + (lbl_mg_1.Height * (i - 1)) + 5);
                panel2.Controls.Add(l);
            }

        }
    }
}
