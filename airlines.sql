-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 28, 2024 at 05:58 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `airlines`
--

-- --------------------------------------------------------

--
-- Table structure for table `flight`
--

CREATE TABLE `flight` (
  `id` int(11) NOT NULL,
  `departure` varchar(320) NOT NULL,
  `destination` varchar(320) NOT NULL,
  `passengers` int(11) NOT NULL,
  `plane_id` int(11) NOT NULL,
  `suggested_timestamp` int(11) NOT NULL,
  `departure_timestamp` int(11) NOT NULL,
  `destination_timestamp` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `flight`
--

INSERT INTO `flight` (`id`, `departure`, `destination`, `passengers`, `plane_id`, `suggested_timestamp`, `departure_timestamp`, `destination_timestamp`) VALUES
(1, 'Саранск', 'Москва', 3, 1, 1716890732, 0, 0),
(2, 'Москва', 'Саранск', 562, 3, 1718188057, 1716854400, 1717113600);

-- --------------------------------------------------------

--
-- Table structure for table `load`
--

CREATE TABLE `load` (
  `id` int(11) NOT NULL,
  `flight_id` int(11) NOT NULL,
  `weight` int(11) NOT NULL,
  `description` text NOT NULL,
  `customer_user_id` int(11) NOT NULL,
  `price` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `load`
--

INSERT INTO `load` (`id`, `flight_id`, `weight`, `description`, `customer_user_id`, `price`) VALUES
(2, 2, 56, 'Пример описания', 9, 1234),
(3, 2, 56, 'Пример описания', 9, 1234);

-- --------------------------------------------------------

--
-- Table structure for table `plane`
--

CREATE TABLE `plane` (
  `id` int(11) NOT NULL,
  `model` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `plane`
--

INSERT INTO `plane` (`id`, `model`) VALUES
(1, 'Airbus-A310'),
(2, 'Airbus-A330'),
(3, 'Boeing-757');

-- --------------------------------------------------------

--
-- Table structure for table `role`
--

CREATE TABLE `role` (
  `id` int(11) NOT NULL,
  `name` varchar(96) NOT NULL DEFAULT 'Пассажир',
  `level` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `role`
--

INSERT INTO `role` (`id`, `name`, `level`) VALUES
(1, 'Пассажир', 0),
(2, 'Экспедитор', 1),
(3, 'Диспетчер', 2),
(4, 'Руководитель', 3);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(64) NOT NULL,
  `password_hash` text NOT NULL,
  `role_id` int(11) NOT NULL,
  `surname` varchar(32) NOT NULL,
  `name` varchar(32) NOT NULL,
  `middlename` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password_hash`, `role_id`, `surname`, `name`, `middlename`) VALUES
(3, 'admin', '21232f297a57a5a743894a0e4a801fc3', 4, 'Ефимов', 'Севастьян', 'Дамирович'),
(4, 'exp1', 'a03936a341bded3004cc5d039a7cfa37', 2, 'Николаев', 'Валентин', 'Онисимович'),
(5, 'flightoperator', '5ec740146a77c1f72e9aff8ae1341b57', 3, 'Виноградов', 'Валерий', 'Евсеевич'),
(6, 'kozlov21', 'a486e405f0436cb02747d39fa47ebd15', 1, 'Козлов', 'Константин', 'Эдуардович'),
(7, 'm_agaf', 'a4cf8935b06808a1aa753cf0bc111a16', 1, 'Молчанов', 'Степан', 'Агафонович'),
(8, 'abramabram', '9c36193701274ff0548164da7efd0b7b', 1, 'Ефимов', 'Абрам', 'Юлианович'),
(9, 'test', '098f6bcd4621d373cade4e832627b4f6', 1, 'Пупкин', 'Василий', 'Тестович');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `flight`
--
ALTER TABLE `flight`
  ADD PRIMARY KEY (`id`),
  ADD KEY `flight_plane_id_` (`plane_id`);

--
-- Indexes for table `load`
--
ALTER TABLE `load`
  ADD PRIMARY KEY (`id`),
  ADD KEY `load_flight_id_` (`flight_id`),
  ADD KEY `load_customer_user_id_` (`customer_user_id`);

--
-- Indexes for table `plane`
--
ALTER TABLE `plane`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_role_id_` (`role_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `flight`
--
ALTER TABLE `flight`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `load`
--
ALTER TABLE `load`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `plane`
--
ALTER TABLE `plane`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `role`
--
ALTER TABLE `role`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `flight`
--
ALTER TABLE `flight`
  ADD CONSTRAINT `flight_plane_id_` FOREIGN KEY (`plane_id`) REFERENCES `plane` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `load`
--
ALTER TABLE `load`
  ADD CONSTRAINT `load_customer_user_id_` FOREIGN KEY (`customer_user_id`) REFERENCES `user` (`id`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `load_flight_id_` FOREIGN KEY (`flight_id`) REFERENCES `flight` (`id`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_role_id_` FOREIGN KEY (`role_id`) REFERENCES `role` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
