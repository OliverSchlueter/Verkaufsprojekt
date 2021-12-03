using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verkaufsprojekt.Formulare;
using Verkaufsprojekt.Benutzer;

namespace Verkaufsprojekt {
    static class Program {

        public static BaseForm BASEFORM = new BaseForm();
        public static StartseiteForm STARTSEITEFORM = new StartseiteForm();

        public static Benutzer.Benutzer BENUTZER;

        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.Run(STARTSEITEFORM);
        }
    }
}
