/*
 Navicat Premium Data Transfer

 Source Server         : localhost
 Source Server Type    : MySQL
 Source Server Version : 50717
 Source Host           : localhost:3306
 Source Schema         : shop

 Target Server Type    : MySQL
 Target Server Version : 50717
 File Encoding         : 65001

 Date: 11/05/2019 21:28:26
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for customers
-- ----------------------------
DROP TABLE IF EXISTS `customers`;
CREATE TABLE `customers`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerName` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `PhoneNo` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `Address` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL,
  `IGUser` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '',
  `Email` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NOT NULL DEFAULT '',
  PRIMARY KEY (`ID`, `PhoneNo`) USING BTREE,
  INDEX `ID`(`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 105 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of customers
-- ----------------------------
INSERT INTO `customers` VALUES (102, 'Muhammad Ibrahim Ismail', '01004125602', '20 Mohamed Basha Mohsen', 'm.ibrahim09', 'm.ibrahim99x@gmail.com');
INSERT INTO `customers` VALUES (103, 'Muhammad Ahmed', '01003661637', 'ahmed st', '', '');
INSERT INTO `customers` VALUES (104, 'Sayed Ahmed', '01007416841', '20 sidi gaber st', 'sayeddd', 'ahmedsayed@gmail.com');

-- ----------------------------
-- Table structure for orders
-- ----------------------------
DROP TABLE IF EXISTS `orders`;
CREATE TABLE `orders`  (
  `ProductID` int(11) NOT NULL,
  `CustomerID` int(11) NOT NULL,
  `OrderID` int(11) NOT NULL AUTO_INCREMENT,
  `Quantity` int(11) NOT NULL,
  `Paid` tinyint(4) NOT NULL,
  `OrderDate` datetime(0) NOT NULL,
  `Amount` int(255) NOT NULL,
  PRIMARY KEY (`OrderID`, `CustomerID`, `ProductID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 110 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of orders
-- ----------------------------
INSERT INTO `orders` VALUES (1, 102, 100, 5, 0, '2019-05-11 16:22:34', 200);
INSERT INTO `orders` VALUES (1, 102, 101, 1, 0, '2019-05-11 16:22:46', 40);
INSERT INTO `orders` VALUES (1, 102, 102, 4, 0, '2019-05-11 16:24:37', 160);
INSERT INTO `orders` VALUES (1, 102, 103, 1, 0, '2019-05-11 16:32:47', 42);
INSERT INTO `orders` VALUES (1, 102, 104, 6, 0, '2019-05-11 16:39:15', 120);
INSERT INTO `orders` VALUES (2, 102, 105, 20, 0, '2019-05-11 20:43:35', 2000);
INSERT INTO `orders` VALUES (2, 102, 106, 10, 0, '2019-05-11 20:44:31', 1000);
INSERT INTO `orders` VALUES (2, 102, 107, 1, 0, '2019-05-11 20:47:40', 100);
INSERT INTO `orders` VALUES (2, 102, 108, 1, 0, '2019-05-11 20:48:35', 100);
INSERT INTO `orders` VALUES (2, 102, 109, 1, 1, '2019-05-11 20:49:49', 100);

-- ----------------------------
-- Table structure for products
-- ----------------------------
DROP TABLE IF EXISTS `products`;
CREATE TABLE `products`  (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Name` varchar(255) CHARACTER SET utf8 COLLATE utf8_general_ci NULL DEFAULT NULL,
  `QuantityAvailable` int(11) NULL DEFAULT NULL,
  `Price` int(11) NULL DEFAULT NULL,
  PRIMARY KEY (`ID`) USING BTREE
) ENGINE = InnoDB AUTO_INCREMENT = 3 CHARACTER SET = utf8 COLLATE = utf8_general_ci ROW_FORMAT = Dynamic;

-- ----------------------------
-- Records of products
-- ----------------------------
INSERT INTO `products` VALUES (1, 'حلق اذن', 0, 40);
INSERT INTO `products` VALUES (2, 'غويشه', 7, 100);

SET FOREIGN_KEY_CHECKS = 1;
