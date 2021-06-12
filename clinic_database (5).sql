-- phpMyAdmin SQL Dump
-- version 5.0.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 12, 2021 at 07:20 AM
-- Server version: 10.4.14-MariaDB
-- PHP Version: 7.4.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `clinic_database`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer`
--

CREATE TABLE `tbl_customer` (
  `customer_id` int(100) NOT NULL,
  `invoice_number` int(11) NOT NULL,
  `customer_name` text NOT NULL,
  `customer_type` varchar(500) NOT NULL,
  `customer_address` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_customer`
--

INSERT INTO `tbl_customer` (`customer_id`, `invoice_number`, `customer_name`, `customer_type`, `customer_address`) VALUES
(1003, 0, 'wkkwewk', '', 'kskedkdk'),
(1004, 0, 'wkkwewk', '', 'kskedkdk'),
(1005, 0, 'wkkwewk', '', 'kskedkdk'),
(1006, 0, 'kkkk', '', 'sqdsk'),
(1007, 0, 'kkkk', '', 'sqdsk'),
(500001, 0, 'dfdfd999', '', ''),
(500003, 0, 'ksdkskkk', 'regular', 'skdkskd'),
(500004, 0, 'ksdkskkk', 'regular', 'skdkskd'),
(500005, 0, 'sdsds', 'regular', 'skdkskd'),
(500006, 0, '7789kkk', '', 'dfd'),
(500007, 0, 'yttt', '', 'yu'),
(500008, 0, 'Diosdado Enriquez', '', 'Angeles City'),
(500009, 0, 'Joseph Tan', '', 'Poblacion, Pampanga'),
(500010, 0, 'Akisho Uchiwara', '', 'Tokyo'),
(500011, 0, 'James Kareon', '', 'Panay City'),
(500012, 0, 'James999', '', 'Panay dkfkd'),
(500013, 0, 'Chjristtoooof', '', 'Panay dkfkd'),
(500014, 0, 'Chris Emm', '', 'Poblacion'),
(500015, 0, 'Fkdf', '', 'kkk'),
(500016, 0, 'Jomar Dela Rosa', '', 'Anunas Angeles City'),
(500017, 0, 'James Raval', 'walk-in', '12'),
(500018, 0, 'sdfslq', '', '33fdsfsdf'),
(500019, 0, 'kkk', '', 'kkl'),
(500020, 0, '88', '', '8899'),
(500021, 0, 'uuuu', '', 'uuu'),
(500022, 0, 'ooo', '', 'ooo'),
(500023, 0, 'kkkk', '', 'kkk'),
(500024, 0, 'kkkl', '', 'kkkkk'),
(500025, 0, 'kk', '', 'll'),
(500026, 0, 'kkk', '', 'kk'),
(500027, 0, 'k', '', 'k'),
(500028, 0, 'jj', 'regular', 'jjj'),
(500029, 0, 'nn', '', 'nn'),
(500030, 0, 'dfldfld', '', 'lll'),
(500031, 0, 'uuu', '', 'uuu'),
(500032, 0, 'jh', '', 'kkkk'),
(500033, 0, '', '', ''),
(500034, 0, '', '', ''),
(500035, 0, 'j', '', 'h');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_doctor`
--

CREATE TABLE `tbl_doctor` (
  `doctor_id` int(11) NOT NULL,
  `doctor_name` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_doctor`
--

INSERT INTO `tbl_doctor` (`doctor_id`, `doctor_name`) VALUES
(1, 'Dr. Diosdado Emmanuel S. Caringal'),
(2, 'Dra. Eden Caringal');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_invoice`
--

CREATE TABLE `tbl_invoice` (
  `invoice_number` int(11) NOT NULL,
  `custome_name` text NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp(),
  `prepared_by` text NOT NULL,
  `mode_of_payment` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_invoice`
--

