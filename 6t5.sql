-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: localhost    Database: qlnv
-- ------------------------------------------------------
-- Server version	8.0.19

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
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `EmployeeId` int NOT NULL AUTO_INCREMENT,
  `EmployeeName` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `DateOfBirth` datetime DEFAULT NULL,
  `Address` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `PhoneNumber` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `Email` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `Presenter` int DEFAULT NULL,
  `PositionId` int DEFAULT NULL,
  `TitleId` int DEFAULT NULL,
  PRIMARY KEY (`EmployeeId`),
  KEY `fk001` (`TitleId`),
  KEY `fkngoai` (`PositionId`),
  CONSTRAINT `fk001` FOREIGN KEY (`TitleId`) REFERENCES `title` (`TitleId`),
  CONSTRAINT `fkngoai` FOREIGN KEY (`PositionId`) REFERENCES `positions` (`PositionId`)
) ENGINE=InnoDB AUTO_INCREMENT=8 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'Nguyễn Văn Phong','2011-03-13 02:53:50','Ly Nhan','0869690298',NULL,NULL,1,1),(3,'obama11','2011-03-13 02:53:50','Ly Nhan','342343','my@gmail.com',NULL,2,2),(4,'Nguyễn Văn phong','2011-03-13 02:53:50','Hà Nam','0869690298','hoan@gmail.com',NULL,3,3),(5,'Nguyễn Văn phong','2011-03-13 02:53:50','Hà Nam','0869690298','minh@gmail.com',NULL,4,1),(6,'Nguyễn Văn phong6','2011-03-13 02:53:50','Hà Nam','0869690298','phong28999@gmail.com',NULL,2,2),(7,'Nguyễn Văn phong7','2011-03-13 02:53:50','Hà Nam','0869690298','phong28999@gmail.com',NULL,1,3);
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `interview`
--

