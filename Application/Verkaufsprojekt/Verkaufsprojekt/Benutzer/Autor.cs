using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verkaufsprojekt.Benutzer {
    class Autor : Benutzer {

        public static List<Autor> AUTOREN = new List<Autor>();

        private List<Programmiersprache> programmiersprachen;
        private Entwicklerstatus entwickerstatus;

        public Autor(
            string benutzerID,
            string vorname,
            string nachname,
            string nickname,
            string email,
            DateTime geburtsdatum,
            DateTime erstelldatum,
            string passwort,
            List<Programmiersprache> programmiersprachen,
            Entwicklerstatus entwicklerstatus)
            : base(benutzerID, vorname, nachname, nickname, email, geburtsdatum, erstelldatum, passwort) {
            this.programmiersprachen = programmiersprachen;
            this.entwickerstatus = entwickerstatus;

        }

    }
}
