-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 26. Sep 2018 um 14:23
-- Server-Version: 10.1.36-MariaDB
-- PHP-Version: 7.2.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `carsharingdb`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `buchung`
--

CREATE TABLE `buchung` (
  `B_ID` int(9) NOT NULL,
  `F_ID` int(9) NOT NULL,
  `K_ID` int(9) NOT NULL,
  `Startzeitpunkt` datetime(6) NOT NULL,
  `Endzeitpunkt` datetime(6) NOT NULL,
  `Startkilometerstand` double(10,2) NOT NULL,
  `Endkilometerstand` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fahrzeug`
--

CREATE TABLE `fahrzeug` (
  `F_ID` int(9) NOT NULL,
  `Ft_ID` int(9) NOT NULL,
  `Kennzeichen` varchar(50) NOT NULL,
  `Kilometerstand` double(10,2) NOT NULL,
  `Letzte Wartung` date NOT NULL,
  `Tankfüllung` double(10,2) NOT NULL,
  `Standort` point NOT NULL,
  `Verfügbarkeit` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fahrzeugtyp`
--

CREATE TABLE `fahrzeugtyp` (
  `Ft_ID` int(9) NOT NULL,
  `Marke` varchar(50) NOT NULL,
  `Modell` varchar(50) NOT NULL,
  `Leistung` int(9) NOT NULL,
  `Baujahr` year(4) NOT NULL,
  `Schaltung` varchar(50) NOT NULL,
  `Max_Tankvolumen` double(10,2) NOT NULL,
  `Grundpreis` double(10,2) NOT NULL,
  `Preis/km` double(10,2) NOT NULL,
  `Preis/min` double(10,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kunde`
--

CREATE TABLE `kunde` (
  `K_ID` int(9) NOT NULL,
  `Vorname` varchar(40) NOT NULL,
  `Nachname` varchar(40) NOT NULL,
  `E-Mail Adresse` varchar(50) NOT NULL,
  `Telefonnummer` varchar(20) NOT NULL,
  `Passwort` varchar(30) NOT NULL,
  `Geburtstag` date NOT NULL,
  `Straße` varchar(50) NOT NULL,
  `Hausnummer` varchar(10) NOT NULL,
  `PLZ` varchar(5) NOT NULL,
  `Stadt` varchar(30) NOT NULL,
  `Land` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `buchung`
--
ALTER TABLE `buchung`
  ADD PRIMARY KEY (`B_ID`),
  ADD KEY `F_ID_Constraint` (`F_ID`),
  ADD KEY `K_ID_Constraint` (`K_ID`);

--
-- Indizes für die Tabelle `fahrzeug`
--
ALTER TABLE `fahrzeug`
  ADD PRIMARY KEY (`F_ID`),
  ADD KEY `Ft_ID_Constraint` (`Ft_ID`);

--
-- Indizes für die Tabelle `fahrzeugtyp`
--
ALTER TABLE `fahrzeugtyp`
  ADD PRIMARY KEY (`Ft_ID`);

--
-- Indizes für die Tabelle `kunde`
--
ALTER TABLE `kunde`
  ADD PRIMARY KEY (`K_ID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `buchung`
--
ALTER TABLE `buchung`
  MODIFY `B_ID` int(9) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `fahrzeug`
--
ALTER TABLE `fahrzeug`
  MODIFY `F_ID` int(9) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `fahrzeugtyp`
--
ALTER TABLE `fahrzeugtyp`
  MODIFY `Ft_ID` int(9) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `kunde`
--
ALTER TABLE `kunde`
  MODIFY `K_ID` int(9) NOT NULL AUTO_INCREMENT;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `buchung`
--
ALTER TABLE `buchung`
  ADD CONSTRAINT `F_ID_Constraint` FOREIGN KEY (`F_ID`) REFERENCES `fahrzeug` (`F_ID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `K_ID_Constraint` FOREIGN KEY (`K_ID`) REFERENCES `kunde` (`K_ID`) ON UPDATE CASCADE;

--
-- Constraints der Tabelle `fahrzeug`
--
ALTER TABLE `fahrzeug`
  ADD CONSTRAINT `Ft_ID_Constraint` FOREIGN KEY (`Ft_ID`) REFERENCES `fahrzeugtyp` (`Ft_ID`) ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
