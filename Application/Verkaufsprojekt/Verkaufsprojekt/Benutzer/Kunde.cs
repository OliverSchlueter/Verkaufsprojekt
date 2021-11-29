using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkaufsprojekt.Benutzer {
    class Kunde : Benutzer {

        public static List<Kunde> KUNDEN = new List<Kunde>();

        private float guthaben;
        private List<Produkt> gekaufteProdukte;
        private List<Produkt> beobachtungsliste;
        private List<Produkt> wunschliste;

        public Kunde(
            string benutzerID,
            string vorname,
            string nachname,
            string nickname,
            string email,
            DateTime geburtsdatum,
            DateTime erstelldatum,
            string passwort)
            : base(benutzerID, vorname, nachname, nickname, email, geburtsdatum, erstelldatum, passwort) {

        }
    }
}
