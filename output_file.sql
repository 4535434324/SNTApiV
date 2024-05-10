-- MySQL dump 10.13  Distrib 8.0.36, for Linux (x86_64)
--
-- Host: localhost    Database: snt_buhgalter
-- ------------------------------------------------------
-- Server version	8.0.36-0ubuntu0.22.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Должностьs`
--

DROP TABLE IF EXISTS `Должностьs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Должностьs` (
  `idДолжность` int NOT NULL,
  `Наименование_должности` varchar(45) DEFAULT NULL,
  `Зараплатная_плата` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idДолжность`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Должностьs`
--

LOCK TABLES `Должностьs` WRITE;
/*!40000 ALTER TABLE `Должностьs` DISABLE KEYS */;
INSERT INTO `Должностьs` VALUES (0,'Админ','0'),(1,'Бухгалтер','15000');
/*!40000 ALTER TABLE `Должностьs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Ед_Измеренияs`
--

DROP TABLE IF EXISTS `Ед_Измеренияs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Ед_Измеренияs` (
  `IDЕд_изм` int NOT NULL,
  `Ед_изм` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDЕд_изм`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Ед_Измеренияs`
--

LOCK TABLES `Ед_Измеренияs` WRITE;
/*!40000 ALTER TABLE `Ед_Измеренияs` DISABLE KEYS */;
INSERT INTO `Ед_Измеренияs` VALUES (0,'12');
/*!40000 ALTER TABLE `Ед_Измеренияs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Зарплатаs`
--

DROP TABLE IF EXISTS `Зарплатаs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Зарплатаs` (
  `IDЗарплата` int NOT NULL,
  `IDДолжности` int NOT NULL,
  `Зарплата_работника` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDЗарплата`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Зарплатаs`
--

LOCK TABLES `Зарплатаs` WRITE;
/*!40000 ALTER TABLE `Зарплатаs` DISABLE KEYS */;
INSERT INTO `Зарплатаs` VALUES (1,0,'0');
/*!40000 ALTER TABLE `Зарплатаs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Карточки_Садоводовs`
--

DROP TABLE IF EXISTS `Карточки_Садоводовs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Карточки_Садоводовs` (
  `IDКарточки_Садовода` int NOT NULL,
  `Номер_садовода` varchar(45) DEFAULT NULL,
  `Фамилия_садовода` varchar(45) DEFAULT NULL,
  `Имя_содовода` varchar(45) DEFAULT NULL,
  `Отчество_садовода` varchar(45) DEFAULT NULL,
  `Серия_номер_паспорта_садовода` varchar(45) DEFAULT NULL,
  `Код_Улица_участка_садовода` varchar(45) DEFAULT NULL,
  `Номер_участка_садовода` varchar(45) DEFAULT NULL,
  `Код_Сотак_участка_садовода` varchar(45) DEFAULT NULL,
  `Книжка_выдана` varchar(45) DEFAULT NULL,
  `Дата_рождения` varchar(45) DEFAULT NULL,
  `Кадастровый_номер` varchar(45) DEFAULT NULL,
  `ЕГРПНомер` varchar(45) DEFAULT NULL,
  `Год_принятия_в_товарищество` varchar(45) DEFAULT NULL,
  `Номер_телефона_садовода` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDКарточки_Садовода`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Карточки_Садоводовs`
--

LOCK TABLES `Карточки_Садоводовs` WRITE;
/*!40000 ALTER TABLE `Карточки_Садоводовs` DISABLE KEYS */;
INSERT INTO `Карточки_Садоводовs` VALUES (0,'1','Каволенко','Виктор','Владимирович','1','0','1','1','1','1','1','1','1','1');
/*!40000 ALTER TABLE `Карточки_Садоводовs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Комунальные_Услугиs`
--

DROP TABLE IF EXISTS `Комунальные_Услугиs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Комунальные_Услугиs` (
  `IDУслуги` int NOT NULL,
  `Наименование_услуги` varchar(45) DEFAULT NULL,
  `Цена_услуги_за_единицу_измерения` varchar(45) DEFAULT NULL,
  `Единица_измерения` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDУслуги`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Комунальные_Услугиs`
--

LOCK TABLES `Комунальные_Услугиs` WRITE;
/*!40000 ALTER TABLE `Комунальные_Услугиs` DISABLE KEYS */;
INSERT INTO `Комунальные_Услугиs` VALUES (0,'0','0','0'),(6,'по поосо','наол','шт');
/*!40000 ALTER TABLE `Комунальные_Услугиs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Оплата_Взносовs`
--

DROP TABLE IF EXISTS `Оплата_Взносовs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Оплата_Взносовs` (
  `IDВзноса` int NOT NULL,
  `Koд_садовода` varchar(45) DEFAULT NULL,
  `Код_целевого_взноса` varchar(45) DEFAULT NULL,
  `Состояние_оплаты_целевого_взноса` varchar(45) DEFAULT NULL,
  `К_оплате_за_целевые` varchar(45) DEFAULT NULL,
  `Код_членского_взноса` varchar(45) DEFAULT NULL,
  `Состояние_оплаты_членского_взноса` varchar(45) DEFAULT NULL,
  `К_оплате_за_членские` varchar(45) DEFAULT NULL,
  `Количество_соток` varchar(45) DEFAULT NULL,
  `Дата_и_время_оплаты` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDВзноса`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Оплата_Взносовs`
--

LOCK TABLES `Оплата_Взносовs` WRITE;
/*!40000 ALTER TABLE `Оплата_Взносовs` DISABLE KEYS */;
INSERT INTO `Оплата_Взносовs` VALUES (5,'5','5','5','5','5','5','5','5','2024-04-08 16:35:47');
/*!40000 ALTER TABLE `Оплата_Взносовs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Пользователиs`
--

DROP TABLE IF EXISTS `Пользователиs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Пользователиs` (
  `IDПользователи` int NOT NULL,
  `Name` varchar(45) DEFAULT NULL,
  `IDРольПользователя` int NOT NULL,
  `Login` varchar(45) DEFAULT NULL,
  `Password` varchar(45) DEFAULT NULL,
  `Rроль` int DEFAULT NULL,
  PRIMARY KEY (`IDПользователи`),
  KEY `fk_Пользователиs_Рольs_idx` (`IDРольПользователя`),
  CONSTRAINT `fk_Пользователиs_Рольs` FOREIGN KEY (`IDРольПользователя`) REFERENCES `Рольs` (`IDРоль`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Пользователиs`
