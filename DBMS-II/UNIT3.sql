-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: unit3
-- ------------------------------------------------------
-- Server version	8.0.36

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `NAME` varchar(50) DEFAULT NULL,
  `ADDRESS` varchar(50) DEFAULT NULL,
  `STATE` varchar(30) DEFAULT NULL,
  `ZIP` decimal(10,0) DEFAULT NULL,
  `PHONE` varchar(30) DEFAULT NULL,
  `REMARKS` varchar(25) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES ('TRUE WHEEL','550 HUSKER','NE',58702,'555-4545','NONE'),('BIKE SPEC','CPT SHRIVE','LA',45678,'555-1234','NONE'),('LE SHOPPE','HOMETOWN','KS',54678,'555-1278','NONE'),('AAA BIKE','10 OLDTOWN','NE',56784,'555-3421','JOHN-MGR'),('JACKS BIKE','24 EGLIN','FL',34567,'555-2314','NONE');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `football`
--

DROP TABLE IF EXISTS `football`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `football` (
  `NAME` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `football`
--

LOCK TABLES `football` WRITE;
/*!40000 ALTER TABLE `football` DISABLE KEYS */;
INSERT INTO `football` VALUES ('ABLE'),('BRAVO'),('CHARLIE'),('DECON'),('EXITOR'),('FUBAR'),('GOOBER');
/*!40000 ALTER TABLE `football` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `ORDEREDON` date DEFAULT NULL,
  `NAME` varchar(30) DEFAULT NULL,
  `PARTNUM` decimal(2,0) DEFAULT NULL,
  `QUANTITY` decimal(4,0) DEFAULT NULL,
  `REMARKS` varchar(30) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES ('1996-05-15','TRUE WHEEL',23,6,'PAID'),('1996-05-19','TRUE WHEEL',76,3,'PAID'),('1996-09-02','TRUE WHEEL',10,1,'PAID'),('1996-06-30','TRUE WHEEL',42,8,'PAID'),('1996-06-30','BIKE SPEC',54,10,'PAID'),('1996-05-30','BIKE SPEC',10,2,'PAID'),('1996-05-30','BIKE SPEC',23,8,'PAID'),('1996-01-17','BIKE SPEC',76,11,'PAID'),('1996-01-17','LE SHOPPE',76,5,'PAID'),('1996-06-01','LE SHOPPE',10,3,'PAID'),('1996-07-01','AAA BIKE',10,1,'PAID'),('1996-07-01','AAA BIKE',76,4,'PAID'),('1996-07-01','AAA BIKE',46,14,'PAID'),('1996-07-11','JACKS BIKE',76,14,'PAID');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `part`
--

DROP TABLE IF EXISTS `part`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `part` (
  `PARTNUM` decimal(2,0) DEFAULT NULL,
  `DESCRIPTION` varchar(30) DEFAULT NULL,
  `PRICE` double DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `part`
--

LOCK TABLES `part` WRITE;
/*!40000 ALTER TABLE `part` DISABLE KEYS */;
INSERT INTO `part` VALUES (54,'PEDALS',54.25),(42,'SEATS',24.5),(46,'TRIES',15.25),(23,'MOUNTAIN BIKE',530),(10,'TANDEM',1200),(76,'CLIPPLESS SHOE',65);
/*!40000 ALTER TABLE `part` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `softball`
--

DROP TABLE IF EXISTS `softball`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `softball` (
  `NAME` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `softball`
--

LOCK TABLES `softball` WRITE;
/*!40000 ALTER TABLE `softball` DISABLE KEYS */;
INSERT INTO `softball` VALUES ('ABLE'),('BAKER'),('CHARLIE'),('DEAN'),('EXITOR'),('FALCONER'),('GOOBER');
/*!40000 ALTER TABLE `softball` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `teamstats`
--

DROP TABLE IF EXISTS `teamstats`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `teamstats` (
  `NAME` varchar(50) DEFAULT NULL,
  `POS` varchar(10) DEFAULT NULL,
  `AB` decimal(10,0) DEFAULT NULL,
  `HITS` decimal(10,0) DEFAULT NULL,
  `WALKS` decimal(10,0) DEFAULT NULL,
  `SINGLES` decimal(10,0) DEFAULT NULL,
  `DOUBLES` decimal(10,0) DEFAULT NULL,
  `TRIPLES` decimal(10,0) DEFAULT NULL,
  `HR` decimal(10,0) DEFAULT NULL,
  `SO` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `teamstats`
--

LOCK TABLES `teamstats` WRITE;
/*!40000 ALTER TABLE `teamstats` DISABLE KEYS */;
INSERT INTO `teamstats` VALUES ('JONES','1B',145,45,34,31,8,1,5,10),('DONKNOW','3B',175,65,23,50,10,1,4,15),('WORLEY','LF',157,49,15,35,8,3,3,16),('DAVID','OF',187,70,24,48,4,0,17,42),('HAMHOCKER','3B',50,12,10,10,2,0,0,13),('CASEY','DH',1,0,0,0,0,0,0,1);
/*!40000 ALTER TABLE `teamstats` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-02-06 15:24:07
