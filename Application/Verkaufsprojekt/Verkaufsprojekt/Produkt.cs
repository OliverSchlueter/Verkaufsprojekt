using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verkaufsprojekt.Benutzer;

namespace Verkaufsprojekt {
    class Produkt {

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
    }
}