INSERT INTO `tbl_invoice` (`invoice_number`, `custome_name`, `date`, `prepared_by`, `mode_of_payment`) VALUES
(2000000, 'Pedro Juan', '2021-04-27 00:26:27', 'John Cruz', 'GCASH'),
(2000001, 'Edriano Dela Cruz', '2021-04-29 00:27:58', 'James Agustin', 'GCASH'),
(2000002, 'Jaspher', '2021-04-29 00:33:34', 'Tio', 'GCASH'),
(2000003, 'yes', '2021-04-29 00:57:15', '', ''),
(2000004, 'ge', '2021-04-29 00:58:56', '', ''),
(2000005, 'dfd', '2021-04-29 01:00:46', '', ''),
(2000006, 'dfdfwe', '2021-04-29 15:43:18', '', ''),
(2000007, 'f', '2021-04-29 15:49:23', '', ''),
(2000008, 'dfd999', '2021-04-29 15:59:17', '', ''),
(2000009, 'dfd434343', '2021-04-29 16:00:45', '', ''),
(2000010, 'ksdkskkk', '2021-04-30 16:18:54', 'Juan Dela Cruz', 'kkkkkk'),
(2000011, 'ksdkskkk', '2021-04-30 16:19:44', 'Juan Dela Cruz', 'kkkkkk'),
(2000012, 'sdsds', '2021-04-30 16:20:11', 'Juan Dela Cruz', 'kkkkkk'),
(2000013, '7789kkk', '2021-04-30 16:26:43', 'Juan Dela Cruz', 'kkkl'),
(2000014, 'yttt', '2021-05-01 03:17:30', 'Juan Dela Cruz', 'yyy'),
(2000015, 'Diosdado Enriquez', '2021-05-01 03:49:26', 'Juan Dela Cruz', 'Padala '),
(2000016, 'Joseph Tan', '2021-05-02 15:40:07', 'Juan Dela Cruz', 'GCASH'),
(2000017, 'Akisho Uchiwara', '2021-05-05 15:00:30', 'Juan Dela Cruz', 'GCASH'),
(2000018, 'James Kareon', '2021-05-05 15:24:52', 'Juan Dela Cruz', 'Paymaya'),
(2000019, 'James999', '2021-05-05 15:25:17', 'Juan Dela Cruz', 'padala'),
(2000020, 'Chjristtoooof', '2021-05-05 15:25:45', 'Juan Dela Cruz', 'padalak'),
(2000021, 'Chris Emm', '2021-05-16 22:42:02', 'Juan Dela Cruz', 'GCASH'),
(2000022, 'Fkdf', '2021-05-16 22:42:43', 'Juan Dela Cruz', 'klll'),
(2000023, 'Jomar Dela Rosa', '2021-06-01 00:49:55', 'Juan Dela Cruz', 'GCASH'),
(2000024, 'James Raval', '2021-06-01 01:05:56', 'Juan Dela Cruz', 'Payment'),
(2000025, 'sdfslq', '2021-06-02 23:00:24', 'Juan Dela Cruz', 'mkk'),
(2000026, 'kkk', '2021-06-03 01:05:22', 'Juan Dela Cruz', 'lll'),
(2000027, '88', '2021-06-03 01:07:18', 'Juan Dela Cruz', '98'),
(2000028, 'uuuu', '2021-06-03 01:07:38', 'Juan Dela Cruz', 'uuu'),
(2000029, 'ooo', '2021-06-03 01:09:53', 'Juan Dela Cruz', 'oo'),
(2000030, 'kkkk', '2021-06-03 01:10:12', 'Juan Dela Cruz', 'jjjk'),
(2000031, 'kkkl', '2021-06-03 01:12:36', 'Juan Dela Cruz', 'kkk'),
(2000032, 'kk', '2021-06-03 01:20:57', 'Juan Dela Cruz', 'k'),
(2000033, 'kkk', '2021-06-03 01:21:44', 'Juan Dela Cruz', 'll'),
(2000034, 'k', '2021-06-03 01:22:23', 'Juan Dela Cruz', 'k'),
(2000035, 'jj', '2021-06-03 01:49:27', 'Juan Dela Cruz', 'kk'),
(2000036, 'nn', '2021-06-03 01:51:36', 'Juan Dela Cruz', 'nn'),
(2000037, 'dfldfld', '2021-06-03 01:54:23', 'Juan Dela Cruz', 'll'),
(2000038, 'uuu', '2021-06-03 01:54:51', 'Juan Dela Cruz', 'uu'),
(2000039, 'jh', '2021-06-07 14:18:55', 'Juan Dela Cruz', 'jjj'),
(2000040, '', '2021-06-09 10:01:12', '', ''),
(2000041, '', '2021-06-09 10:01:41', '', ''),
(2000042, 'j', '2021-06-09 10:14:06', 'Juan Dela Cruz', 'h');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_list_service`
--

CREATE TABLE `tbl_list_service` (
  `id_list_service` int(11) NOT NULL,
  `service_name` text NOT NULL,
  `invoice_number` int(11) NOT NULL,
  `doctor_name` text NOT NULL,
  `price` decimal(10,0) NOT NULL,
  `date` timestamp NOT NULL DEFAULT current_timestamp(),
  `quantity` int(11) NOT NULL,
  `total` double NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_list_service`