DROP TABLE IF EXISTS `interview`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `interview` (
  `EmployeeId` int NOT NULL,
  `CV` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `Status` int DEFAULT NULL,
  `Note` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `InterviewTime` datetime DEFAULT NULL,
  `TestScores` int DEFAULT NULL,
  `IsApply` bit(1) DEFAULT NULL,
  `Failure` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `InterviewAddress` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `Solidarity` int DEFAULT NULL,
  `InterviewerId` int DEFAULT NULL,
  UNIQUE KEY `EmployeeId` (`EmployeeId`),
  CONSTRAINT `interview_ibfk_1` FOREIGN KEY (`EmployeeId`) REFERENCES `employee` (`EmployeeId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `interview`
--

LOCK TABLES `interview` WRITE;
/*!40000 ALTER TABLE `interview` DISABLE KEYS */;
INSERT INTO `interview` VALUES (1,'New Text Document.txt',0,'Hà Nam','2011-03-13 02:53:50',1,_binary '\0','11qd','dqwdqw',0,6),(3,'lovce',0,'Hà Nam','2011-03-13 02:53:50',1,_binary '\0','11qd','dqwdqw',1,6),(4,'',2,'Hà Nam','2011-03-13 02:53:50',1,_binary '\0','11qd','dqwdqw',2,6),(5,'sample.pdf',3,'Hà Nam','2011-03-13 02:53:50',1,_binary '\0','11qd','dqwdqw',2,6),(6,'Nguyễn Văn phong6',4,'Hà Nam','2011-03-13 02:53:50',1,_binary '\0','11qd','dqwdqw',1,6),(7,'Nguyễn Văn phong7',3,'Hà Nam','2011-03-15 02:53:50',1,_binary '\0','11qd','dqwdqw',1,6);
/*!40000 ALTER TABLE `interview` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mailcontent`
--

DROP TABLE IF EXISTS `mailcontent`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mailcontent` (
  `Id` int NOT NULL,
  `Title` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `Content` varchar(500) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `MailType` int DEFAULT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mailcontent`
--

LOCK TABLES `mailcontent` WRITE;
/*!40000 ALTER TABLE `mailcontent` DISABLE KEYS */;
INSERT INTO `mailcontent` VALUES (1,'Saishunkan System Vietnam_Thư mời phỏng vấn','Chúng tôi là phụ trách nhân sự công ty Saishunkan System VietNam. Chúng tôi mời bạn đế phỏng vấn thực tập với công ty chúng tôi.',0),(2,'Saishunkan System Vietnam_Thư mời phỏng vấn - Vòng 2','Chúng tôi là phụ trách nhân sự công ty Saishunkan System VietNam. Chúng tôi mời bạn đế phỏng vấn thực tập với công ty chúng tôi.',1),(3,'Saishunkan System Vietnam_Thư mời phỏng vấn','Chúng tôi là phụ trách nhân sự công ty Saishunkan System VietNam. Chúng tôi mời bạn đế phỏng vấn Fresher với công ty chúng tôi.',2),(4,'Saishunkan System Vietnam_Thư mời phỏng vấn - Vòng 2','Chúng tôi là phụ trách nhân sự công ty Saishunkan System VietNam. Chúng tôi mời bạn đế phỏng vấn Fresher với công ty chúng tôi.',3),(5,'Saishunkan System Vietnam_Thư mời phỏng vấn','Chúng tôi là phụ trách nhân sự công ty Saishunkan System VietNam. Chúng tôi mời bạn đế phỏng vấn Dev với công ty chúng tôi.',4),(6,'Saishunkan System Vietnam_Thư mời phỏng vấn - Vòng 2','Chúng tôi là phụ trách nhân sự công ty Saishunkan System VietNam. Chúng tôi mời bạn đế phỏng vấn Dev với công ty chúng tôi.',5);
/*!40000 ALTER TABLE `mailcontent` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `mailcustom`
--

DROP TABLE IF EXISTS `mailcustom`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `mailcustom` (
  `Tile` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `Content` varchar(250) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  `EmployeeId` int DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `mailcustom`
--

LOCK TABLES `mailcustom` WRITE;
/*!40000 ALTER TABLE `mailcustom` DISABLE KEYS */;
/*!40000 ALTER TABLE `mailcustom` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `positions`
--

DROP TABLE IF EXISTS `positions`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `positions` (
  `PositionId` int NOT NULL,
  `PositionName` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`PositionId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `positions`
--

LOCK TABLES `positions` WRITE;
/*!40000 ALTER TABLE `positions` DISABLE KEYS */;
INSERT INTO `positions` VALUES (1,'C#'),(2,'PHP'),(3,'JS'),(4,'Ruby'),(5,'Java'),(6,'C++'),(7,'C'),(8,'React');
/*!40000 ALTER TABLE `positions` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `title`
--

DROP TABLE IF EXISTS `title`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `title` (
  `TitleId` int NOT NULL,
  `TitleName` varchar(50) CHARACTER SET utf8 COLLATE utf8_general_ci DEFAULT NULL,
  PRIMARY KEY (`TitleId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `title`
--

LOCK TABLES `title` WRITE;
/*!40000 ALTER TABLE `title` DISABLE KEYS */;
INSERT INTO `title` VALUES (1,'TTS'),(2,'Fresher'),(3,'Dev');
/*!40000 ALTER TABLE `title` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'qlnv'
--
/*!50003 DROP PROCEDURE IF EXISTS `Proc_DeleteEmployeeById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_DeleteEmployeeById`(IN id int)
BEGIN

	delete from interview
    where EmployeeId=id;
    
    delete from employee
    where EmployeeId=id;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetbyFilterApproval` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetbyFilterApproval`(
	keyword nvarchar(250),
    positionId int,
    titleId int
)
BEGIN
    select ee.EmployeeId,ee.EmployeeName,ee.DateOfBirth,ee.Address,ee.PhoneNumber,ee.Email,ee.Presenter,
   Interview.CV,Interview.Status,Interview.Note,Interview.InterviewTime,Interview.TestScores,Interview.IsApply,Interview.Failure,Interview.InterviewAddress,Interview.Solidarity,Interview.InterviewerId,
   Positions.PositionName,title.TitleName,(select EmployeeName from Employee esub where esub.EmployeeId = ee.Presenter) as PresenterName
   
   from Employee ee inner join title on ee.TitleId=Title.TitleId inner join positions on 
   positions.PositionId=ee.PositionId inner join Interview
    on ee.EmployeeId=Interview.EmployeeId where ee.EmployeeName like concat('%',keyword,'%') 
    and positions.PositionId=positionId and Title.TitleId=titleID and Interview.Status=0;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetByStatus` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetByStatus`(status int)
BEGIN
select ee.EmployeeId,ee.EmployeeName,ee.DateOfBirth,ee.Address,ee.PhoneNumber,ee.Email,ee.Presenter,
   Interview.CV,Interview.Status,Interview.Note,Interview.InterviewTime,Interview.TestScores,Interview.IsApply,Interview.Failure,Interview.InterviewAddress,Interview.Solidarity,Interview.InterviewerId,
   Positions.PositionName,title.TitleName,(select EmployeeName from Employee esub where esub.EmployeeId = ee.Presenter) as PresenterName,Interview.Solidarity
   
   from Employee ee inner join title on ee.TitleId=Title.TitleId inner join positions on 
   positions.PositionId=ee.PositionId inner join Interview
    on ee.EmployeeId=Interview.EmployeeId where Interview.Status=status;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetEmployee` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetEmployee`()
BEGIN
select ee.EmployeeId,ee.EmployeeName,ee.DateOfBirth,ee.Address,ee.PhoneNumber,ee.Email,ee.Presenter,
   Interview.CV,Interview.Status,Interview.Note,Interview.InterviewTime,Interview.TestScores,Interview.IsApply,Interview.Failure,Interview.InterviewAddress,Interview.Solidarity,Interview.InterviewerId,
   Positions.PositionName,title.TitleName,(select EmployeeName from Employee esub where esub.EmployeeId = ee.Presenter) as PresenterName
   
   from Employee ee inner join title on ee.TitleId=Title.TitleId inner join positions on 
   positions.PositionId=ee.PositionId inner join Interview
    on ee.EmployeeId=Interview.EmployeeId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetEmployeeById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetEmployeeById`(IN EmployeeId int)
BEGIN
	select ee.EmployeeId,ee.EmployeeName,ee.DateOfBirth,ee.Address,ee.PhoneNumber,ee.Email,ee.Presenter,
   Interview.CV,Interview.Status,Interview.Note,Interview.InterviewTime,Interview.TestScores,Interview.IsApply,Interview.Failure,Interview.InterviewAddress,Interview.Solidarity,Interview.InterviewerId,
   Positions.PositionName,title.TitleName,(select EmployeeName from Employee esub where esub.EmployeeId = ee.Presenter) as PresenterName,title.TitleId,positions.PositionId
   
   from Employee ee inner join title on ee.TitleId=Title.TitleId inner join positions on 
   positions.PositionId=ee.PositionId inner join Interview
    on ee.EmployeeId=Interview.EmployeeId 
    where ee.EmployeeId=Interview.EmployeeId and ee.EmployeeId=EmployeeId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetEmployeeSendMail` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetEmployeeSendMail`(
	status int
)
BEGIN
select ee.EmployeeId,ee.EmployeeName,ee.DateOfBirth,ee.Address,ee.PhoneNumber,ee.Email,ee.Presenter,
   Interview.CV,Interview.Status,Interview.Note,Interview.InterviewTime,Interview.TestScores,Interview.IsApply,Interview.Failure,Interview.InterviewAddress,Interview.Solidarity,Interview.InterviewerId,
   Positions.PositionName,title.TitleName,(select EmployeeName from Employee esub where esub.EmployeeId = ee.Presenter) as PresenterName,Interview.Solidarity,title.TitleId
   
   from Employee ee inner join title on ee.TitleId=Title.TitleId inner join positions on 
   positions.PositionId=ee.PositionId inner join Interview
    on ee.EmployeeId=Interview.EmployeeId where Interview.Status>status;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetMailContentByType` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetMailContentByType`(
	type int
)
BEGIN
	select *from mailcontent
    where mailcontent.MailType=type;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetPageingEmployee` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetPageingEmployee`(
	pageindex int,
    pagesize int
)
BEGIN
	declare start int;
    declare end int;
	set start=(pageindex-1)*pagesize;
    set end=pagesize;
    select ee.EmployeeId,ee.EmployeeName,ee.DateOfBirth,ee.Address,ee.PhoneNumber,ee.Email,ee.Presenter,
   Interview.CV,Interview.Status,Interview.Note,Interview.InterviewTime,Interview.TestScores,Interview.IsApply,Interview.Failure,Interview.InterviewAddress,Interview.Solidarity,Interview.InterviewerId,
   Positions.PositionName,title.TitleName,(select EmployeeName from Employee esub where esub.EmployeeId = ee.Presenter) as PresenterName
   
   from Employee ee inner join title on ee.TitleId=Title.TitleId inner join positions on 
   positions.PositionId=ee.PositionId inner join Interview
    on ee.EmployeeId=Interview.EmployeeId Limit start,end;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetPositions` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetPositions`(

)
BEGIN
    select*from positions;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetPositionsById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetPositionsById`(IN PositionsId int)
BEGIN
	SELECT * FROM qlnv.positions where positionId=PositionsId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetTitle` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetTitle`()
BEGIN
	SELECT * FROM qlnv.title;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_GetTitleById` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_GetTitleById`(IN TitleId int)
BEGIN
SELECT * FROM qlnv.Title where Title.TitleId=TitleId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_UpdateEmployee` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_UpdateEmployee`(
	
		  EmployeeId int,
          EmployeeName nvarchar(50),
          DateOfBirth datetime,
          Address nvarchar(250),

          PhoneNumber varchar(50),
          Email varchar(50),
          Presenter int,
          CV varchar(50),
          Status int,
          Note varchar(250),
          InterviewTime datetime,
          TestScores int,
          isApply bit,
          Failure varchar(50),
          InterviewAddress varchar(50),
          PositionName nvarchar(50),
          TitleName  nvarchar(50),
          PresenterName nvarchar(250),
          PositionId int,
          TitleId int
)
BEGIN
	update employee
    set employee.EmployeeName=EmployeeName,employee.Address=Address,employee.Email=Email,employee.PositionId=PositionId,employee.TitleId=TitleId
    where employee.EmployeeId=EmployeeId;
    
    
    update interview
    set interview.CV=CV,interview.Status=0
    where interview.EmployeeId=EmployeeId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_UpdateSolidarity` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_UpdateSolidarity`(
	employeeId int ,
    solidarity int,
    interviewtime datetime
)
BEGIN
	update interview
    set interview.Solidarity=solidarity,interview.InterviewTime=interviewtime
    where interview.EmployeeId=employeeId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!50003 DROP PROCEDURE IF EXISTS `Proc_UpdateStatus` */;
/*!50003 SET @saved_cs_client      = @@character_set_client */ ;
/*!50003 SET @saved_cs_results     = @@character_set_results */ ;
/*!50003 SET @saved_col_connection = @@collation_connection */ ;
/*!50003 SET character_set_client  = utf8mb4 */ ;
/*!50003 SET character_set_results = utf8mb4 */ ;
/*!50003 SET collation_connection  = utf8mb4_0900_ai_ci */ ;
/*!50003 SET @saved_sql_mode       = @@sql_mode */ ;
/*!50003 SET sql_mode              = 'STRICT_TRANS_TABLES,NO_ENGINE_SUBSTITUTION' */ ;
DELIMITER ;;
CREATE DEFINER=`root`@`localhost` PROCEDURE `Proc_UpdateStatus`(
	employeeId int,
    status int
)
BEGIN
	update interview 
    set interview.Status=status
    where interview.EmployeeId=employeeId;
END ;;
DELIMITER ;
/*!50003 SET sql_mode              = @saved_sql_mode */ ;
/*!50003 SET character_set_client  = @saved_cs_client */ ;
/*!50003 SET character_set_results = @saved_cs_results */ ;
/*!50003 SET collation_connection  = @saved_col_connection */ ;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-05-06 17:32:02
