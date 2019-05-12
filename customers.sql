/*
Navicat MySQL Data Transfer

Source Server         : 127.0.0.1_3306
Source Server Version : 50717
Source Host           : 127.0.0.1:3306
Source Database       : shop

Target Server Type    : MYSQL
Target Server Version : 50717
File Encoding         : 65001

Date: 2019-05-11 06:33:39
*/

SET FOREIGN_KEY_CHECKS=0;

-- ----------------------------
-- Table structure for customers
-- ----------------------------
DROP TABLE IF EXISTS `customers`;
CREATE TABLE `customers` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(255) NOT NULL,
  `PhoneNo` varchar(255) NOT NULL,
  `Address` varchar(255) NOT NULL,
  `IGUser` varchar(255) NOT NULL DEFAULT '',
  `Email` varchar(255) NOT NULL DEFAULT '',
  PRIMARY KEY (`ID`,`PhoneNo`),
  KEY `ID` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=104 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of customers
-- ----------------------------
INSERT INTO `customers` VALUES ('102', 'Muhammad Ibrahim Ismail', '01004125602', '20 Mohamed Basha Mohsen', 'm.ibrahim09', 'm.ibrahim99x@gmail.com');
INSERT INTO `customers` VALUES ('103', 'Muhammad Ahmed', '01003661637', 'ahmed st', '', '');

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders` (
  `ProductID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `OrderID` int(11) NOT NULL,
  `Quantity` int(11) DEFAULT NULL,
  `Paid` tinyint(4) DEFAULT NULL,
  PRIMARY KEY (`ProductID`,`CustomerID`,`OrderID`),
  KEY `Customer_id` (`CustomerID`),
  CONSTRAINT `Customer_id` FOREIGN KEY (`CustomerID`) REFERENCES `customers` (`ID`),
  CONSTRAINT `Product_id` FOREIGN KEY (`ProductID`) REFERENCES `products` (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of orders
-- ----------------------------

-- ----------------------------
-- Table structure for products
-- ----------------------------
DROP TABLE IF EXISTS `products`;
CREATE TABLE `products` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) DEFAULT NULL,
  `QuantityAvailable` int(11) DEFAULT NULL,
  `Price` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of products
-- ----------------------------
INSERT INTO `products` VALUES ('1', 'حلق اذن', '20', '40');