--

INSERT INTO `tbl_list_service` (`id_list_service`, `service_name`, `invoice_number`, `doctor_name`, `price`, `date`, `quantity`, `total`) VALUES
(1, 'Medical Certificate', 2000015, 'Dr. Diosdado Emmanuel S. Caringal', '600', '2021-07-21 03:49:26', 1, 600),
(2, 'Professional Fee + Procedure', 2000016, 'Dr. Diosdado Emmanuel S. Caringal', '500', '2021-05-02 15:40:07', 1, 500),
(3, 'Antibiotics', 2000016, 'Dr. Diosdado Emmanuel S. Caringal', '3006', '2021-05-02 15:40:07', 3, 9018),
(4, 'ksdksk', 2000016, 'Dr. Diosdado Emmanuel S. Caringal', '889', '2021-05-02 15:40:07', 1, 889),
(5, 'Professional Fee + Procedure', 2000017, 'Dr. Diosdado Emmanuel S. Caringal', '500', '2021-05-05 15:00:30', 1, 500),
(6, 'dentist', 2000017, 'Dr. Diosdado Emmanuel S. Caringal', '8666', '2021-05-05 15:00:31', 1, 8666),
(7, 'oii', 2000017, 'Dr. Diosdado Emmanuel S. Caringal', '98', '2021-05-05 15:00:31', 1, 98),
(8, 'ksdksk', 2000017, 'Dr. Diosdado Emmanuel S. Caringal', '889', '2021-05-05 15:00:31', 1, 889),
(9, 'Medical Certificate', 2000017, 'Dr. Diosdado Emmanuel S. Caringal', '600', '2021-05-05 15:00:31', 2, 1200),
(10, 'test02', 2000017, 'Dr. Diosdado Emmanuel S. Caringal', '34', '2021-05-05 15:00:31', 1, 34),
(11, 'Medical Certificate', 2000018, 'Dra. Eden Caringal', '600', '2021-05-05 15:24:52', 2, 1200),
(12, 'Antibiotics', 2000018, 'Dra. Eden Caringal', '3006', '2021-05-05 15:24:52', 1, 3006),
(13, 'Professional Fee + Procedure', 2000018, 'Dra. Eden Caringal', '500', '2021-05-05 15:24:52', 1, 500),
(14, 'ksdksk', 2000018, 'Dra. Eden Caringal', '889', '2021-05-05 15:24:52', 1, 889),
(15, 'Medical Certificate', 2000019, 'Dra. Eden Caringal', '600', '2021-05-05 15:25:17', 3, 1800),
(16, 'Antibiotics', 2000019, 'Dra. Eden Caringal', '3006', '2021-05-05 15:25:17', 1, 3006),
(17, 'Professional Fee + Procedure', 2000019, 'Dra. Eden Caringal', '500', '2021-05-05 15:25:17', 1, 500),
(18, 'ksdksk', 2000019, 'Dra. Eden Caringal', '889', '2021-05-05 15:25:17', 1, 889),
(19, 'dentist', 2000019, 'Dra. Eden Caringal', '8666', '2021-05-05 15:25:17', 1, 8666),
(20, 'Medical Certificate', 2000020, 'Dra. Eden Caringal', '600', '2021-05-05 15:25:45', 3, 1800),
(21, 'Antibiotics', 2000020, 'Dra. Eden Caringal', '3006', '2021-05-24 15:25:45', 1, 3006),
(22, 'Professional Fee + Procedure', 2000020, 'Dra. Eden Caringal', '500', '2021-05-05 15:25:45', 1, 500),
(23, 'ksdksk', 2000020, 'Dra. Eden Caringal', '889', '2021-06-15 21:31:24', 1, 889),
(24, 'dentist', 2000020, 'Dra. Eden Caringal', '845', '2021-06-16 15:25:45', 1, 845),
(25, 'Detox', 2000021, 'Dr. Diosdado Emmanuel S. Caringal', '340', '2021-06-22 22:42:02', 1, 340),
(26, 'ECG', 2000021, 'Dr. Diosdado Emmanuel S. Caringal', '8660', '2021-05-16 22:42:02', 1, 8660),
(27, 'Medical Certificate', 2000021, 'Dr. Diosdado Emmanuel S. Caringal', '600', '2021-05-16 22:42:02', 1, 600),
(28, 'Paracetamol', 2000021, 'Dr. Diosdado Emmanuel S. Caringal', '300', '2021-05-16 22:42:02', 1, 300),
(29, 'Detox', 2000022, 'Dr. Diosdado Emmanuel S. Caringal', '340', '2021-05-16 22:42:43', 1, 340),
(30, 'Moexipril', 2000022, 'Dr. Diosdado Emmanuel S. Caringal', '200', '2021-05-16 22:42:43', 1, 200),
(31, 'Medical Certificate', 2000023, 'Dr. Diosdado Emmanuel S. Caringal', '600', '2021-06-01 00:49:55', 1, 600),
(32, 'Benazepril', 2000023, 'Dr. Diosdado Emmanuel S. Caringal', '976', '2021-06-01 00:49:55', 1, 976),
(33, 'ECG', 2000023, 'Dr. Diosdado Emmanuel S. Caringal', '8660', '2021-06-01 00:49:55', 1, 8660),
(34, 'Paracetamol', 2000023, 'Dr. Diosdado Emmanuel S. Caringal', '300', '2021-06-01 00:49:55', 1, 300),
(35, 'Medical checkup', 2000023, 'Dr. Diosdado Emmanuel S. Caringal', '8660', '2021-06-01 00:49:55', 1, 8660),
(36, 'Blood Test', 2000023, 'Dr. Diosdado Emmanuel S. Caringal', '8660', '2021-06-01 00:49:55', 1, 8660),
(37, 'Detox', 2000024, 'Dra. Eden Caringal', '340', '2021-06-01 01:05:56', 1, 340),
(38, 'Professional Fee + Procedure', 2000025, 'Dr. Diosdado Emmanuel S. Caringal', '500', '2021-06-02 23:00:24', 1, 500),
(39, 'Detox', 2000025, 'Dr. Diosdado Emmanuel S. Caringal', '340', '2021-06-02 23:00:24', 1, 340),
(40, 'ECG', 2000025, 'Dr. Diosdado Emmanuel S. Caringal', '8660', '2021-06-02 23:00:24', 1, 8660),
(41, 'ksdksk', 2000026, 'Dr. Diosdado Emmanuel S. Caringal', '889', '2021-06-03 01:05:22', 5, 4445),
(42, 'Professional Fee + Procedure', 2000027, 'Dr. Diosdado Emmanuel S. Caringal', '500', '2021-06-03 01:07:18', 3, 1500),
(43, '', 2000028, 'Dr. Diosdado Emmanuel S. Caringal', '500', '2021-06-03 01:07:38', 1, 500),
(44, 'Antibiotics', 2000028, 'Dr. Diosdado Emmanuel S. Caringal', '3006', '2021-06-03 01:07:38', 10, 30060),
(45, 'Medical Certificate', 2000029, 'Dr. Diosdado Emmanuel S. Caringal', '600', '2021-06-03 01:09:53', 7, 4200),
(46, 'Professional Fee + Procedure', 2000030, 'Dr. Diosdado Emmanuel S. Caringal', '500', '2021-06-03 01:10:12', 14, 7000),
(47, 'Professional Fee + Procedure', 2000031, 'Dr. Diosdado Emmanuel S. Caringal', '500', '2021-06-03 01:12:36', 6, 3000),
(48, 'Medical Certificate', 2000032, 'Dra. Eden Caringal', '600', '2021-06-03 01:20:57', 1, 600),
(49, 'Medical Certificate', 2000033, 'Dra. Eden Caringal', '400', '2021-06-03 01:21:44', 1, 400),
(50, 'Antibiotics', 2000033, 'Dra. Eden Caringal', '600', '2021-06-03 01:21:44', 1, 600),
(51, 'Antibiotics', 2000034, 'Dra. Eden Caringal', '500', '2021-06-03 01:22:23', 2, 1000),
(52, 'Professional Fee + Procedure', 2000035, 'Dr. Diosdado Emmanuel S. Caringal', '500', '2021-06-03 01:49:27', 3, 1500),
(53, 'Medical Certificate', 2000036, 'Dr. Diosdado Emmanuel S. Caringal', '600', '2021-06-03 01:51:36', 2, 1200),
(54, 'Blood Test', 2000037, 'Dr. Diosdado Emmanuel S. Caringal', '8660', '2021-06-03 01:54:23', 1, 8660),
(55, 'dentist', 2000037, 'Dr. Diosdado Emmanuel S. Caringal', '8890', '2021-06-03 01:54:23', 1, 8890),
(56, 'Professional Fee + Procedure', 2000038, 'Dr. Diosdado Emmanuel S. Caringal', '500', '2021-06-03 01:54:51', 2, 1000),
(57, 'Professional Fee + Procedure', 2000039, 'Dr. Diosdado Emmanuel S. Caringal', '500', '2021-06-07 14:18:55', 1, 500),
(58, 'Blood Test', 2000040, '', '8660', '2021-06-09 10:01:12', 2, 17320),
(59, 'Paracetamol', 2000040, '', '300', '2021-06-09 10:01:12', 1, 300),
(60, 'Professional Fee + Procedure', 2000042, 'Dr. Diosdado Emmanuel S. Caringal', '500', '2021-06-09 10:14:06', 4, 2000),
(61, 'Paracetamol', 2000042, 'Dr. Diosdado Emmanuel S. Caringal', '300', '2021-06-09 10:14:06', 3, 900),
(62, 'Blood Test', 2000042, 'Dr. Diosdado Emmanuel S. Caringal', '8660', '2021-06-09 10:14:06', 2, 17320);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_secretary`
--

CREATE TABLE `tbl_secretary` (
  `secretary_id` int(11) NOT NULL,
  `secretary_name` text NOT NULL,
  `sec_user_name` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_secretary`
