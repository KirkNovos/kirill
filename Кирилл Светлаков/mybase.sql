-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ksvetlakov
-- ------------------------------------------------------
-- Server version	8.0.26

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
-- Table structure for table `agent`
--

DROP TABLE IF EXISTS `agent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `agent` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `AgentTypeID` int NOT NULL,
  `Address` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `INN` varchar(12) NOT NULL,
  `KPP` varchar(9) DEFAULT NULL,
  `DirectorName` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Phone` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Email` varchar(255) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Logo` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `Priority` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Agent_AgentType` (`AgentTypeID`),
  CONSTRAINT `FK_Agent_AgentType` FOREIGN KEY (`AgentTypeID`) REFERENCES `agenttype` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agent`
--

LOCK TABLES `agent` WRITE;
/*!40000 ALTER TABLE `agent` DISABLE KEYS */;
/*!40000 ALTER TABLE `agent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `agentpriorityhistory`
--

DROP TABLE IF EXISTS `agentpriorityhistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `agentpriorityhistory` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `AgentID` int NOT NULL,
  `ChangeDate` datetime(6) NOT NULL,
  `PriorityValue` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_AgentPriorityHistory_Agent` (`AgentID`),
  CONSTRAINT `FK_AgentPriorityHistory_Agent` FOREIGN KEY (`AgentID`) REFERENCES `agent` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agentpriorityhistory`
--

LOCK TABLES `agentpriorityhistory` WRITE;
/*!40000 ALTER TABLE `agentpriorityhistory` DISABLE KEYS */;
/*!40000 ALTER TABLE `agentpriorityhistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `agenttype`
--

DROP TABLE IF EXISTS `agenttype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `agenttype` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Image` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `agenttype`
--

LOCK TABLES `agenttype` WRITE;
/*!40000 ALTER TABLE `agenttype` DISABLE KEYS */;
/*!40000 ALTER TABLE `agenttype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `material`
--

DROP TABLE IF EXISTS `material`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `material` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CountInPack` int NOT NULL,
  `Unit` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `CountInStock` double DEFAULT NULL,
  `MinCount` double NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Cost` decimal(10,2) NOT NULL,
  `Image` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `MaterialTypeID` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Material_MaterialType` (`MaterialTypeID`),
  CONSTRAINT `FK_Material_MaterialType` FOREIGN KEY (`MaterialTypeID`) REFERENCES `materialtype` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `material`
--

LOCK TABLES `material` WRITE;
/*!40000 ALTER TABLE `material` DISABLE KEYS */;
/*!40000 ALTER TABLE `material` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materialcounthistory`
--

DROP TABLE IF EXISTS `materialcounthistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materialcounthistory` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `MaterialID` int NOT NULL,
  `ChangeDate` datetime(6) NOT NULL,
  `CountValue` double NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_MaterialCountHistory_Material` (`MaterialID`),
  CONSTRAINT `FK_MaterialCountHistory_Material` FOREIGN KEY (`MaterialID`) REFERENCES `material` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materialcounthistory`
--

LOCK TABLES `materialcounthistory` WRITE;
/*!40000 ALTER TABLE `materialcounthistory` DISABLE KEYS */;
/*!40000 ALTER TABLE `materialcounthistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materials_short_k_import`
--

DROP TABLE IF EXISTS `materials_short_k_import`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materials_short_k_import` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Material` text,
  `Typematerial` text,
  `Count` int DEFAULT NULL,
  `Unit` text,
  `Countsklad` int DEFAULT NULL,
  `Min` int DEFAULT NULL,
  `Price` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=51 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materials_short_k_import`
--

LOCK TABLES `materials_short_k_import` WRITE;
/*!40000 ALTER TABLE `materials_short_k_import` DISABLE KEYS */;
INSERT INTO `materials_short_k_import` VALUES (1,'Шипы для льда 3x2','Шипы',3,'г',470,26,'6511.00 ?'),(2,'Резина для льда 0x2','Резина',2,'кг',816,21,'48785'),(3,'Шипы для льда 2x2','Шипы',1,'г',479,22,'13077.00'),(4,'Шипы для льда 3x0','Шипы',9,'г',885,5,'52272 руб.'),(5,'Шипы для пустыни 3x2','Шипы',2,'г',923,19,'28748 рублей'),(6,'Шипы для лета 3x1','Шипы',6,'кг',184,40,'51974'),(7,'Резина для зимы 2x3','Резина',3,'м',344,12,'53323'),(8,'Резина для зимы 3x3','Резина',2,'кг',275,28,'31356.00'),(9,'Шипы для льда 1x0','Шипы',10,'г',914,22,'25538'),(10,'Резина для лета 0x1','Резина',9,'кг',127,17,'23936 руб.'),(11,'Резина для лета 2x2','Резина',2,'м',542,20,'54298.00 ?'),(12,'Резина для зимы 3x1','Резина',9,'кг',690,24,'25844'),(13,'Шипы для зимы 0x1','Шипы',3,'г',255,25,'6484 рублей'),(14,'Шипы для льда 2x0','Шипы',4,'шт',214,15,'17996.00'),(15,'Резина для пустыни 3x2','Резина',1,'м',931,43,'5854.00 ?'),(16,'Шипы для зимы 3x0','Шипы',6,'г',192,48,'9260.00 ?'),(17,'Резина для пустыни 2x0','Резина',5,'кг',769,14,'17425.00'),(18,'Шипы для лета 3x2','Шипы',1,'г',547,11,'43288 рублей'),(19,'Резина для зимы 0x3','Резина',4,'м',726,46,'37293 руб.'),(20,'Шипы для льда 0x0','Шипы',2,'кг',585,37,'21188.00'),(21,'Шипы для льда 0x1','Шипы',2,'шт',147,8,'49557.00 ?'),(22,'Резина для льда 1x3','Резина',2,'кг',286,39,'23551.00 ?'),(23,'Резина для пустыни 1x3','Резина',5,'кг',222,9,'21546 рублей'),(24,'Шипы для зимы 3x3','Шипы',4,'г',652,33,'15159.00'),(25,'Шипы для пустыни 0x2','Шипы',4,'г',792,46,'8571 рублей'),(26,'Шипы для лета 2x0','Шипы',1,'г',68,43,'8206.00'),(27,'Резина для пустыни 3x3','Резина',9,'м',840,11,'5144.00 ?'),(28,'Резина для льда 0x1','Резина',5,'м',964,34,'53394.00 ?'),(29,'Резина для лета 0x2','Резина',4,'кг',753,33,'9069'),(30,'Резина для зимы 1x0','Резина',5,'кг',929,48,'43046.00 ?'),(31,'Резина для лета 3x3','Резина',6,'м',652,28,'6764.00'),(32,'Резина для пустыни 1x1','Резина',6,'кг',120,21,'11642'),(33,'Шипы для пустыни 0x1','Шипы',4,'шт',612,24,'55689.00'),(34,'Шипы для льда 3x1','Шипы',8,'г',123,43,'42668.00 ?'),(35,'Резина для льда 3x3','Резина',7,'кг',909,35,'23174'),(36,'Шипы для льда 2x3','Шипы',10,'шт',237,7,'27105.00'),(37,'Шипы для лета 2x2','Шипы',4,'г',15,10,'44506'),(38,'Резина для пустыни 2x3','Резина',5,'м',103,38,'55679.00 ?'),(39,'Резина для зимы 1x3','Резина',9,'м',84,50,'27823 рублей'),(40,'Резина для лета 1x0','Резина',5,'м',234,32,'25499 рублей'),(41,'Резина для пустыни 0x3','Резина',8,'м',761,7,'8094.00'),(42,'Резина для лета 2x1','Резина',2,'м',561,39,'47610 рублей'),(43,'Резина для пустыни 2x1','Резина',10,'кг',918,12,'34518.00 ?'),(44,'Шипы для пустыни 3x1','Шипы',4,'г',37,43,'27104 рублей'),(45,'Шипы для льда 1x1','Шипы',7,'г',335,33,'48279'),(46,'Шипы для зимы 2x0','Шипы',3,'шт',466,8,'34841 рублей'),(47,'Резина для пустыни 1x2','Резина',9,'кг',496,36,'24876 рублей'),(48,'Резина для льда 2x0','Резина',6,'м',86,8,'24767.00'),(49,'Шипы для лета 0x1','Шипы',2,'кг',974,35,'28825.00'),(50,'Шипы для льда 2x1','Шипы',10,'шт',634,25,'23287 рублей');
/*!40000 ALTER TABLE `materials_short_k_import` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materialsupplier`
--

DROP TABLE IF EXISTS `materialsupplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materialsupplier` (
  `MaterialID` int NOT NULL,
  `SupplierID` int NOT NULL,
  PRIMARY KEY (`MaterialID`,`SupplierID`),
  KEY `FK_MaterialSupplier_Supplier` (`SupplierID`),
  CONSTRAINT `FK_MaterialSupplier_Material` FOREIGN KEY (`MaterialID`) REFERENCES `material` (`ID`),
  CONSTRAINT `FK_MaterialSupplier_Supplier` FOREIGN KEY (`SupplierID`) REFERENCES `supplier` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materialsupplier`
--

LOCK TABLES `materialsupplier` WRITE;
/*!40000 ALTER TABLE `materialsupplier` DISABLE KEYS */;
/*!40000 ALTER TABLE `materialsupplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `materialtype`
--

DROP TABLE IF EXISTS `materialtype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `materialtype` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DefectedPercent` double NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `materialtype`
--

LOCK TABLES `materialtype` WRITE;
/*!40000 ALTER TABLE `materialtype` DISABLE KEYS */;
/*!40000 ALTER TABLE `materialtype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `ProductTypeID` int DEFAULT NULL,
  `ArticleNumber` varchar(10) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Description` longtext CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci,
  `Image` varchar(100) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `ProductionPersonCount` int DEFAULT NULL,
  `ProductionWorkshopNumber` int DEFAULT NULL,
  `MinCostForAgent` decimal(10,2) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Product_ProductType` (`ProductTypeID`),
  CONSTRAINT `FK_Product_ProductType` FOREIGN KEY (`ProductTypeID`) REFERENCES `producttype` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productcosthistory`
--

DROP TABLE IF EXISTS `productcosthistory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productcosthistory` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `ProductID` int NOT NULL,
  `ChangeDate` datetime(6) NOT NULL,
  `CostValue` decimal(10,2) NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_ProductCostHistory_Product` (`ProductID`),
  CONSTRAINT `FK_ProductCostHistory_Product` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productcosthistory`
--

LOCK TABLES `productcosthistory` WRITE;
/*!40000 ALTER TABLE `productcosthistory` DISABLE KEYS */;
/*!40000 ALTER TABLE `productcosthistory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productmaterial`
--

DROP TABLE IF EXISTS `productmaterial`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productmaterial` (
  `ProductID` int NOT NULL,
  `MaterialID` int NOT NULL,
  `Count` double DEFAULT NULL,
  PRIMARY KEY (`ProductID`,`MaterialID`),
  KEY `FK_ProductMaterial_Material` (`MaterialID`),
  CONSTRAINT `FK_ProductMaterial_Material` FOREIGN KEY (`MaterialID`) REFERENCES `material` (`ID`),
  CONSTRAINT `FK_ProductMaterial_Product` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productmaterial`
--

LOCK TABLES `productmaterial` WRITE;
/*!40000 ALTER TABLE `productmaterial` DISABLE KEYS */;
/*!40000 ALTER TABLE `productmaterial` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productmaterial_k_import`
--

DROP TABLE IF EXISTS `productmaterial_k_import`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productmaterial_k_import` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Product` text,
  `Material` text,
  `Countmaterial` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productmaterial_k_import`
--

LOCK TABLES `productmaterial_k_import` WRITE;
/*!40000 ALTER TABLE `productmaterial_k_import` DISABLE KEYS */;
INSERT INTO `productmaterial_k_import` VALUES (1,'Колесо R18 Кованый','Шипы для лета 3x2',16),(2,'Шина R21 Липучка','Шипы для лета 2x0',16),(3,'Запаска R18 Лето','Шипы для лета 3x2',13),(4,'Шина R14 Липучка','Шипы для лета 2x0',9),(5,'Запаска R14 Лето','Резина для пустыни 3x2',7),(6,'Шина R21 Зима','Резина для пустыни 3x2',3),(7,'Шина R19 Липучка','Резина для пустыни 3x2',13),(8,'Запаска R17 Липучка','Шипы для лета 2x0',9),(9,'Запаска R19 Лето','Шипы для льда 2x2',11),(10,'Запаска R22 Липучка','Шипы для лета 2x0',8),(11,'Колесо R18 Липучка','Шипы для лета 0x1',12),(12,'Колесо R18 Кованый','Резина для лета 2x2',8),(13,'Шина R21 Липучка','Шипы для лета 0x1',13),(14,'Запаска R14 Кованый','Шипы для льда 0x0',1),(15,'Диск R22 Липучка','Резина для льда 0x2',14),(16,'Шина R14 Липучка','Резина для зимы 3x3',3),(17,'Колесо R19 Липучка','Шипы для пустыни 3x2',5),(18,'Запаска R16 Зима','Резина для лета 2x1',4),(19,'Шина R14 Липучка','Шипы для лета 0x1',10),(20,'Шина R21 Зима','Шипы для льда 0x1',4),(21,'Диск R16 Кованый','Шипы для пустыни 3x2',16),(22,'Шина R14 Кованый','Шипы для льда 0x1',14),(23,'Колесо R20 Лето','Резина для льда 1x3',14),(24,'Колесо R18 Липучка','Резина для зимы 3x3',5),(25,'Колесо R17 Лето','Шипы для льда 0x0',4),(26,'Колесо R17 Лето','Резина для лета 2x2',3),(27,'Колесо R17 Лето','Резина для льда 0x2',5),(28,'Колесо R18 Лето','Резина для лета 2x2',4),(29,'Колесо R18 Лето','Резина для лета 2x1',10),(30,'Шина R14 Кованый','Резина для зимы 2x3',9),(31,'Запаска R18 Лето','Шипы для зимы 0x1',13),(32,'Запаска R14 Кованый','Шипы для льда 3x2',9),(33,'Запаска R14 Кованый','Резина для зимы 2x3',18),(34,'Диск R20 Липучка','Шипы для льда 3x2',14),(35,'Шина R15 Липучка','Резина для зимы 2x3',2),(36,'Запаска R15 Липучка','Шипы для льда 3x2',19),(37,'Шина R21 Лето','Резина для зимы 2x3',3),(38,'Колесо R16 Лето','Резина для зимы 0x3',14),(39,'Колесо R16 Лето','Шипы для пустыни 3x1',11),(40,'Запаска R14 Кованый','Резина для зимы 0x3',11),(41,'Запаска R17 Лето','Шипы для зимы 3x3',5),(42,'Колесо R19 Липучка','Резина для лета 0x2',15),(43,'Шина R20 Кованый','Резина для лета 0x2',11),(44,'Колесо R18 Зима','Шипы для льда 2x0',5),(45,'Колесо R18 Зима','Резина для зимы 0x3',10),(46,'Колесо R18 Зима','Шипы для пустыни 0x2',14),(47,'Диск R19 Лето','Шипы для льда 2x0',5),(48,'Колесо R18 Кованый','Шипы для пустыни 0x1',20),(49,'Диск R19 Зима','Шипы для льда 2x0',2),(50,'Запаска R18 Лето','Шипы для лета 2x2',8),(51,'Диск R22 Зима','Резина для зимы 0x3',8),(52,'Шина R14 Лето','Шипы для пустыни 0x2',12),(53,'Диск R16 Кованый','Шипы для лета 2x2',18),(54,'Шина R14 Кованый','Шипы для пустыни 0x1',10),(55,'Шина R17 Лето','Шипы для льда 2x0',6),(56,'Запаска R19 Лето','Резина для лета 0x2',8),(57,'Запаска R14 Кованый','Шипы для лета 2x2',15),(58,'Колесо R19 Липучка','Резина для пустыни 2x3',5),(59,'Колесо R16 Лето','Резина для зимы 1x0',2),(60,'Шина R18 Зима','Резина для зимы 1x0',14),(61,'Запаска R17 Липучка','Резина для лета 1x0',14),(62,'Шина R19 Липучка','Резина для пустыни 1x3',19),(63,'Запаска R21 Лето','Резина для зимы 1x0',4),(64,'Диск R17 Липучка','Резина для пустыни 1x3',11),(65,'Шина R21 Липучка','Резина для пустыни 2x0',2),(66,'Шина R19 Липучка','Резина для зимы 1x0',5),(67,'Диск R19 Зима','Резина для лета 1x0',9),(68,'Диск R16 Кованый','Шипы для лета 3x1',13),(69,'Диск R19 Лето','Резина для лета 3x3',8),(70,'Шина R19 Липучка','Шипы для лета 3x1',12),(71,'Запаска R15 Липучка','Шипы для лета 3x1',10),(72,'Шина R22 Лето','Резина для пустыни 1x1',14),(73,'Диск R22 Кованый','Резина для лета 3x3',1),(74,'Колесо R18 Липучка','Шипы для лета 3x1',14),(75,'Запаска R14 Кованый','Резина для лета 3x3',6),(76,'Диск R18 Зима','Шипы для лета 3x1',19),(77,'Диск R22 Зима','Резина для льда 3x3',11),(78,'Диск R22 Зима','Шипы для льда 1x1',8),(79,'Диск R17 Липучка','Шипы для льда 1x1',8),(80,'Диск R17 Липучка','Шипы для льда 3x1',4),(81,'Диск R17 Лето','Шипы для льда 3x1',15),(82,'Запаска R19 Лето','Резина для пустыни 0x3',13),(83,'Запаска R16 Зима','Резина для пустыни 0x3',3),(84,'Диск R17 Липучка','Резина для пустыни 1x2',5),(85,'Колесо R18 Липучка','Резина для пустыни 1x2',6),(86,'Запаска R21 Лето','Резина для пустыни 1x2',19),(87,'Шина R21 Лето','Резина для зимы 1x3',11),(88,'Диск R22 Липучка','Резина для зимы 3x1',10),(89,'Шина R20 Кованый','Резина для пустыни 1x2',5),(90,'Запаска R19 Кованый','Резина для зимы 3x1',6),(91,'Шина R21 Липучка','Резина для пустыни 1x2',18),(92,'Колесо R17 Лето','Резина для зимы 1x3',20),(93,'Шина R14 Кованый','Резина для лета 0x1',14),(94,'Шина R14 Липучка','Резина для зимы 1x3',3),(95,'Диск R22 Лето','Резина для зимы 3x1',3),(96,'Запаска R14 Кованый','Резина для зимы 3x1',16),(97,'Диск R19 Зима','Шипы для льда 2x1',8),(98,'Колесо R18 Лето','Шипы для льда 1x0',9),(99,'Шина R18 Зима','Резина для пустыни 2x1',9),(100,'Диск R22 Липучка','Шипы для льда 1x0',4);
/*!40000 ALTER TABLE `productmaterial_k_import` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `products_k_import`
--

DROP TABLE IF EXISTS `products_k_import`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `products_k_import` (
  `id` int NOT NULL AUTO_INCREMENT,
  `Title` text,
  `Article` int DEFAULT NULL,
  `MinCost` text,
  `Image` text,
  `TypeProduct` text,
  `CountMan` int DEFAULT NULL,
  `NumberCeh` text,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=101 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `products_k_import`
--

LOCK TABLES `products_k_import` WRITE;
/*!40000 ALTER TABLE `products_k_import` DISABLE KEYS */;
INSERT INTO `products_k_import` VALUES (1,'Колесо R18 Кованый',241659,'11509 рублей','\\products\\tire_15.jpg','Колесо',4,'Цех № 10'),(2,'Запаска R15 Кованый',327657,'8667','\\products\\tire_64.jpg','Запаска',2,'8'),(3,'Шина R21 Лето',266521,'10561','\\products\\tire_6.jpg','Шина',4,'№1'),(4,'Шина R21 Кованый',329576,'7989.00','\\products\\tire_59.jpg','Шина',2,'Цех № 2'),(5,'Диск R17 Лето',400508,'12941 рублей','\\products\\tire_24.jpg','Диск',1,'4'),(6,'Шина R14 Липучка',331598,'13879 рублей','\\products\\tire_17.jpg','Шина',4,'Цех № 1'),(7,'Диск R16 Кованый',440075,'9068 рублей','\\products\\tire_25.jpg','Диск',3,'9'),(8,'Запаска R14 Лето',448396,'12878.00','\\products\\tire_32.jpg','Запаска',1,'5'),(9,'Диск R22 Липучка',418286,'10670.00 ?','\\products\\tire_4.jpg','Диск',4,'2'),(10,'Запаска R15 Лето',348910,'4969.00','\\products\\tire_50.jpg','Запаска',1,'Цех № 9'),(11,'Шина R15 Липучка',349418,'6393 рублей','\\products\\tire_48.jpg','Шина',1,'№4'),(12,'Колесо R15 Кованый',376388,'9439','не указано','Колесо',3,'№4'),(13,'Колесо R20 Кованый',445217,'9569 руб.','\\products\\tire_1.jpg','Колесо',3,'10'),(14,'Диск R19 Лето',243152,'6264 руб.','\\products\\tire_0.jpg','Диск',1,'9'),(15,'Колесо R18 Лето',412238,'13892.00','\\products\\tire_14.jpg','Колесо',2,'№7'),(16,'Диск R20 Зима',252453,'14526.00 ?','нет','Диск',4,'Цех № 9'),(17,'Диск R17 Зима',343841,'12768.00','нет','Диск',3,'9'),(18,'Запаска R21 Липучка',247470,'10139.00','\\products\\tire_62.jpg','Запаска',1,'2'),(19,'Запаска R20 Липучка',335226,'9988 руб.','не указано','Запаска',1,'№2'),(20,'Шина R17 Кованый',299692,'11463','\\products\\tire_58.jpg','Шина',3,'Цех № 10'),(21,'Диск R20 Липучка',447543,'11661.00','\\products\\tire_3.jpg','Диск',4,'№8'),(22,'Запаска R20 Кованый',249737,'7509 рублей','не указано','Запаска',5,'№5'),(23,'Колесо R14 Кованый',429265,'11838 руб.','отсутствует','Колесо',3,'Цех № 6'),(24,'Диск R21 Кованый',299085,'4757.00 ?','\\products\\tire_61.jpg','Диск',3,'Цех № 3'),(25,'Шина R20 Кованый',330937,'10928 руб.','\\products\\tire_45.jpg','Шина',3,'Цех № 1'),(26,'Диск R16 Липучка',435703,'9934','нет','Диск',5,'2'),(27,'Запаска R18 Лето',305509,'5192.00','\\products\\tire_41.jpg','Запаска',1,'Цех № 3'),(28,'Запаска R19 Кованый',390434,'14258 рублей','\\products\\tire_46.jpg','Запаска',5,'Цех № 8'),(29,'Диск R18 Лето',317858,'8435 руб.','\\products\\tire_52.jpg','Диск',5,'Цех № 3'),(30,'Запаска R14 Кованый',412235,'12891.00 ?','\\products\\tire_47.jpg','Запаска',4,'Цех № 6'),(31,'Запаска R22 Липучка',328305,'10116.00','\\products\\tire_13.jpg','Запаска',2,'1'),(32,'Колесо R21 Липучка',403378,'3626.00 ?','\\products\\tire_55.jpg','Колесо',3,'№10'),(33,'Шина R18 Лето',425463,'11625','нет','Шина',4,'Цех № 10'),(34,'Запаска R17 Липучка',327883,'12332','\\products\\tire_10.jpg','Запаска',2,'2'),(35,'Диск R22 Кованый',388520,'7498 рублей','\\products\\tire_19.jpg','Диск',3,'2'),(36,'Шина R18 Липучка',319450,'4951 руб.','не указано','Шина',3,'6'),(37,'Шина R16 Кованый',421321,'14691.00 ?','отсутствует','Шина',1,'№2'),(38,'Диск R17 Липучка',282569,'12356 руб.','\\products\\tire_42.jpg','Диск',5,'5'),(39,'Запаска R23 Зима',394768,'13019.00 ?','\\products\\tire_8.jpg','Запаска',1,'9'),(40,'Диск R21 Зима',250714,'8762 рублей','\\products\\tire_11.jpg','Диск',5,'№5'),(41,'Диск R16 Лето',251201,'8149','не указано','Диск',3,'10'),(42,'Шина R14 Кованый',274477,'9527 рублей','\\products\\tire_34.jpg','Шина',5,'Цех № 5'),(43,'Диск R19 Зима',358851,'5695.00','\\products\\tire_16.jpg','Диск',5,'6'),(44,'Диск R21 Лето',449834,'2698.00','\\products\\tire_35.jpg','Диск',4,'№8'),(45,'Запаска R19 Липучка',438383,'12000.00 ?','нет','Запаска',3,'1'),(46,'Колесо R19 Лето',298778,'7493 рублей','\\products\\tire_38.jpg','Колесо',1,'10'),(47,'Колесо R16 Лето',337577,'10161.00','\\products\\tire_2.jpg','Колесо',1,'№9'),(48,'Запаска R21 Зима',365509,'14556','нет','Запаска',5,'6'),(49,'Шина R20 Липучка',348553,'3508','нет','Шина',2,'2'),(50,'Диск R20 Лето',300047,'10323 рублей','\\products\\tire_56.jpg','Диск',3,'№10'),(51,'Запаска R18 Липучка',279256,'9759 рублей','\\products\\tire_53.jpg','Запаска',4,'5'),(52,'Шина R22 Лето',406784,'14692 руб.','\\products\\tire_37.jpg','Шина',3,'Цех № 5'),(53,'Колесо R21 Лето',276905,'10343.00 ?','нет','Колесо',1,'Цех № 2'),(54,'Диск R19 Липучка',318661,'5544','нет','Диск',1,'6'),(55,'Запаска R14 Зима',440993,'6020 руб.','нет','Запаска',5,'№2'),(56,'Запаска R22 Кованый',341800,'5447.00 ?','не указано','Запаска',2,'Цех № 4'),(57,'Диск R22 Зима',453650,'11459','\\products\\tire_22.jpg','Диск',5,'Цех № 3'),(58,'Запаска R17 Кованый',372287,'5808 рублей','\\products\\tire_57.jpg','Запаска',5,'№3'),(59,'Диск R15 Лето',347427,'5071.00','нет','Диск',1,'№1'),(60,'Шина R15 Кованый',274665,'13101 руб.','\\products\\tire_63.jpg','Шина',2,'Цех № 10'),(61,'Запаска R19 Лето',283112,'3362 руб.','\\products\\tire_33.jpg','Запаска',3,'№4'),(62,'Колесо R20 Липучка',363664,'12681.00 ?','не указано','Колесо',1,'№8'),(63,'Шина R19 Зима',444141,'2741','отсутствует','Шина',2,'Цех № 8'),(64,'Шина R22 Кованый',416324,'13841.00 ?','\\products\\tire_30.jpg','Шина',2,'№8'),(65,'Колесо R18 Зима',387609,'3445 рублей','\\products\\tire_9.jpg','Колесо',1,'№4'),(66,'Запаска R16 Кованый',432234,'13556.00 ?','нет','Запаска',3,'7'),(67,'Колесо R17 Зима',381949,'5902.00','отсутствует','Колесо',4,'№6'),(68,'Запаска R16 Зима',394413,'12679 рублей','\\products\\tire_49.jpg','Запаска',3,'№10'),(69,'Колесо R20 Лето',434626,'11959','\\products\\tire_31.jpg','Колесо',5,'8'),(70,'Шина R17 Липучка',280863,'11695 руб.','нет','Шина',4,'8'),(71,'Шина R18 Зима',444280,'13168 руб.','\\products\\tire_44.jpg','Шина',4,'№6'),(72,'Запаска R17 Лето',331576,'4803.00 ?','\\products\\tire_39.jpg','Запаска',3,'№8'),(73,'Запаска R22 Зима',268886,'13471 руб.','отсутствует','Запаска',3,'Цех № 2'),(74,'Колесо R20 Зима',427198,'2397','нет','Колесо',4,'№10'),(75,'Шина R17 Лето',354738,'11329.00 ?','\\products\\tire_20.jpg','Шина',2,'Цех № 10'),(76,'Шина R14 Лето',330951,'6786.00','\\products\\tire_29.jpg','Шина',4,'№7'),(77,'Запаска R20 Зима',241577,'9125.00 ?','\\products\\tire_51.jpg','Запаска',2,'№6'),(78,'Колесо R17 Липучка',281537,'4365 руб.','не указано','Колесо',1,'№2'),(79,'Шина R16 Зима',300433,'2570 рублей','отсутствует','Шина',4,'№2'),(80,'Запаска R19 Зима',254860,'5568.00 ?','отсутствует','Запаска',2,'№5'),(81,'Диск R22 Лето',406411,'2904.00 ?','\\products\\tire_23.jpg','Диск',2,'Цех № 4'),(82,'Колесо R19 Липучка',440973,'8439 руб.','\\products\\tire_5.jpg','Колесо',4,'Цех № 4'),(83,'Шина R21 Липучка',308647,'12830 рублей','\\products\\tire_26.jpg','Шина',4,'Цех № 6'),(84,'Шина R17 Зима',291319,'6426.00','\\products\\tire_54.jpg','Шина',2,'4'),(85,'Диск R18 Зима',255211,'13239','\\products\\tire_21.jpg','Диск',1,'6'),(86,'Шина R18 Кованый',275809,'3258 руб.','\\products\\tire_40.jpg','Шина',4,'10'),(87,'Колесо R17 Лето',332936,'11145.00','\\products\\tire_28.jpg','Колесо',2,'Цех № 1'),(88,'Шина R22 Зима',382661,'10373 рублей','не указано','Шина',1,'№2'),(89,'Шина R19 Лето',335030,'4870 руб.','не указано','Шина',4,'Цех № 10'),(90,'Шина R19 Кованый',291359,'14682.00','\\products\\tire_27.jpg','Шина',5,'Цех № 10'),(91,'Колесо R18 Липучка',332858,'14804 рублей','\\products\\tire_12.jpg','Колесо',3,'№7'),(92,'Запаска R15 Липучка',237228,'5510.00 ?','\\products\\tire_18.jpg','Запаска',3,'8'),(93,'Шина R15 Зима',312952,'4039','отсутствует','Шина',2,'5'),(94,'Шина R19 Липучка',341034,'13063.00','\\products\\tire_36.jpg','Шина',1,'5'),(95,'Запаска R15 Зима',251241,'3874 руб.','отсутствует','Запаска',3,'Цех № 10'),(96,'Шина R16 Лето',437927,'7181 руб.','отсутствует','Шина',3,'6'),(97,'Колесо R16 Липучка',263261,'14521','нет','Колесо',4,'Цех № 1'),(98,'Запаска R21 Лето',299112,'3694.00 ?','\\products\\tire_43.jpg','Запаска',2,'Цех № 8'),(99,'Шина R21 Зима',398710,'9378.00','\\products\\tire_7.jpg','Шина',2,'№2'),(100,'Шина R16 Липучка',320970,'2264.00','\\products\\tire_60.jpg','Шина',1,'2');
/*!40000 ALTER TABLE `products_k_import` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `productsale`
--

DROP TABLE IF EXISTS `productsale`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `productsale` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `AgentID` int NOT NULL,
  `ProductID` int NOT NULL,
  `SaleDate` date NOT NULL,
  `ProductCount` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_ProductSale_Agent` (`AgentID`),
  KEY `FK_ProductSale_Product` (`ProductID`),
  CONSTRAINT `FK_ProductSale_Agent` FOREIGN KEY (`AgentID`) REFERENCES `agent` (`ID`),
  CONSTRAINT `FK_ProductSale_Product` FOREIGN KEY (`ProductID`) REFERENCES `product` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `productsale`
--

LOCK TABLES `productsale` WRITE;
/*!40000 ALTER TABLE `productsale` DISABLE KEYS */;
/*!40000 ALTER TABLE `productsale` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producttype`
--

DROP TABLE IF EXISTS `producttype`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `producttype` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(50) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `DefectedPercent` double NOT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producttype`
--

LOCK TABLES `producttype` WRITE;
/*!40000 ALTER TABLE `producttype` DISABLE KEYS */;
/*!40000 ALTER TABLE `producttype` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `shop`
--

DROP TABLE IF EXISTS `shop`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `shop` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `Address` varchar(300) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  `AgentID` int NOT NULL,
  PRIMARY KEY (`ID`),
  KEY `FK_Shop_Agent` (`AgentID`),
  CONSTRAINT `FK_Shop_Agent` FOREIGN KEY (`AgentID`) REFERENCES `agent` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `shop`
--

LOCK TABLES `shop` WRITE;
/*!40000 ALTER TABLE `shop` DISABLE KEYS */;
/*!40000 ALTER TABLE `shop` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `ID` int NOT NULL AUTO_INCREMENT,
  `Title` varchar(150) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  `INN` varchar(12) NOT NULL,
  `StartDate` date NOT NULL,
  `QualityRating` int DEFAULT NULL,
  `SupplierType` varchar(20) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-12-09 13:31:55
