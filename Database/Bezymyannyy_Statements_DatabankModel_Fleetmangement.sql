-- Databank ontwerp opdracht fleetmanagement.
-- Gemaakt door: Lennert Martens, Anastassia Edel, Guylian Weverbergh en Tjörven Van Der Pulst.

-- geen dubbele relaties leggen
-- kijk types na
-- controleer volgorde
-- IsDeleted voor logische delete
-- EF zal wel meervoud toevoegen

CREATE DATABASE Bezymyanny;
GO

USE Bezymyanny;
GO

CREATE TABLE Adres (
  AdresID int NOT NULL IDENTITY(1,1),
  Straat nvarchar(50) NOT NULL,
  Huisnummer nvarchar(10) NOT NULL,
  Postcode nvarchar(10) NOT NULL,
  Stad nvarchar(50) NOT NULL,
  Land nvarchar(50) NOT NULL,
  IsDeleted bit DEFAULT 0,
  PRIMARY KEY (AdresID)
);

CREATE TABLE Brandstoftype (
  BrandstoftypeID int NOT NULL IDENTITY(1,1),
  Beschrijving nvarchar(50) NOT NULL,
  IsDeleted bit DEFAULT 0
  PRIMARY KEY (BrandstoftypeID)
);

CREATE TABLE Rijbewijstype (
  RijbewijstypeID int NOT NULL IDENTITY(1,1),
  Beschrijving nvarchar(50) NOT NULL,
  IsDeleted bit DEFAULT 0,
  PRIMARY KEY (RijbewijstypeID)
);

CREATE TABLE Voertuig (
  VoertuigID int NOT NULL IDENTITY(1,1),
  Merk nvarchar(25) NOT NULL,
  Model nvarchar(50) NOT NULL,
  Chassisnummer nvarchar(17) NOT NULL UNIQUE,
  Nummerplaat nvarchar(15) NOT NULL UNIQUE,
  BrandstoftypeId int NOT NULL,
  Kleur nvarchar(20) DEFAULT NULL,
  AantalDeuren tinyint DEFAULT NULL,
  BestuurderID int DEFAULT NULL,
  IsDeleted bit DEFAULT 0,
  PRIMARY KEY (VoertuigID),
  CONSTRAINT fk_voertuig_brandstoftype FOREIGN KEY(BrandstoftypeID) REFERENCES Brandstoftype(BrandstoftypeID)
);

 CREATE TABLE Bestuurder (
  BestuurderID int NOT NULL IDENTITY(1,1),
  Naam nvarchar(50) NOT NULL,
  Voornaam nvarchar(50) NOT NULL,
  AdresID INT DEFAULT NULL,
  Geboortedatum DATETIME2 DEFAULT NULL,
  Rijksregisternummer nvarchar(12) NOT NULL UNIQUE,
  RijbewijstypeID INT NOT NULL,
  VoertuigID INT DEFAULT NULL,
  TankkaartID INT DEFAULT NULL,
  IsDeleted BIT DEFAULT 0,
  PRIMARY KEY (BestuurderID),
  CONSTRAINT fk_bestuurder_adres FOREIGN KEY (AdresID) REFERENCES Adres (AdresID),
  CONSTRAINT fk_bestuurder_rijbewijstype FOREIGN KEY (RijbewijstypeID) REFERENCES Rijbewijstype (RijbewijstypeID),
  CONSTRAINT fk_bestuurder_voertuig FOREIGN KEY (VoertuigID) REFERENCES Voertuig (VoertuigID)
);

CREATE TABLE Tankkaart (
  TankkaartID int NOT NULL IDENTITY(1,1),
  Kaartnummer INT NOT NULL UNIQUE,
  Geldigheidsdatum DATETIME2 DEFAULT NULL,
  Pincode INT DEFAULT NULL,
  BestuurderID INT DEFAULT NULL,
  Geblokkeerd BIT DEFAULT '0',
  IsDeleted BIT DEFAULT 0,
  PRIMARY KEY (TankkaartID),
  CONSTRAINT fk_tankkaart_bestuurder FOREIGN KEY (BestuurderID) REFERENCES bestuurder (BestuurderID)
);
