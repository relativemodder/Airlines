-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1
-- Время создания: Май 27 2024 г., 13:09
-- Версия сервера: 10.4.32-MariaDB
-- Версия PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `airlines`
--

-- --------------------------------------------------------

--
-- Структура таблицы `flight`
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

-- --------------------------------------------------------

--
-- Структура таблицы `load`
--

CREATE TABLE `load` (
  `id` int(11) NOT NULL,
  `flight_id` int(11) NOT NULL,
  `weight` int(11) NOT NULL,
  `description` text NOT NULL,
  `customer_user_id` int(11) NOT NULL,
  `price` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Структура таблицы `plane`
--

CREATE TABLE `plane` (
  `id` int(11) NOT NULL,
  `model` varchar(90) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `plane`
--

INSERT INTO `plane` (`id`, `model`) VALUES
(1, 'Airbus-A310'),
(2, 'Airbus-A330');

-- --------------------------------------------------------

--
-- Структура таблицы `role`
--

CREATE TABLE `role` (
  `id` int(11) NOT NULL,
  `name` varchar(96) NOT NULL DEFAULT 'Пассажир',
  `level` int(11) NOT NULL DEFAULT 0
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Дамп данных таблицы `role`
--

INSERT INTO `role` (`id`, `name`, `level`) VALUES
(1, 'Пассажир', 0),
(2, 'Экспедитор', 1),
(3, 'Диспетчер', 2),
(4, 'Руководитель', 3);

-- --------------------------------------------------------

--
-- Структура таблицы `user`
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
-- Дамп данных таблицы `user`
--

INSERT INTO `user` (`id`, `username`, `password_hash`, `role_id`, `surname`, `name`, `middlename`) VALUES
(3, 'admin', '21232f297a57a5a743894a0e4a801fc3', 4, 'Ефимов', 'Севастьян', 'Дамирович'),
(4, 'exp1', 'a03936a341bded3004cc5d039a7cfa37', 2, 'Николаев', 'Валентин', 'Онисимович'),
(5, 'flightmanager', 'b2251367bbce7dcd9b8c99081e49eb20', 3, 'Виноградов', 'Валерий', 'Евсеевич'),
(6, 'kozlov21', 'a486e405f0436cb02747d39fa47ebd15', 1, 'Козлов', 'Константин', 'Эдуардович'),
(7, 'm_agaf', 'a4cf8935b06808a1aa753cf0bc111a16', 1, 'Молчанов', 'Степан', 'Агафонович'),
(8, 'abramabram', '9c36193701274ff0548164da7efd0b7b', 1, 'Ефимов', 'Абрам', 'Юлианович');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `flight`
--
ALTER TABLE `flight`
  ADD PRIMARY KEY (`id`),
  ADD KEY `flight_plane_id_` (`plane_id`);

--
-- Индексы таблицы `load`
--
ALTER TABLE `load`
  ADD PRIMARY KEY (`id`),
  ADD KEY `load_flight_id_` (`flight_id`),
  ADD KEY `load_customer_user_id_` (`customer_user_id`);

--
-- Индексы таблицы `plane`
--
ALTER TABLE `plane`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `role`
--
ALTER TABLE `role`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD KEY `user_role_id_` (`role_id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `flight`
--
ALTER TABLE `flight`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `load`
--
ALTER TABLE `load`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT для таблицы `plane`
--
ALTER TABLE `plane`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT для таблицы `role`
--
ALTER TABLE `role`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT для таблицы `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `flight`
--
ALTER TABLE `flight`
  ADD CONSTRAINT `flight_plane_id_` FOREIGN KEY (`plane_id`) REFERENCES `plane` (`id`);

--
-- Ограничения внешнего ключа таблицы `load`
--
ALTER TABLE `load`
  ADD CONSTRAINT `load_customer_user_id_` FOREIGN KEY (`customer_user_id`) REFERENCES `user` (`id`),
  ADD CONSTRAINT `load_flight_id_` FOREIGN KEY (`flight_id`) REFERENCES `flight` (`id`);

--
-- Ограничения внешнего ключа таблицы `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_role_id_` FOREIGN KEY (`role_id`) REFERENCES `role` (`id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
