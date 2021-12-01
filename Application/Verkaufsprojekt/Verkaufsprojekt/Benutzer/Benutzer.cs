using System;
using System.Collections.Generic;

namespace Verkaufsprojekt.Benutzer {
    class Benutzer {

        public static List<Benutzer> BENUTZER = new List<Benutzer>();

        private string benutzerID;
        private string vorname;
        private string nachname;
        private string nickname;
        private string email;
        private DateTime geburtsdatum;
        private DateTime erstelldatum;
        private string passwort;

        public Benutzer(
            string benutzerID, 
            string vorname, 
            string nachname, 
            string nickname, 
            string email, 
            DateTime geburtsdatum, 
            DateTime erstelldatum, 
            string passwort) {
            this.benutzerID = benutzerID;
            this.vorname = vorname;
            this.nachname = nachname;
            this.nickname = nickname;
            this.email = email;
            this.geburtsdatum = geburtsdatum;
            this.erstelldatum = erstelldatum;
            this.passwort = passwort;
        }

        public string BenutzerID { get => benutzerID; set => benutzerID = value; }
        public string Vorname { get => vorname; set => vorname = value; }
        public string Nachname { get => nachname; set => nachname = value; }
        public string Nickname { get => nickname; set => nickname = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Geburtsdatum { get => geburtsdatum; set => geburtsdatum = value; }
        public DateTime Erstelldatum { get => erstelldatum; set => erstelldatum = value; }
        public string Passwort { get => passwort; set => passwort = value; }
    }
}
