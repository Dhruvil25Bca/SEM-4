-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: unit2
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
-- Table structure for table `bikes`
--

DROP TABLE IF EXISTS `bikes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `bikes` (
  `NAME` varchar(50) DEFAULT NULL,
  `FARMSIZE` double DEFAULT NULL,
  `COMPOSITION` varchar(30) DEFAULT NULL,
  `MILESRIDDEN` decimal(10,0) DEFAULT NULL,
  `TYPE` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `bikes`
--

LOCK TABLES `bikes` WRITE;
/*!40000 ALTER TABLE `bikes` DISABLE KEYS */;
INSERT INTO `bikes` VALUES ('TREK2300',22.5,'CARBON FIBER',3500,'RACING'),('BURLEY',22,'STEEL',2000,'TANDEM'),('GIANT',19,'STEEL',1500,'COMMUTER'),('FUJI',20,'STEEL',500,'TOURING'),('SPECIALIZED',16,'STEEL',100,'MOUNTAIN'),('CANNONDALE',22.5,'ALUMINUM',3000,'RACING');
/*!40000 ALTER TABLE `bikes` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `checks`
--

DROP TABLE IF EXISTS `checks`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `checks` (
  `checkno` decimal(10,0) DEFAULT NULL,
  `payee` varchar(45) DEFAULT NULL,
  `amount` double DEFAULT NULL,
  `remarks` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `checks`
--

LOCK TABLES `checks` WRITE;
/*!40000 ALTER TABLE `checks` DISABLE KEYS */;
INSERT INTO `checks` VALUES (1,'TTC',150,'TEXTILE TRADERS'),(2,'READING R.R.',245.34,'READER A/C'),(3,'BELL',200.32,'CELLULAR PHONE CO.'),(4,'LOCAL UTILITIES',98,'GAS'),(5,'JOES STALE $ DENT',150,'GROCERIES'),(6,'CASH',25,'WILD NIGHT OUT'),(7,'JAMES GAS',25.1,'GAS');
/*!40000 ALTER TABLE `checks` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `friends`
--

DROP TABLE IF EXISTS `friends`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `friends` (
  `LASTNAME` varchar(20) DEFAULT NULL,
  `FIRSTNAME` varchar(20) DEFAULT NULL,
  `AREACODE` decimal(5,0) DEFAULT NULL,
  `PHONE` varchar(30) DEFAULT NULL,
  `ST` varchar(4) DEFAULT NULL,
  `ZIP` decimal(10,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `friends`
--

LOCK TABLES `friends` WRITE;
/*!40000 ALTER TABLE `friends` DISABLE KEYS */;
INSERT INTO `friends` VALUES ('BUNDY','AL',100,'555-1111','IL',22333),('MEZA','AL',200,'555-2222','UK',NULL),('MERRICK','BUD',300,'555-6666','CO',80212),('MAST','JD',381,'555-6767','LA',23456),('BULHER','FERRIS',345,'555-3223','IL',23332);
/*!40000 ALTER TABLE `friends` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `parts`
--

DROP TABLE IF EXISTS `parts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `parts` (
  `NAME` varchar(30) DEFAULT NULL,
  `LOCATION` varchar(40) DEFAULT NULL,
  `PARTNUMBER` decimal(4,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `parts`
--

LOCK TABLES `parts` WRITE;
/*!40000 ALTER TABLE `parts` DISABLE KEYS */;
INSERT INTO `parts` VALUES ('APPENDIX','MID-STOMACH',1),('ADAMS APPLE','THROAT',2),('HEART','CHEST',3),('SPINE','BACK',4),('ANVIL','EAR',5),('KIDNEY','MID-BACK',6);
/*!40000 ALTER TABLE `parts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `price`
--

DROP TABLE IF EXISTS `price`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `price` (
  `ITEM` varchar(50) DEFAULT NULL,
  `WHOLESALE` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `price`
--

LOCK TABLES `price` WRITE;
/*!40000 ALTER TABLE `price` DISABLE KEYS */;
INSERT INTO `price` VALUES ('TOMATOES','0.34'),('POTATOES','0.51'),('BANANAS','0.67'),('TURNIPS','0.45'),('CHEESE','0.89'),('APPLES','0.23');
/*!40000 ALTER TABLE `price` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vacation`
--

DROP TABLE IF EXISTS `vacation`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vacation` (
  `LASTNAME` varchar(30) DEFAULT NULL,
  `EMPLOYEENUM` decimal(5,0) DEFAULT NULL,
  `YEARS` decimal(5,0) DEFAULT NULL,
  `LEAVETAKEN` decimal(5,0) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vacation`
--

LOCK TABLES `vacation` WRITE;
/*!40000 ALTER TABLE `vacation` DISABLE KEYS */;
INSERT INTO `vacation` VALUES ('ABLE',101,2,4),('BAKER',104,5,23),('BLEDSOE',107,8,45),('BOLIVAR',233,4,80),('BOLD',210,15,100),('COSTALES',211,10,78);
/*!40000 ALTER TABLE `vacation` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-01-31 14:10:34
