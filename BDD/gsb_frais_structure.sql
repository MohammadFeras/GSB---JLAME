-- phpMyAdmin SQL Dump
-- version 3.3.9
-- http://www.phpmyadmin.net
--
-- Serveur: localhost
-- Généré le : Lun 04 Juillet 2011 à 14:08
-- Version du serveur: 5.5.8
-- Version de PHP: 5.3.5

--SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de données:  gsb_frais 
--

-- --------------------------------------------------------

--
-- Structure de la table  FraisForfait 
--

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'LigneFraisHorsForfait')
BEGIN
    DROP TABLE LigneFraisHorsForfait;
END

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'LigneFraisForfait')
BEGIN
    DROP TABLE LigneFraisForfait;
END


IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'FicheFrais')
BEGIN
    DROP TABLE FicheFrais;
END

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'FraisForfait')
BEGIN
    DROP TABLE FraisForfait;
END

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'Etat')
BEGIN
    DROP TABLE Etat;
END

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'Visiteur')
BEGIN
    DROP TABLE Visiteur;
END

IF EXISTS (SELECT * FROM dbo.sysobjects WHERE name = 'Comptable')
BEGIN
    DROP TABLE Comptable;
END

CREATE TABLE  FraisForfait (
id int IDENTITY(1,1) NOT NULL,
  ref nvarchar(30) NOT NULL,
  libelle nvarchar(50) DEFAULT NULL,
  montant decimal(5,2) DEFAULT NULL,
  PRIMARY KEY (id)
) 


-- --------------------------------------------------------

--
-- Structure de la table  Etat 
--

CREATE TABLE Etat (
  id int IDENTITY(1,1) NOT NULL,
  ref nvarchar(30) NOT NULL,
  libelle nvarchar(50) DEFAULT NULL,
  PRIMARY KEY (id)
) 

-- --------------------------------------------------------

--
-- Structure de la table  Visiteur 
--

CREATE TABLE Visiteur (
 id int IDENTITY(1,1) NOT NULL,
  ref nvarchar(30) NOT NULL,
  nom nvarchar(30) DEFAULT NULL,
   prenom  nvarchar(30)  DEFAULT NULL, 
   login  nvarchar(30) DEFAULT NULL,
   mdp  nvarchar(30) DEFAULT NULL,
   adresse  nvarchar(50) DEFAULT NULL,
   cp  nvarchar(30) DEFAULT NULL,
   ville  nvarchar(30) DEFAULT NULL,
   dateEmbauche datetime DEFAULT NULL,
   mail nvarchar(30) DEFAULT NULL, 
   PRIMARY KEY ( id )
)


-- --------------------------------------------------------

--
-- Structure de la table  FicheFrais 
--

CREATE TABLE FicheFrais  (
   id int IDENTITY(1,1) NOT NULL,
   mois  nvarchar(12) NOT NULL,
   nbJustificatifs int NOT NULL,
   montantValide  decimal(10,2) DEFAULT NULL,
   dateModif  date DEFAULT NULL,
   idEtat int,
   idVisiteur int,
  PRIMARY KEY ( idVisiteur , mois ),
  FOREIGN KEY ( idEtat ) REFERENCES Etat( id ),
  FOREIGN KEY ( idVisiteur ) REFERENCES Visiteur( id )
) 


-- --------------------------------------------------------

--
-- Structure de la table  LigneFraisForfait 
--

CREATE TABLE LigneFraisForfait  (
   id int IDENTITY(1,1) NOT NULL,
   idVisiteur int NOT NULL,
   mois  nvarchar(12) NOT NULL,
   idFraisForfait  int NOT NULL,
   quantite  int DEFAULT NULL,
  PRIMARY KEY ( idVisiteur , mois , idFraisForfait ),
  FOREIGN KEY ( idVisiteur ,  mois ) REFERENCES FicheFrais( idVisiteur ,  mois ),
  FOREIGN KEY ( idFraisForfait ) REFERENCES FraisForfait( id )
) 

-- --------------------------------------------------------

--
-- Structure de la table  LigneFraisHorsForfait 
--

CREATE TABLE LigneFraisHorsForfait  (
   id int IDENTITY(1,1) NOT NULL,
   idVisiteur  int NOT NULL,
   mois  nvarchar(12) NOT NULL,
   libelle  nvarchar(100) DEFAULT NULL,
   date  date DEFAULT NULL,
   montant  decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (id),
  FOREIGN KEY ( idVisiteur ,  mois ) REFERENCES FicheFrais( idVisiteur ,  mois )
) 

CREATE TABLE Comptable (
 id int IDENTITY(1,1) NOT NULL,
  ref nvarchar(30) NOT NULL,
  nom nvarchar(30) DEFAULT NULL,
   prenom  nvarchar(30)  DEFAULT NULL, 
   login  nvarchar(30) DEFAULT NULL,
   mdp  nvarchar(30) DEFAULT NULL,
   adressepro  nvarchar(50) DEFAULT NULL,
   cp  nvarchar(30) DEFAULT NULL,
   ville  nvarchar(30) DEFAULT NULL,
   mail nvarchar(30) DEFAULT NULL,   
   PRIMARY KEY ( id )
)