--

INSERT INTO `tbl_secretary` (`secretary_id`, `secretary_name`, `sec_user_name`, `password`) VALUES
(1, 'Juan Dela Cruz', 'abc', 'abc');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_service`
--

CREATE TABLE `tbl_service` (
  `service_id` int(11) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `service_name` text NOT NULL,
  `service_fee` double NOT NULL,
  `type` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_service`
--

INSERT INTO `tbl_service` (`service_id`, `doctor_id`, `service_name`, `service_fee`, `type`) VALUES
(5, 1, 'Professional Fee + Procedure', 500, 'Service'),
(6, 1, 'Medical Certificate', 600, 'Service'),
(27, 1, 'Antibiotics', 3006, 'Medicine'),
(30, 1, 'Antibiotics', 3006, 'Service'),
(52, 1, 'Paracetamol', 300, 'Medicine'),
(53, 1, 'Detox', 340, 'Medicine'),
(54, 1, 'Benazepril', 976, 'Medicine'),
(55, 1, 'Moexipril', 200, 'Medicine'),
(57, 1, 'Medical checkup', 8660, 'Service'),
(58, 1, 'ECG', 8660, 'Lab'),
(59, 1, 'Blood Test', 8660, 'Lab'),
(62, 1, 'ksdksk', 889, 'Lab'),
(63, 1, 'dentist', 8890, 'Lab');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `user_id` int(11) NOT NULL,
  `name` text NOT NULL,
  `password` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`user_id`, `name`, `password`) VALUES
