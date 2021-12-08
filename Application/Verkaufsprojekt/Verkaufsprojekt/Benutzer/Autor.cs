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
            Entwicklerstatus entwickerstatus)
            : base(benutzerID, vorname, nachname, nickname, email, geburtsdatum, erstelldatum, passwort) {
            this.programmiersprachen = programmiersprachen;
            this.entwickerstatus = entwickerstatus;

        }

        public Autor(Benutzer benutzer, List<Programmiersprache> programmiersprachen, Entwicklerstatus entwicklerstatus)
            : base(benutzer.BenutzerID, benutzer.Vorname, benutzer.Nachname, benutzer.Nickname, benutzer.Email, benutzer.Geburtsdatum, benutzer.Erstelldatum, benutzer.Passwort) {
            this.programmiersprachen = programmiersprachen;
            this.entwickerstatus = entwicklerstatus;
        }


        internal List<Programmiersprache> Programmiersprachen { get => programmiersprachen; set => programmiersprachen = value; }
        internal Entwicklerstatus Entwickerstatus { get => entwickerstatus; set => entwickerstatus = value; }


        new public static void LoadFromDB() {
            Console.WriteLine("Loading all Autor from DB");

            List<object[]> data = DatabaseManager.Database.GetData("SELECT * FROM autor, autor_schreibt_produkt WHERE autor_schreibt_produkt.benutzerID = autor.benutzerID");

            foreach (object[] row in data) {
                Autor autor = new Autor(Benutzer.getBenutzerFromID((string) row[0]), null, EntwicklerstatusManager.getByName((string) row[1]));

                AUTOREN.Add(autor);
            }

            Console.WriteLine("Loaded all Autor from DB");
        }
    }
}
