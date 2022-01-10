using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verkaufsprojekt.Formulare;
using Verkaufsprojekt.Benutzer;

namespace Verkaufsprojekt {
    static class Program {

        public static string VERSION { get { return "1.0.0 RELEASE"; } }

        public static BaseForm BASEFORM = null;
        public static StartseiteForm STARTSEITEFORM = null;

        public static Benutzer.Benutzer BENUTZER = null;

        [STAThread]
        static void Main() {

            Console.WriteLine("Starting Verkaufsprojekt v" + VERSION);
            Console.WriteLine(Hasher.hashPassword("O103", "oliver123"));
            DatabaseManager.Database = new DatabaseManager("Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source = Database.accdb");

            Benutzer.Benutzer.LoadFromDB();
            Autor.LoadFromDB();
            Produkt.LoadFromDB();
            Kunde.LoadFromDB();


            BASEFORM = new BaseForm();
            STARTSEITEFORM = new StartseiteForm();

            Application.EnableVisualStyles();
            Application.Run(STARTSEITEFORM);
        }
    }
}
