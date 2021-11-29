using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verkaufsprojekt.Benutzer;

namespace Verkaufsprojekt {
    class Bewertung {

        private Kunde kunde;
        private byte sterne;
        private string kommentar;
        private bool verifizierterKauf;

        public Bewertung(Kunde kunde, byte sterne, string kommentar, bool verifizierterKauf) {
            this.kunde = kunde;
            this.sterne = sterne;
            this.kommentar = kommentar;
            this.verifizierterKauf = verifizierterKauf;
        }

        public byte Sterne { get => sterne; set => sterne = value; }
        public string Kommentar { get => kommentar; set => kommentar = value; }
        public bool VerifizierterKauf { get => verifizierterKauf; set => verifizierterKauf = value; }
        internal Kunde Kunde { get => kunde; set => kunde = value; }
    }
}
