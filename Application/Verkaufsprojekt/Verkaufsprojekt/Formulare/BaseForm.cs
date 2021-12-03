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
            updateMenuStrip();
        }

        public void updateMenuStrip() {
            if(Program.BENUTZER == null) {
                tsm_profil_logout.Enabled = false;
                tsm_profil_einstellungen.Enabled = false;
                tsm_geheZu_produkte.Enabled = false;
            }
        }

    }
}
