﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            string passwort,
            float guthaben,
            List<Produkt> gekaufteProdukte,
            List<Produkt> beobachtungsliste,
            List<Produkt> wunschliste)
            : base(benutzerID, vorname, nachname, nickname, email, geburtsdatum, erstelldatum, passwort) {
            this.guthaben = guthaben;
            this.gekaufteProdukte = gekaufteProdukte;
            this.beobachtungsliste = beobachtungsliste;
            this.wunschliste = wunschliste;
        }

        public Kunde(Benutzer benutzer, float guthaben, List<Produkt> gekaufteProdukte, List<Produkt> beobachtungsliste, List<Produkt> wunschliste)
            : base(benutzer.BenutzerID, benutzer.Vorname, benutzer.Nachname, benutzer.Nickname, benutzer.Email, benutzer.Geburtsdatum, benutzer.Erstelldatum, benutzer.Passwort) {
            this.guthaben = guthaben;
            this.gekaufteProdukte = gekaufteProdukte;
            this.beobachtungsliste = beobachtungsliste;
            this.wunschliste = wunschliste;
        }

        public bool produktKaufen(Produkt produkt) {

            if (produkt == null) {
                MessageBox.Show("Produkt existiert nicht", "Kaufabbruch", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            if (this.guthaben < produkt.Preis) {
                MessageBox.Show("Sie haben nicht genug Guthaben, um das Produkt (" + produkt.ID + ") zu kaufen", "Kauffehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            DialogResult kaufBestaetigung = MessageBox.Show("Wollen Sie das Produk(" + produkt.ID + ") wirklich kaufen?", "Kauf", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (kaufBestaetigung != DialogResult.Yes) {
                MessageBox.Show("Erfolgreich Kauf abgebrochen", "Kaufabbruch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            this.gekaufteProdukte.Add(produkt);
            this.guthaben -= produkt.Preis;

            MessageBox.Show("Sie haben das Produkt (" + produkt.ID + ") erfolgreich gekauft", "Kaufbestätigung", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        public bool produktWuenschen(Produkt produkt) {

            if (produkt == null) {
                MessageBox.Show("Produkt existiert nicht", "Kaufabbruch", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            DialogResult wunschBestaetigung = MessageBox.Show("Wollen Sie das Produk(" + produkt.ID + ") wirklich auf ihre Wunschliste hinzufügen?", "Wunschliste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (wunschBestaetigung != DialogResult.Yes) {
                MessageBox.Show("Erfolgreich Wunsch abgebrochen", "Wunschabbruch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            this.wunschliste.Add(produkt);
            MessageBox.Show("Produkt erfolgreich zur Wunschliste hinzugefügt", "Wunschliste", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        public bool produktBeobachten(Produkt produkt) {

            if (produkt == null) {
                MessageBox.Show("Produkt existiert nicht", "Kaufabbruch", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return false;
            }

            DialogResult beobachtungshBestaetigung = MessageBox.Show("Wollen Sie das Produk(" + produkt.ID + ") wirklich auf ihre Beobachtungsliste hinzufügen?", "Beobachtungsliste", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (beobachtungshBestaetigung != DialogResult.Yes) {
                MessageBox.Show("Erfolgreich Beobachtung abgebrochen", "Beobachtungsabbruch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            this.beobachtungsliste.Add(produkt);
            MessageBox.Show("Produkt erfolgreich zur Beobachtungsliste hinzugefügt", "Wunschliste", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        public void produktBewerten(Produkt produkt, byte sterne, string kommentar) {

            if(sterne < 1 || sterne > 5) {
                MessageBox.Show("Ungültige Anzahl an Sterne", "Bewertung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bewertung bewertung = new Bewertung(this, sterne, kommentar, gekaufteProdukte.Contains(produkt));
            produkt.Bewertungen.Add(bewertung);
            MessageBox.Show("Produkt erfolgreich bewertet", "Bewertung", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }

}