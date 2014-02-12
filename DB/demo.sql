/*
SQLyog Community Edition- MySQL GUI v6.15
MySQL - 5.6.16 : Database - demo
*********************************************************************
*/

/*!40101 SET NAMES utf8 */;

/*!40101 SET SQL_MODE=''*/;

create database if not exists `demo`;

USE `demo`;

/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;

/*Table structure for table `userdatas` */

DROP TABLE IF EXISTS `userdatas`;

CREATE TABLE `userdatas` (
  `UserId` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` longtext,
  `LastName` longtext,
  `UserDetails_UserDetailsId` int(11) DEFAULT NULL,
  PRIMARY KEY (`UserId`),
  KEY `IX_UserDetails_UserDetailsId` (`UserDetails_UserDetailsId`) USING HASH,
  CONSTRAINT `FK_userdatas_userdetails_UserDetails_UserDetailsId` FOREIGN KEY (`UserDetails_UserDetailsId`) REFERENCES `userdetails` (`UserDetailsId`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

/*Data for the table `userdatas` */

insert  into `userdatas`(`UserId`,`FirstName`,`LastName`,`UserDetails_UserDetailsId`) values (1,'Shikhar','Dubey',NULL),(2,'Sachin','Nigam',NULL),(3,'Anand','Gupta',1),(4,'A','B',2),(5,'a','b',3);

/*Table structure for table `userdetails` */

DROP TABLE IF EXISTS `userdetails`;

CREATE TABLE `userdetails` (
  `UserDetailsId` int(11) NOT NULL AUTO_INCREMENT,
  `City` longtext,
  `State` longtext,
  PRIMARY KEY (`UserDetailsId`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8;

/*Data for the table `userdetails` */

insert  into `userdetails`(`UserDetailsId`,`City`,`State`) values (1,'kanpur','up'),(2,'C','D'),(3,'c','d');

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
