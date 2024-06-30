-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: localhost    Database: unit4
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
  `CUST_ID` int DEFAULT NULL,
  `NAME` varchar(20) DEFAULT NULL,
  `OCCUPATION` varchar(20) DEFAULT NULL,
  `AGE` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (101,'PETER','ENGINEER',32),(102,'JOSEPH','DEVELOPER',30),(103,'JHON','HR',23);
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `data1`
--

DROP TABLE IF EXISTS `data1`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `data1` (
  `FIRST_NAME` char(20) NOT NULL,
  `LAST_NAME` char(20) DEFAULT NULL,
  `AGE` int DEFAULT NULL,
  `INCOME` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `data1`
--

LOCK TABLES `data1` WRITE;
/*!40000 ALTER TABLE `data1` DISABLE KEYS */;
INSERT INTO `data1` VALUES ('RAHMAN','ALI',25,6000),('SUDHA','SASTRY',29,9000);
/*!40000 ALTER TABLE `data1` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `data2`
--

DROP TABLE IF EXISTS `data2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `data2` (
  `FIRST_NAME` char(20) NOT NULL,
  `LAST_NAME` char(20) DEFAULT NULL,
  `INCOME` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `data2`
--

LOCK TABLES `data2` WRITE;
/*!40000 ALTER TABLE `data2` DISABLE KEYS */;
INSERT INTO `data2` VALUES ('KRISHNA','SHARMA',9000),('RAJ','KANDUKURI',7000);
/*!40000 ALTER TABLE `data2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `emp`
--

DROP TABLE IF EXISTS `emp`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `emp` (
  `ID` int DEFAULT NULL,
  `FIRST_NAME` char(20) NOT NULL,
  `LAST_NAME` char(20) DEFAULT NULL,
  `AGE` int DEFAULT NULL,
  `SEX` char(10) DEFAULT NULL,
  `INCOME` float DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `emp`
--

LOCK TABLES `emp` WRITE;
/*!40000 ALTER TABLE `emp` DISABLE KEYS */;
INSERT INTO `emp` VALUES (1,'KRISHNA','SHARMA',19,'M',2000),(2,'RAJ','KANDUKURI',20,'M',7000),(3,'RAMYA','RAMAPRIYA',25,'F',6000),(2,'ALEXANDRA','BOTEZ',26,'F',3000);
/*!40000 ALTER TABLE `emp` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `emp2`
--

DROP TABLE IF EXISTS `emp2`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `emp2` (
  `ID` int DEFAULT NULL,
  `FIRST_NAME` char(20) NOT NULL,
  `LAST_NAEM` char(20) DEFAULT NULL,
  `AGE` int DEFAULT NULL,
  `INTCOME` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `emp2`
--

LOCK TABLES `emp2` WRITE;
/*!40000 ALTER TABLE `emp2` DISABLE KEYS */;
INSERT INTO `emp2` VALUES (1,'KRISHNA','SHARMA',19,2000),(2,'RAJ','KANDUKURI',20,7000),(3,'RAHMAN','ALI',25,6000),(4,'SUDHA','SASTRY',29,9000);
/*!40000 ALTER TABLE `emp2` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `ORDER_ID` int DEFAULT NULL,
  `CUST_ID` int DEFAULT NULL,
  `PROD_NAME` varchar(20) DEFAULT NULL,
  `QUANTITY` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,101,'LAPTOP','32'),(2,102,'DESKTOP','30'),(3,103,'TV','23');
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-03-14 15:15:44
