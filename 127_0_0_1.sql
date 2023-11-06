-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 20, 2022 at 12:27 AM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 7.3.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `wel3a`
--
DROP DATABASE IF EXISTS `wel3a`;
CREATE DATABASE IF NOT EXISTS `wel3a` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `wel3a`;

-- --------------------------------------------------------

--
-- Table structure for table `accounts`
--

DROP TABLE IF EXISTS `accounts`;
CREATE TABLE IF NOT EXISTS `accounts` (
  `account_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(200) NOT NULL,
  `password` varchar(200) NOT NULL,
  `name` varchar(200) NOT NULL,
  `account_type` varchar(200) NOT NULL,
  PRIMARY KEY (`account_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `accounts`
--

INSERT INTO `accounts` (`account_id`, `username`, `password`, `name`, `account_type`) VALUES
(1, 'h', 'h', 'Eng. Hend', 'Admin')

-- --------------------------------------------------------

--
-- Table structure for table `account_rights`
--

DROP TABLE IF EXISTS `account_rights`;
CREATE TABLE IF NOT EXISTS `account_rights` (
  `right_id` int(11) NOT NULL AUTO_INCREMENT,
  `right_type` varchar(5) NOT NULL,
  `money_paid` decimal(9,3) NOT NULL,
  `start_date_of_right` varchar(20) NOT NULL,
  `end_date_of_right` varchar(20) NOT NULL,
  `account_id` int(11) NOT NULL,
  `describtion` text DEFAULT NULL,
  PRIMARY KEY (`right_id`),
  KEY `account_id` (`account_id`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `account_rights`
--

INSERT INTO `account_rights` (`right_id`, `right_type`, `money_paid`, `start_date_of_right`, `end_date_of_right`, `account_id`, `describtion`) VALUES
(1, 'Buy', '1500.000', '', '', 1, NULL)

-- --------------------------------------------------------

--
-- Table structure for table `customers`
--

DROP TABLE IF EXISTS `customers`;
CREATE TABLE IF NOT EXISTS `customers` (
  `customer_id` int(11) NOT NULL,
  `customer_name` varchar(200) NOT NULL,
  `customer_phone` varchar(15) NOT NULL,
  `customer_notes` text NOT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `customers`
--

INSERT INTO `customers` (`customer_id`, `customer_name`, `customer_phone`, `customer_notes`) VALUES
(1, 'عيل خارجي', '01022028317', '');

-- --------------------------------------------------------

--
-- Table structure for table `invoices`
--

DROP TABLE IF EXISTS `invoices`;
CREATE TABLE IF NOT EXISTS `invoices` (
  `invoice_id` int(11) NOT NULL,
  `invoice_number` int(11) NOT NULL,
  `invoice_date` varchar(15) NOT NULL,
  `invoice_total` decimal(9,3) NOT NULL,
  `customer_id` int(11) NOT NULL,
  `invoice_paid` decimal(9,3) NOT NULL,
  `invoice_rest` decimal(9,3) NOT NULL,
  `account_id` int(11) NOT NULL,
  PRIMARY KEY (`invoice_id`),
  KEY `supplier_id` (`customer_id`),
  KEY `account_id` (`account_id`,`invoice_number`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Dumping data for table `invoices`
--

INSERT INTO `invoices` (`invoice_id`, `invoice_number`, `invoice_date`, `invoice_total`, `customer_id`, `invoice_paid`, `invoice_rest`, `account_id`) VALUES
(1, 1, '17-09-2022', '20.000', 1, '20.000', '0.000', 1),
(2, 2, '17-09-2022', '30.000', 1, '30.000', '0.000', 1),
(3, 1, '17-09-2022', '50.000', 1, '50.000', '0.000', 2),
(4, 3, '17-09-2022', '20.000', 1, '20.000', '0.000', 1);

-- --------------------------------------------------------

--
-- Table structure for table `items`
--

DROP TABLE IF EXISTS `items`;
CREATE TABLE IF NOT EXISTS `items` (
  `item_id` int(11) NOT NULL AUTO_INCREMENT,
  `title_id` int(11) NOT NULL,
  `item_price` decimal(9,2) DEFAULT NULL,
  `item_name` varchar(200) NOT NULL,
  PRIMARY KEY (`item_id`),
  KEY `item_id` (`title_id`)
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `items`
--

INSERT INTO `items` (`item_id`, `title_id`, `item_price`, `item_name`) VALUES
(1, 1, '10.00', 'طبق فول'),
(2, 1, '15.00', 'طبق فول كبير'),
(3, 1, '10.00', 'طبق فلافل'),
(4, 1, '15.00', 'طبق فلافل كبير'),
(5, 1, '7.00', 'طبق رز بلبن'),
(6, 1, '10.00', 'طبق رز بلبن كبير'),
(7, 1, '10.00', 'طبق مسقعة'),
(11, 1, '15.00', 'طبق مسقعة كبير');

-- --------------------------------------------------------

--
-- Table structure for table `items_titles`
--

DROP TABLE IF EXISTS `items_titles`;
CREATE TABLE IF NOT EXISTS `items_titles` (
  `title_id` int(11) NOT NULL AUTO_INCREMENT,
  `item_name` varchar(200) NOT NULL,
  PRIMARY KEY (`title_id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `items_titles`
--

INSERT INTO `items_titles` (`title_id`, `item_name`) VALUES
(1, 'أطباق');

-- --------------------------------------------------------

--
-- Table structure for table `money_movings`
--

DROP TABLE IF EXISTS `money_movings`;
CREATE TABLE IF NOT EXISTS `money_movings` (
  `moving_id` int(11) NOT NULL AUTO_INCREMENT,
  `moving_date` varchar(15) NOT NULL,
  `moving_value` decimal(9,3) NOT NULL,
  `moving_direction` text NOT NULL,
  `moving_hint` text NOT NULL,
  `account_id` int(11) NOT NULL,
  `moving_type` varchar(10) NOT NULL,
  PRIMARY KEY (`moving_id`),
  KEY `account_id` (`account_id`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `money_movings`
--

INSERT INTO `money_movings` (`moving_id`, `moving_date`, `moving_value`, `moving_direction`, `moving_hint`, `account_id`, `moving_type`) VALUES
(1, '17-09-2022', '20.000', 'عيل خارجي', 'فاتورة', 1, 'متحصلات'),
(2, '17-09-2022', '30.000', 'عيل خارجي', 'فاتورة', 1, 'متحصلات'),
(3, '17-09-2022', '50.000', 'عيل خارجي', 'فاتورة', 2, 'متحصلات'),
(10, '17-09-2022', '20.000', 'عيل خارجي', 'فاتورة', 1, 'متحصلات'),
(13, '17-09-2022', '50.000', 'الخزينة', 'ترحيل', 2, 'مصروفات'),
(14, '18-09-2022', '50.000', 'الخزينة', 'مرحل', 2, 'متحصلات'),
(15, '17-09-2022', '70.000', 'الخزينة', 'ترحيل', 1, 'مصروفات'),
(16, '18-09-2022', '70.000', 'الخزينة', 'مرحل', 1, 'متحصلات');

-- --------------------------------------------------------

--
-- Table structure for table `selling_invoice_lines`
--

DROP TABLE IF EXISTS `selling_invoice_lines`;
CREATE TABLE IF NOT EXISTS `selling_invoice_lines` (
  `line_id` int(11) NOT NULL AUTO_INCREMENT,
  `invoice_id` int(11) NOT NULL,
  `item_id` int(11) NOT NULL,
  `line_sell_price` decimal(9,3) NOT NULL,
  `line_quantity` decimal(9,3) NOT NULL,
  PRIMARY KEY (`line_id`),
  KEY `invoice_id` (`invoice_id`),
  KEY `product_id` (`item_id`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8;

--
-- Dumping data for table `selling_invoice_lines`
--

INSERT INTO `selling_invoice_lines` (`line_id`, `invoice_id`, `item_id`, `line_sell_price`, `line_quantity`) VALUES
(1, 1, 1, '10.000', '2.000'),
(2, 2, 1, '10.000', '3.000'),
(3, 3, 1, '10.000', '5.000'),
(4, 4, 1, '10.000', '2.000');

--
-- Constraints for dumped tables
--

--
-- Constraints for table `account_rights`
--
ALTER TABLE `account_rights`
  ADD CONSTRAINT `account_rights_ibfk_1` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `invoices`
--
ALTER TABLE `invoices`
  ADD CONSTRAINT `invoices_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customers` (`customer_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `invoices_ibfk_2` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `items`
--
ALTER TABLE `items`
  ADD CONSTRAINT `items_ibfk_1` FOREIGN KEY (`title_id`) REFERENCES `items_titles` (`title_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `money_movings`
--
ALTER TABLE `money_movings`
  ADD CONSTRAINT `money_movings_ibfk_1` FOREIGN KEY (`account_id`) REFERENCES `accounts` (`account_id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `selling_invoice_lines`
--
ALTER TABLE `selling_invoice_lines`
  ADD CONSTRAINT `selling_invoice_lines_ibfk_1` FOREIGN KEY (`invoice_id`) REFERENCES `invoices` (`invoice_id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `selling_invoice_lines_ibfk_2` FOREIGN KEY (`item_id`) REFERENCES `items` (`item_id`) ON DELETE CASCADE ON UPDATE CASCADE;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
