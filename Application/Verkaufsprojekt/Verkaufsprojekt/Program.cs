using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verkaufsprojekt.Formulare;
using Verkaufsprojekt.Benutzer;

namespace Verkaufsprojekt {
    static class Program {

        public static BaseForm BASEFORM = null;
        public static StartseiteForm STARTSEITEFORM = null;

        public static Benutzer.Benutzer BENUTZER = null;

        [STAThread]
        static void Main() {
            
            DatabaseManager.Database = new DatabaseManager("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Database.accdb");

            Benutzer.Benutzer.loadFromDB();


            BASEFORM = new BaseForm();
            STARTSEITEFORM = new StartseiteForm();

            Application.EnableVisualStyles();
            Application.Run(STARTSEITEFORM);
        }
    }
}
