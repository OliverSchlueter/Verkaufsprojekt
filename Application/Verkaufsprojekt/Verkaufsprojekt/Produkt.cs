using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verkaufsprojekt.Benutzer;

namespace Verkaufsprojekt {
    class Produkt {

        public static List<Produkt> PRODUKTE = new List<Produkt>();

        private string id;
        private string name;
        private List<Autor> autoren;
        private float preis;
        private string beschreibung;
        private DateTime veröffenetlichungsdatum;
        private List<Bewertung> bewertungen;

        public Produkt(
            string id, 
            string name, 
            List<Autor> autoren, 
            float preis, 
            string beschreibung, 
            DateTime veröffenetlichungsdatum,
            List<Bewertung> bewertungen) {
            this.id = id;
            this.name = name;
            this.autoren = autoren;
            this.preis = preis;
            this.beschreibung = beschreibung;
            this.veröffenetlichungsdatum = veröffenetlichungsdatum;
            this.bewertungen = bewertungen;
        }

        public string ID { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public float Preis { get => preis; set => preis = value; }
        public string Beschreibung { get => beschreibung; set => beschreibung = value; }
        public DateTime Veröffenetlichungsdatum { get => veröffenetlichungsdatum; set => veröffenetlichungsdatum = value; }
        internal List<Autor> Autoren { get => autoren; set => autoren = value; }
        internal List<Bewertung> Bewertungen { get => bewertungen; set => bewertungen = value; }


        public static Produkt GetProduktFromID(string id) {
            foreach(Produkt p in PRODUKTE) {
                if (p.ID == id) {
                    return p;
                }
            }

            return null;
        }

        public static void LoadFromDB() {
            Console.WriteLine("Loading all Produkt from DB");

            List<object[]> data = DatabaseManager.Database.GetData("SELECT * FROM produkt");

            foreach (object[] row in data) {
                Produkt produkt = new Produkt((string)row[0], (string)row[1], null, (float)((double)row[2]), (string)row[3], Convert.ToDateTime(row[4]), null);
                PRODUKTE.Add(produkt);
            }

            Console.WriteLine("Loaded all Produkt from DB");
        }
    }
}