--

LOCK TABLES `Пользователиs` WRITE;
/*!40000 ALTER TABLE `Пользователиs` DISABLE KEYS */;
INSERT INTO `Пользователиs` VALUES (0,'Виктор',0,'2002','2002',0),(1,'1',0,'1','1',1);
/*!40000 ALTER TABLE `Пользователиs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Работникиs`
--

DROP TABLE IF EXISTS `Работникиs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Работникиs` (
  `IDРаботника` int NOT NULL,
  `Фамилия_работника` varchar(45) DEFAULT NULL,
  `Имя_работника` varchar(45) DEFAULT NULL,
  `Отчество_работника` varchar(45) DEFAULT NULL,
  `Серия_номер_паспорта_работника` varchar(45) DEFAULT NULL,
  `Должность` varchar(45) DEFAULT NULL,
  `Смен_в_неделю` varchar(45) DEFAULT NULL,
  `Пароль` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDРаботника`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Работникиs`
--

LOCK TABLES `Работникиs` WRITE;
/*!40000 ALTER TABLE `Работникиs` DISABLE KEYS */;
/*!40000 ALTER TABLE `Работникиs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Рольs`
--

DROP TABLE IF EXISTS `Рольs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Рольs` (
  `IDРоль` int NOT NULL,
  `Название_роли` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDРоль`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Рольs`
--

LOCK TABLES `Рольs` WRITE;
/*!40000 ALTER TABLE `Рольs` DISABLE KEYS */;
INSERT INTO `Рольs` VALUES (0,'Admin'),(1,'1');
/*!40000 ALTER TABLE `Рольs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Соткиs`
--

DROP TABLE IF EXISTS `Соткиs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Соткиs` (
  `IDСотки` int NOT NULL,
  `Количество_соток` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDСотки`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Соткиs`
--

LOCK TABLES `Соткиs` WRITE;
/*!40000 ALTER TABLE `Соткиs` DISABLE KEYS */;
INSERT INTO `Соткиs` VALUES (0,'0'),(1,'2');
/*!40000 ALTER TABLE `Соткиs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Улицыs`
--

DROP TABLE IF EXISTS `Улицыs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Улицыs` (
  `IDУлица` int NOT NULL,
  `Намиенование_улицы_СНТ` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDУлица`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Улицыs`
--

LOCK TABLES `Улицыs` WRITE;
/*!40000 ALTER TABLE `Улицыs` DISABLE KEYS */;
INSERT INTO `Улицыs` VALUES (0,'Яблочная'),(1,'КК');
/*!40000 ALTER TABLE `Улицыs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Учет_Потребляемых_Ресурсовs`
--

DROP TABLE IF EXISTS `Учет_Потребляемых_Ресурсовs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Учет_Потребляемых_Ресурсовs` (
  `IDУчет_ресурсов` int NOT NULL,
  `код_садовода` int DEFAULT NULL,
  `Код_Ком_услуг` int DEFAULT NULL,
  `Потребление` varchar(45) DEFAULT NULL,
  `Цена_услуги_1_ед` varchar(45) DEFAULT NULL,
  `к_оплате_потреб` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDУчет_ресурсов`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Учет_Потребляемых_Ресурсовs`
--

LOCK TABLES `Учет_Потребляемых_Ресурсовs` WRITE;
/*!40000 ALTER TABLE `Учет_Потребляемых_Ресурсовs` DISABLE KEYS */;
INSERT INTO `Учет_Потребляемых_Ресурсовs` VALUES (0,1,1,'1','1','1'),(979,211,22,'12','12','133');
/*!40000 ALTER TABLE `Учет_Потребляемых_Ресурсовs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Целевые_Взносы_Тарифs`
--

DROP TABLE IF EXISTS `Целевые_Взносы_Тарифs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Целевые_Взносы_Тарифs` (
  `IDЦелевого_взноса` int NOT NULL,
  `Наменование_целевого_взноса` varchar(45) DEFAULT NULL,
  `Цена_целевого_взноса` varchar(45) DEFAULT NULL,
  `Частота_оплаты_целевые` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDЦелевого_взноса`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Целевые_Взносы_Тарифs`
--

LOCK TABLES `Целевые_Взносы_Тарифs` WRITE;
/*!40000 ALTER TABLE `Целевые_Взносы_Тарифs` DISABLE KEYS */;
/*!40000 ALTER TABLE `Целевые_Взносы_Тарифs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `Членские_Взносы_Тарифs`
--

DROP TABLE IF EXISTS `Членские_Взносы_Тарифs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Членские_Взносы_Тарифs` (
  `IDЧленсого_взноса` int NOT NULL,
  `Наминование_Членсого_взноса` varchar(45) DEFAULT NULL,
  `Цена_Членсого_взноса` varchar(45) DEFAULT NULL,
  `Частота_членские` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`IDЧленсого_взноса`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Членские_Взносы_Тарифs`
--

LOCK TABLES `Членские_Взносы_Тарифs` WRITE;
/*!40000 ALTER TABLE `Членские_Взносы_Тарифs` DISABLE KEYS */;
/*!40000 ALTER TABLE `Членские_Взносы_Тарифs` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-04-11 14:26:07