(1, 'lll', 'kuj'),
(2, 'wkfdk', 'kkdsd'),
(3, 'dfekkk', 'kkk'),
(5, 'admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `tbl_doctor`
--
ALTER TABLE `tbl_doctor`
  ADD PRIMARY KEY (`doctor_id`);

--
-- Indexes for table `tbl_invoice`
--
ALTER TABLE `tbl_invoice`
  ADD PRIMARY KEY (`invoice_number`);

--
-- Indexes for table `tbl_list_service`
--
ALTER TABLE `tbl_list_service`
  ADD PRIMARY KEY (`id_list_service`);

--
-- Indexes for table `tbl_secretary`
--
ALTER TABLE `tbl_secretary`
  ADD PRIMARY KEY (`secretary_id`);

--
-- Indexes for table `tbl_service`
--
ALTER TABLE `tbl_service`
  ADD PRIMARY KEY (`service_id`),
  ADD KEY `doctor_id` (`doctor_id`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`user_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  MODIFY `customer_id` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=500036;

--
-- AUTO_INCREMENT for table `tbl_doctor`
--
ALTER TABLE `tbl_doctor`
  MODIFY `doctor_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `tbl_invoice`
--
ALTER TABLE `tbl_invoice`
  MODIFY `invoice_number` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2000043;

--
-- AUTO_INCREMENT for table `tbl_list_service`
--
ALTER TABLE `tbl_list_service`
  MODIFY `id_list_service` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=63;

--
-- AUTO_INCREMENT for table `tbl_secretary`
--
ALTER TABLE `tbl_secretary`
  MODIFY `secretary_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;

--
-- AUTO_INCREMENT for table `tbl_service`
--
ALTER TABLE `tbl_service`
  MODIFY `service_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=64;

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `user_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_service`
--
ALTER TABLE `tbl_service`
  ADD CONSTRAINT `tbl_service_ibfk_1` FOREIGN KEY (`doctor_id`) REFERENCES `tbl_doctor` (`doctor_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
