CREATE DATABASE IF NOT EXISTS Verkaufsprojekt;
USE Verkaufsprojekt;

# Benutzer
CREATE TABLE IF NOT EXISTS Benutzer(
  `benutzerID` VARCHAR(5) NOT NULL,
  `vorname` VARCHAR(64),
  `nachname` VARCHAR(64) NOT NULL,
  `nickname` VARCHAR(64),
  `email` VARCHAR(64) NOT NULL,
  `geburtsdatum` DATE,
  `erstelldatum` DATE NOT NULL,
  `passwort` VARCHAR(128) NOT NULL,

  PRIMARY KEY(`benutzerID`)
);

# Kunde
CREATE TABLE IF NOT EXISTS Kunde(
  `benutzerID` VARCHAR(5) NOT NULL,
  `guthaben` DECIMAL NOT NULL,

  PRIMARY KEY(`benutzerID`),
  FOREIGN KEY(`benutzerID`)
    REFERENCES `Benutzer`(`benutzerID`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

# Entwicklerstatus
CREATE TABLE IF NOT EXISTS Entwicklerstatus(
    `entwicklerstatusID` INTEGER AUTO_INCREMENT NOT NULL,
    `beschreibung` VARCHAR(64) NOT NULL,

    PRIMARY KEY(`entwicklerstatusID`)
);

# Programmiersprache
CREATE TABLE IF NOT EXISTS Programmiersprache(
  `programmierspracheID` INTEGER AUTO_INCREMENT NOT NULL,
  `name` VARCHAR(64) NOT NULL,

  PRIMARY KEY(`programmierspracheID`)
);

# Autor
CREATE TABLE IF NOT EXISTS Autor(
  `benutzerID` VARCHAR(5) NOT NULL,
  `entwicklerstatus` INTEGER,

  PRIMARY KEY(`benutzerID`),

  FOREIGN KEY (`benutzerID`)
    REFERENCES `Benutzer`(`benutzerID`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,

  FOREIGN KEY(`entwicklerstatus`)
    REFERENCES `Entwicklerstatus`(`entwicklerstatusID`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

# Mitarbeiter
CREATE TABLE IF NOT EXISTS Mitarbeiter(
  `benutzerID` VARCHAR(5) NOT NULL,

  PRIMARY KEY(`benutzerID`),
  FOREIGN KEY(`benutzerID`)
    REFERENCES `Benutzer`(`benutzerID`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

# Produkt
CREATE TABLE IF NOT EXISTS Produkt(
  `produktID` VARCHAR(5) NOT NULL,
  `name` VARCHAR(64) NOT NULL,
  `preis` DECIMAL(10,2) NOT NULL,
  `beschreibung` TEXT,
  `veroeffentlichungsdatum` DATE,

  PRIMARY KEY (`produktID`)
);

# Aufgabenbereich
CREATE TABLE IF NOT EXISTS Aufgabenbereich(
  `aufgabenbereichsID` INTEGER AUTO_INCREMENT NOT NULL,
  `beschreibung` VARCHAR(64),

  PRIMARY KEY (`aufgabenbereichsID`)
);

# Mitarbeiter_arbeitet_Aufgabenbereich
CREATE TABLE IF NOT EXISTS Mitarbeiter_arbeitet_Aufgabenbereich(
  `benutzerID` VARCHAR(5) NOT NULL,
  `aufgabenbereichsID` INTEGER NOT NULL,

  PRIMARY KEY(`benutzerID`, `aufgabenbereichsID`),

  FOREIGN KEY(`benutzerID`)
    REFERENCES `Mitarbeiter`(`benutzerID`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,

  FOREIGN KEY(`aufgabenbereichsID`)
    REFERENCES `Aufgabenbereich`(`aufgabenbereichsID`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

# Mitarbeiter_prueft_Produkt
CREATE TABLE IF NOT EXISTS Mitarbeiter_prueft_Produkt(
  `benutzerID` VARCHAR(5) NOT NULL,
  `produktID` VARCHAR(5) NOT NULL,
  `datum` DATE NOT NULL,

  PRIMARY KEY (`benutzerID`, `produktID`),

  FOREIGN KEY (`benutzerID`)
      REFERENCES `Mitarbeiter` (`benutzerID`)
      ON DELETE RESTRICT
      ON UPDATE CASCADE,

  FOREIGN KEY (`produktID`)
    REFERENCES `Produkt` (`produktID`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

# Kunde_kauft_Produkt
CREATE TABLE IF NOT EXISTS Kunde_kauft_Produkt(
    `kaufID` INTEGER AUTO_INCREMENT NOT NULL,
    `benutzerID` VARCHAR(5) NOT NULL,
    `produktID` VARCHAR(5) NOT NULL,
    `datum` DATE NOT NULL,
    `rabatt` DECIMAL(10,2),

    PRIMARY KEY (`kaufID`),

    FOREIGN KEY(`benutzerID`)
      REFERENCES `Kunde`(`benutzerID`)
      ON DELETE RESTRICT
      ON UPDATE CASCADE,

    FOREIGN KEY(`produktID`)
      REFERENCES `Produkt`(`produktID`)
      ON DELETE RESTRICT
      ON UPDATE CASCADE
);

# Kunde_bewertet_Produkt
CREATE TABLE IF NOT EXISTS Kunde_bewertet_Produkt(
    `benutzerID` VARCHAR(5) NOT NULL,
    `produktID` VARCHAR(5) NOT NULL,
    `sterne` INTEGER NOT NULL,
    `kommentar` TEXT,
    `verifiziert` BOOLEAN NOT NULL,
    `datum` DATE NOT NULL,

    PRIMARY KEY (`benutzerID`, `produktID`),

    FOREIGN KEY(`benutzerID`)
      REFERENCES `Kunde` (`benutzerID`)
      ON DELETE RESTRICT
      ON UPDATE CASCADE,

    FOREIGN KEY(`produktID`)
      REFERENCES `Produkt` (`produktID`)
      ON DELETE RESTRICT
      ON UPDATE CASCADE
);

# Kunde_wuenscht_Produkt
CREATE TABLE IF NOT EXISTS Kunde_wuenscht_Produkt(
  `benutzerID` VARCHAR(5) NOT NULL,
  `produktID` VARCHAR(5) NOT NULL,
  `datum` DATE NOT NULL,

  PRIMARY KEY (`benutzerID`, `produktID`),

  FOREIGN KEY (`benutzerID`)
    REFERENCES `Kunde` (`benutzerID`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,

  FOREIGN KEY (`produktID`)
    REFERENCES `Produkt` (`produktID`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);

# Kunde_beobachtet_Produkt
CREATE TABLE IF NOT EXISTS Kunde_beobachtet_Produkt(
  `benutzerID` VARCHAR(5) NOT NULL,
  `produktID` VARCHAR(5) NOT NULL,
  `datum` DATE,

  PRIMARY KEY (`benutzerID`, `produktID`),

  FOREIGN KEY (`benutzerID`)
    REFERENCES `Kunde` (`benutzerID`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE,

  FOREIGN KEY (`produktID`)
    REFERENCES `Produkt` (`produktID`)
    ON DELETE RESTRICT
    ON UPDATE CASCADE
);
