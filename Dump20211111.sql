CREATE DATABASE  IF NOT EXISTS `baseprog` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `baseprog`;
-- MySQL dump 10.13  Distrib 8.0.26, for Win64 (x86_64)
--
-- Host: localhost    Database: baseprog
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
-- Table structure for table `animales`
--

DROP TABLE IF EXISTS `animales`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `animales` (
  `IdAnimal` int NOT NULL AUTO_INCREMENT,
  `IdJ` int NOT NULL,
  `NombreAnimal` varchar(20) NOT NULL,
  `DescripcionAnimal` varchar(50) NOT NULL,
  PRIMARY KEY (`IdAnimal`),
  KEY `IdJ` (`IdJ`),
  CONSTRAINT `animales_ibfk_1` FOREIGN KEY (`IdJ`) REFERENCES `jaulas` (`IdJaula`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `animales`
--

LOCK TABLES `animales` WRITE;
/*!40000 ALTER TABLE `animales` DISABLE KEYS */;
INSERT INTO `animales` VALUES (1,4,'Penguin','SuperNefasto'),(2,3,'asdas','asdasd'),(6,3,'Perro','rope');
/*!40000 ALTER TABLE `animales` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compras`
--

DROP TABLE IF EXISTS `compras`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compras` (
  `IdCompra` int NOT NULL AUTO_INCREMENT,
  `CedulaComprador` varchar(9) NOT NULL,
  `FechaDeCompra` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP,
  `Producto` varchar(20) NOT NULL,
  `Precio` varchar(4) NOT NULL,
  PRIMARY KEY (`IdCompra`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compras`
--

LOCK TABLES `compras` WRITE;
/*!40000 ALTER TABLE `compras` DISABLE KEYS */;
/*!40000 ALTER TABLE `compras` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `espacios`
--

DROP TABLE IF EXISTS `espacios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `espacios` (
  `IdEspacio` int NOT NULL AUTO_INCREMENT,
  `NombreEspacio` varchar(20) NOT NULL,
  `DescripcionEspacio` varchar(60) NOT NULL,
  PRIMARY KEY (`IdEspacio`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `espacios`
--

LOCK TABLES `espacios` WRITE;
/*!40000 ALTER TABLE `espacios` DISABLE KEYS */;
INSERT INTO `espacios` VALUES (2,'sdsadasd','fvdvdfv'),(4,'Junglaaaa','sgfdsfdsdsfaaaa'),(5,'scasc','fsada');
/*!40000 ALTER TABLE `espacios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jaulas`
--

DROP TABLE IF EXISTS `jaulas`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jaulas` (
  `IdJaula` int NOT NULL AUTO_INCREMENT,
  `DescripcionJaula` varchar(50) NOT NULL,
  `IdUbicacion` int NOT NULL,
  PRIMARY KEY (`IdJaula`),
  KEY `IdUbicacion` (`IdUbicacion`),
  CONSTRAINT `jaulas_ibfk_1` FOREIGN KEY (`IdUbicacion`) REFERENCES `espacios` (`IdEspacio`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jaulas`
--

LOCK TABLES `jaulas` WRITE;
/*!40000 ALTER TABLE `jaulas` DISABLE KEYS */;
INSERT INTO `jaulas` VALUES (3,'bbbbbb',4),(4,'wwwrr',2);
/*!40000 ALTER TABLE `jaulas` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuarios`
--

DROP TABLE IF EXISTS `usuarios`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuarios` (
  `NombreDeUsuario` varchar(20) NOT NULL,
  `Contraseña` varchar(16) NOT NULL,
  `TipoDeUsuario` varchar(13) DEFAULT NULL,
  PRIMARY KEY (`NombreDeUsuario`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuarios`
--

LOCK TABLES `usuarios` WRITE;
/*!40000 ALTER TABLE `usuarios` DISABLE KEYS */;
INSERT INTO `usuarios` VALUES ('Juan','1234','Admin'),('Luis','1234','Vendedor');
/*!40000 ALTER TABLE `usuarios` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `visitantes`
--

DROP TABLE IF EXISTS `visitantes`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `visitantes` (
  `IdVisitante` int NOT NULL AUTO_INCREMENT,
  `Cedula` varchar(9) NOT NULL,
  `NombreVisitante` varchar(20) NOT NULL,
  PRIMARY KEY (`IdVisitante`),
  UNIQUE KEY `Cedula` (`Cedula`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `visitantes`
--

LOCK TABLES `visitantes` WRITE;
/*!40000 ALTER TABLE `visitantes` DISABLE KEYS */;
INSERT INTO `visitantes` VALUES (3,'445566','wert'),(4,'778899','Pedro'),(12,'1144888','Pedro'),(14,'33333','Jorgepp'),(15,'669911','Joseeeee');
/*!40000 ALTER TABLE `visitantes` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-11-11 14:09:04