-- --------------------------------------------------------
-- Host:                         127.0.0.1
-- Server version:               5.6.17 - MySQL Community Server (GPL)
-- Server OS:                    Win64
-- HeidiSQL Version:             8.3.0.4694
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

-- Dumping database structure for tempestauth
CREATE DATABASE IF NOT EXISTS `tempestauth` /*!40100 DEFAULT CHARACTER SET latin1 */;
USE `tempestauth`;


-- Dumping structure for table tempestauth.accounts
CREATE TABLE IF NOT EXISTS `accounts` (
  `ID` bigint(20) unsigned NOT NULL AUTO_INCREMENT,
  `Username` varchar(12) COLLATE utf8_bin NOT NULL DEFAULT '',
  `Nickname` varchar(12) COLLATE utf8_bin NOT NULL DEFAULT '',
  `Password` varchar(90) COLLATE utf8_bin NOT NULL DEFAULT '',
  `Banned` bigint(20) unsigned NOT NULL DEFAULT '0',
  `BanReason` varchar(1024) COLLATE utf8_bin NOT NULL DEFAULT '',
  `GMLevel` tinyint(3) unsigned NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `Username` (`Username`),
  UNIQUE KEY `ID` (`ID`),
  UNIQUE KEY `Nickname` (`Nickname`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- Dumping data for table tempestauth.accounts: ~1 rows (approximately)
/*!40000 ALTER TABLE `accounts` DISABLE KEYS */;
INSERT IGNORE INTO `accounts` (`ID`, `Username`, `Nickname`, `Password`, `Banned`, `BanReason`, `GMLevel`) VALUES
	(1, 'admin', 'admin', '8c6976e5b5410415bde908bd4dee15dfb167a9c873fc4bb8a81f6f2ab448a918', 0, '', 6);
/*!40000 ALTER TABLE `accounts` ENABLE KEYS */;


-- Dumping structure for table tempestauth.server
CREATE TABLE IF NOT EXISTS `server` (
  `UID` int(11) unsigned NOT NULL AUTO_INCREMENT,
  `ID` smallint(5) unsigned NOT NULL DEFAULT '1',
  `Type` tinyint(1) unsigned NOT NULL DEFAULT '1',
  `Name` varchar(39) COLLATE utf8_bin NOT NULL,
  `PlayerLimit` smallint(5) unsigned NOT NULL DEFAULT '0',
  `IP` varchar(16) COLLATE utf8_bin NOT NULL DEFAULT '127.0.0.1',
  `Port` smallint(5) unsigned NOT NULL DEFAULT '28008',
  PRIMARY KEY (`UID`),
  UNIQUE KEY `UID` (`UID`)
) ENGINE=InnoDB AUTO_INCREMENT=36 DEFAULT CHARSET=utf8 COLLATE=utf8_bin;

-- Dumping data for table tempestauth.server: ~4 rows (approximately)
/*!40000 ALTER TABLE `server` DISABLE KEYS */;
INSERT IGNORE INTO `server` (`UID`, `ID`, `Type`, `Name`, `PlayerLimit`, `IP`, `Port`) VALUES
	(32, 1, 1, 'FagNet', 1000, '127.0.0.1', 28008),
	(33, 1, 2, 'FagNetChat', 1000, '127.0.0.1', 28012),
	(34, 1, 4, 'FagNetRelay', 1000, '127.0.0.1', 28013),
	(35, 1, 3, 'FagNetNAT', 1000, '127.0.0.1', 38915);
/*!40000 ALTER TABLE `server` ENABLE KEYS */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IF(@OLD_FOREIGN_KEY_CHECKS IS NULL, 1, @OLD_FOREIGN_KEY_CHECKS) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
