-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 05, 2020 at 05:51 PM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `virtual_class_v1`
--

-- --------------------------------------------------------

--
-- Table structure for table `ans_vc_users`
--

CREATE TABLE `ans_vc_users` (
  `Id` int(11) NOT NULL,
  `First_Name` varchar(50) DEFAULT NULL,
  `Last_Name` varchar(50) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Profile_Picture_URL` longtext DEFAULT NULL,
  `Contact_Number` char(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `ans_vc_users`
--

INSERT INTO `ans_vc_users` (`Id`, `First_Name`, `Last_Name`, `Email`, `Profile_Picture_URL`, `Contact_Number`) VALUES
(1, 'John', 'Kane', 'a.b@c.com', 'someURL', '0777123456');

-- --------------------------------------------------------

--
-- Table structure for table `owner`
--

CREATE TABLE `owner` (
  `OwnerId` char(36) NOT NULL,
  `Name` varchar(60) CHARACTER SET utf8 NOT NULL,
  `DateOfBirth` date NOT NULL,
  `Address` varchar(100) CHARACTER SET utf8 NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `owner`
--

INSERT INTO `owner` (`OwnerId`, `Name`, `DateOfBirth`, `Address`) VALUES
('24fd81f8-d58a-4bcc-9f35-dc6cd5641906', 'John Keen', '1980-12-05', '61 Wellfield Road'),
('261e1685-cf26-494c-b17c-3546e65f5620', 'Anna Bosh', '1974-11-14', '27 Colored Row'),
('a3c1880c-674c-4d18-8f91-5d3608a2c937', 'Sam Query', '1990-04-22', '91 Western Roads'),
('f98e4d74-0f68-4aac-89fd-047f1aaca6b6', 'Martin Miller', '1983-05-21', '3 Edgar Buildings');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `ans_vc_users`
--
ALTER TABLE `ans_vc_users`
  ADD PRIMARY KEY (`Id`),
  ADD UNIQUE KEY `email_UNIQUE` (`Email`);

--
-- Indexes for table `owner`
--
ALTER TABLE `owner`
  ADD PRIMARY KEY (`OwnerId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `ans_vc_users`
--
ALTER TABLE `ans_vc_users`
  MODIFY `Id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
