/*
 Navicat Premium Data Transfer

 Source Server         : mariadb_localhost
 Source Server Type    : MariaDB
 Source Server Version : 100211
 Source Host           : localhost:3306
 Source Schema         : yasm_db

 Target Server Type    : MariaDB
 Target Server Version : 100211
 File Encoding         : 65001

 Date: 06/05/2018 18:06:29
*/

SET NAMES utf8mb4;
SET FOREIGN_KEY_CHECKS = 0;

-- ----------------------------
-- Table structure for user
-- ----------------------------
DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `login` varchar(255) DEFAULT NULL,
  `password` varchar(255) DEFAULT NULL,
  `first_name` varchar(255) DEFAULT NULL,
  `last_name` varchar(255) DEFAULT NULL,
  `email` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=utf8;

-- ----------------------------
-- Records of user
-- ----------------------------
BEGIN;
INSERT INTO `user` VALUES (1, 'geo', 'azerty', 'geovani', 'anoman', 'g.anoman@gmail.com');
INSERT INTO `user` VALUES (2, 'step', 'azerty', 'stephane', 'ouattara', 's.ouattara@gmail.com');
INSERT INTO `user` VALUES (3, 'yasm', 'azerty', 'yasm a', 'tychou', 'y.tychou@gmail.com');
INSERT INTO `user` VALUES (4, 'line', 'azerty', 'linda', 'anoman', 'l.anoman@gmail.co');
INSERT INTO `user` VALUES (5, 'ulrich', 'azerty', 'ulrich', 'fossou', 'u.fossou@gmail.com');
COMMIT;

SET FOREIGN_KEY_CHECKS = 1;
