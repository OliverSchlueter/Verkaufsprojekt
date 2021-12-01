using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkaufsprojekt.Benutzer {
    class Mitarbeiter : Benutzer {

        public static List<Mitarbeiter> MITARBEITER = new List<Mitarbeiter>();

        private Aufgabenbereich aufgabenbereich;

        public Mitarbeiter(
            string benutzerID,
            string vorname,
            string nachname,
            string nickname,
            string email,
            DateTime geburtsdatum,
            DateTime erstelldatum,
            string passwort,
            Aufgabenbereich aufgabenbereich)
            : base(benutzerID, vorname, nachname, nickname, email, geburtsdatum, erstelldatum, passwort) {
            this.aufgabenbereich = aufgabenbereich;
        }

    }
}
