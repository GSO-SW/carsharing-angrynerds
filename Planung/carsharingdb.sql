-- phpMyAdmin SQL Dump
-- version 4.8.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 25. Okt 2018 um 00:20
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
  `Kennzeichen` varchar(50) NOT NULL,
  `E-Mail Adresse` varchar(50) NOT NULL,
  `Startzeitpunkt` datetime(6) NOT NULL,
  `Endzeitpunkt` datetime(6) DEFAULT NULL,
  `Startkilometerstand` double(10,2) NOT NULL,
  `Endkilometerstand` double(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fahrzeug`
--

CREATE TABLE `fahrzeug` (
  `Kennzeichen` varchar(50) NOT NULL,
  `Ft_ID` int(9) NOT NULL,
  `Kilometerstand` double(10,2) NOT NULL,
  `Letzte Wartung` date NOT NULL,
  `Tankfuellung` double(10,2) NOT NULL,
  `Standort` varchar(10) NOT NULL,
  `Verfuegbarkeit` tinyint(1) NOT NULL,
  `Erstzulassung` date NOT NULL,
  `Kraftstoffverbrauch` double(4,2) NOT NULL,
  `Klimaanlage` tinyint(1) NOT NULL,
  `Tempomat` tinyint(1) NOT NULL,
  `Radio` tinyint(1) NOT NULL,
  `Bluetooth` tinyint(1) NOT NULL,
  `USB` tinyint(1) NOT NULL,
  `CD-Spieler` tinyint(1) NOT NULL,
  `Navigationsgeraet` tinyint(1) NOT NULL,
  `ABS` tinyint(1) NOT NULL,
  `ESP` tinyint(1) NOT NULL,
  `Sitzheizung` tinyint(1) NOT NULL,
  `Winterreifen` tinyint(1) NOT NULL,
  `Raucher` tinyint(1) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fahrzeuggetriebe`
--

CREATE TABLE `fahrzeuggetriebe` (
  `Fg_ID` int(9) NOT NULL,
  `Getriebeart` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `fahrzeuggetriebe`
--

INSERT INTO `fahrzeuggetriebe` (`Fg_ID`, `Getriebeart`) VALUES
(2, 'Automatik'),
(4, 'Automatisiertes Schaltgetriebe'),
(6, 'CVT-Getriebe'),
(5, 'Direktschaltgetriebe (DSG)'),
(3, 'eClutch System'),
(1, 'Handschaltung');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fahrzeugmarke`
--

CREATE TABLE `fahrzeugmarke` (
  `Fm_ID` int(9) NOT NULL,
  `Marke` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `fahrzeugmarke`
--

INSERT INTO `fahrzeugmarke` (`Fm_ID`, `Marke`) VALUES
(1, 'Abarth'),
(2, 'AC'),
(3, 'Acura'),
(4, 'Aixam'),
(5, 'Alfa Romeo'),
(6, 'ALPINA'),
(114, 'Andere'),
(7, 'Artega'),
(8, 'Asia Motors'),
(9, 'Aston Martin'),
(10, 'Audi'),
(11, 'Austin'),
(12, 'Austin Healey'),
(13, 'Bentley'),
(14, 'BMW'),
(15, 'Borgward'),
(16, 'Brilliance'),
(17, 'Bugatti'),
(18, 'Buick'),
(19, 'Cadillac'),
(20, 'Casalini'),
(21, 'Caterham'),
(22, 'Chatenet'),
(23, 'Chevrolet'),
(24, 'Chrysler'),
(25, 'Citroën'),
(26, 'Cobra'),
(27, 'Corvette'),
(28, 'Dacia'),
(29, 'Daewoo'),
(30, 'Daihatsu'),
(31, 'DeTomaso'),
(32, 'Dodge'),
(33, 'Donkervoort'),
(34, 'DS Automobiles'),
(35, 'Ferrari'),
(36, 'Fiat'),
(37, 'Fisker'),
(38, 'Ford'),
(39, 'GAC Gonow'),
(40, 'Gemballa'),
(41, 'GMC'),
(42, 'Grecav'),
(43, 'Hamann'),
(44, 'Holden'),
(45, 'Honda'),
(46, 'Hummer'),
(47, 'Hyundai'),
(48, 'Infiniti'),
(49, 'Isuzu'),
(50, 'Iveco'),
(51, 'Jaguar'),
(52, 'Jeep'),
(53, 'Kia'),
(54, 'Koenigsegg'),
(55, 'KTM'),
(56, 'Lada'),
(57, 'Lamborghini'),
(58, 'Lancia'),
(59, 'Land Rover'),
(60, 'Landwind'),
(61, 'Lexus'),
(62, 'Ligier'),
(63, 'Lincoln'),
(64, 'Lotus'),
(65, 'Mahindra'),
(66, 'Maserati'),
(67, 'Maybach'),
(68, 'Mazda'),
(69, 'McLaren'),
(70, 'Mercedes-Benz'),
(71, 'MG'),
(72, 'Microcar'),
(73, 'MINI'),
(74, 'Mitsubishi'),
(75, 'Morgan'),
(76, 'Nissan'),
(77, 'NSU'),
(78, 'Oldsmobile'),
(79, 'Opel'),
(80, 'Pagani'),
(81, 'Peugeot'),
(82, 'Piaggio'),
(83, 'Plymouth'),
(84, 'Pontiac'),
(85, 'Porsche'),
(86, 'Proton'),
(87, 'Renault'),
(88, 'Rolls-Royce'),
(89, 'Rover'),
(90, 'Ruf'),
(91, 'Saab'),
(92, 'Santana'),
(93, 'Seat'),
(94, 'Skoda'),
(95, 'Smart'),
(96, 'speedART'),
(97, 'Spyker'),
(98, 'Ssangyong'),
(99, 'Subaru'),
(100, 'Suzuki'),
(101, 'Talbot'),
(102, 'Tata'),
(103, 'TECHART'),
(104, 'Tesla'),
(105, 'Toyota'),
(106, 'Trabant'),
(107, 'Triumph'),
(108, 'TVR'),
(109, 'Volkswagen'),
(110, 'Volvo'),
(111, 'Wartburg'),
(112, 'Westfield'),
(113, 'Wiesmann');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `fahrzeugtyp`
--

CREATE TABLE `fahrzeugtyp` (
  `Ft_ID` int(9) NOT NULL,
  `Fm_ID` int(9) NOT NULL,
  `Modell` varchar(50) NOT NULL,
  `Leistung` int(9) NOT NULL,
  `Baujahr` year(4) NOT NULL,
  `Fg_ID` int(9) NOT NULL,
  `Max_Tankvolumen` double(10,2) NOT NULL,
  `Grundpreis` double(10,2) NOT NULL,
  `Preis/km` double(10,2) NOT NULL,
  `Preis/min` double(10,2) NOT NULL,
  `Ks_ID` int(4) NOT NULL,
  `Anzahl der Sitze` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kraftstoffart`
--

CREATE TABLE `kraftstoffart` (
  `Ks_ID` int(4) NOT NULL,
  `Kraftstoffart` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `kraftstoffart`
--

INSERT INTO `kraftstoffart` (`Ks_ID`, `Kraftstoffart`) VALUES
(1, 'Diesel'),
(2, 'Benzin 98 bleifrei'),
(3, 'Benzin 95 bleifrei'),
(4, 'Elektroantrieb'),
(5, 'Autogas/LPG'),
(6, 'Diesel / Elektro (Hybrid)'),
(7, 'Benzin bleifrei / Elektro (Hybrid)'),
(8, 'Super bleifrei / Elektro (Hybrid)'),
(9, 'Andere');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `kunde`
--

CREATE TABLE `kunde` (
  `E-Mail Adresse` varchar(50) NOT NULL,
  `Vorname` varchar(40) NOT NULL,
  `Nachname` varchar(40) NOT NULL,
  `Telefonnummer` varchar(20) NOT NULL,
  `Passwort` varchar(30) NOT NULL,
  `admin` tinyint(1) NOT NULL,
  `Geburtstag` date NOT NULL,
  `Strasse` varchar(50) NOT NULL,
  `Hausnummer` varchar(10) NOT NULL,
  `PLZ` varchar(5) NOT NULL,
  `Stadt` varchar(30) NOT NULL,
  `Land` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Daten für Tabelle `kunde`
--

INSERT INTO `kunde` (`E-Mail Adresse`, `Vorname`, `Nachname`, `Telefonnummer`, `Passwort`, `admin`, `Geburtstag`, `Strasse`, `Hausnummer`, `PLZ`, `Stadt`, `Land`) VALUES
('admin@system.de', 'admin', 'admin', '0123456789', 'admin', 1, '2000-01-01', 'Musterstraße', '1', '12345', 'Musterstadt', 'Deutschland');

--
-- Indizes für die Tabelle `buchung`
--
ALTER TABLE `buchung`
  ADD PRIMARY KEY (`B_ID`),
  ADD KEY `Kennzeichen_Constraint` (`Kennzeichen`),
  ADD KEY `E-Mail Adresse_Constraint` (`E-Mail Adresse`);

--
-- Indizes für die Tabelle `fahrzeug`
--
ALTER TABLE `fahrzeug`
  ADD PRIMARY KEY (`Kennzeichen`),
  ADD KEY `Ft_ID_Constraint` (`Ft_ID`);

--
-- Indizes für die Tabelle `fahrzeuggetriebe`
--
ALTER TABLE `fahrzeuggetriebe`
  ADD PRIMARY KEY (`Fg_ID`),
  ADD UNIQUE KEY `Getriebeart` (`Getriebeart`);

--
-- Indizes für die Tabelle `fahrzeugmarke`
--
ALTER TABLE `fahrzeugmarke`
  ADD PRIMARY KEY (`Fm_ID`),
  ADD UNIQUE KEY `Marke` (`Marke`);

--
-- Indizes für die Tabelle `fahrzeugtyp`
--
ALTER TABLE `fahrzeugtyp`
  ADD PRIMARY KEY (`Ft_ID`),
  ADD KEY `Fg_ID` (`Fg_ID`),
  ADD KEY `Fm_ID_Constraint` (`Fm_ID`),
  ADD KEY `Ks_ID_Constraint` (`Ks_ID`);

--
-- Indizes für die Tabelle `kraftstoffart`
--
ALTER TABLE `kraftstoffart`
  ADD PRIMARY KEY (`Ks_ID`);

--
-- Indizes für die Tabelle `kunde`
--
ALTER TABLE `kunde`
  ADD PRIMARY KEY (`E-Mail Adresse`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `buchung`
--
ALTER TABLE `buchung`
  MODIFY `B_ID` int(9) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `fahrzeugtyp`
--
ALTER TABLE `fahrzeugtyp`
  MODIFY `Ft_ID` int(9) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `buchung`
--
ALTER TABLE `buchung`
  ADD CONSTRAINT `E-Mail Adresse_Constraint` FOREIGN KEY (`E-Mail Adresse`) REFERENCES `kunde` (`E-Mail Adresse`) ON UPDATE CASCADE,
  ADD CONSTRAINT `Kennzeichen_Constraint` FOREIGN KEY (`Kennzeichen`) REFERENCES `fahrzeug` (`Kennzeichen`) ON UPDATE CASCADE;

--
-- Constraints der Tabelle `fahrzeug`
--
ALTER TABLE `fahrzeug`
  ADD CONSTRAINT `Ft_ID_Constraint` FOREIGN KEY (`Ft_ID`) REFERENCES `fahrzeugtyp` (`Ft_ID`) ON UPDATE CASCADE;

--
-- Constraints der Tabelle `fahrzeugtyp`
--
ALTER TABLE `fahrzeugtyp`
  ADD CONSTRAINT `Fg_ID_Constraint` FOREIGN KEY (`Fg_ID`) REFERENCES `fahrzeuggetriebe` (`Fg_ID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `Fm_ID_Constraint` FOREIGN KEY (`Fm_ID`) REFERENCES `fahrzeugmarke` (`Fm_ID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `Ks_ID_Constraint` FOREIGN KEY (`Ks_ID`) REFERENCES `kraftstoffart` (`Ks_ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
