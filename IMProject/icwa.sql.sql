-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Mar 15, 2024 at 12:31 PM
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
-- Database: `icwa`
--

-- --------------------------------------------------------

--
-- Stand-in structure for view `customer_payment_methods`
-- (See below for the actual view)
--
CREATE TABLE `customer_payment_methods` (
`customer_id` int(11)
,`customer_name` varchar(50)
,`customer_phone` int(11)
,`customer_address` varchar(99)
,`payment_id` int(11)
,`payment_title` varchar(50)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `customer_transaction_delivery_status`
-- (See below for the actual view)
--
CREATE TABLE `customer_transaction_delivery_status` (
`customer_id` int(11)
,`customer_name` varchar(50)
,`customer_address` varchar(99)
,`transaction_id` int(11)
,`transaction_date` date
,`delivery_status` varchar(50)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `customer_transaction_total`
-- (See below for the actual view)
--
CREATE TABLE `customer_transaction_total` (
`customer_id` int(11)
,`customer_name` varchar(50)
,`customer_phone` int(11)
,`customer_address` varchar(99)
,`total_transaction_amount` decimal(32,2)
);

-- --------------------------------------------------------

--
-- Stand-in structure for view `employee_transaction_details`
-- (See below for the actual view)
--
CREATE TABLE `employee_transaction_details` (
`employee_id` int(11)
,`employee_name` varchar(50)
,`employee_phone` int(11)
,`employee_role` varchar(50)
,`transaction_id` int(11)
,`customer_id` int(11)
,`transaction_date` date
,`payment_method` int(11)
,`total_amount` decimal(10,2)
,`transaction_status` varchar(50)
);

-- --------------------------------------------------------

--
-- Table structure for table `login`
--

CREATE TABLE `login` (
  `username` varchar(30) DEFAULT NULL,
  `password` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `login`
--

INSERT INTO `login` (`username`, `password`) VALUES
('icywater', 1234);

-- --------------------------------------------------------

--
-- Stand-in structure for view `payment_method_usage`
-- (See below for the actual view)
--
CREATE TABLE `payment_method_usage` (
`payment_id` int(11)
,`payment_title` varchar(50)
,`transaction_count` bigint(21)
);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_customer`
--

CREATE TABLE `tbl_customer` (
  `customer_id` int(11) NOT NULL,
  `customer_name` varchar(50) DEFAULT NULL,
  `customer_phone` int(11) DEFAULT NULL,
  `customer_address` varchar(99) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_customer`
--

INSERT INTO `tbl_customer` (`customer_id`, `customer_name`, `customer_phone`, `customer_address`) VALUES
(1, 'Trinidad', 2147483647, 'Matina Aplaya'),
(2, 'Dodoy Fernandez', 2147483647, 'Matina Crossing'),
(3, 'Jake Flores', 2147483647, 'Alpha Homes'),
(4, 'Mike de Jesus', 2147483647, 'Ma-a'),
(5, 'Meries', 2147483647, 'Central Park');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_delivery`
--

CREATE TABLE `tbl_delivery` (
  `transaction_id` int(11) NOT NULL,
  `delivery_date` date DEFAULT NULL,
  `delivery_status` varchar(50) DEFAULT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `employee_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_delivery`
--

INSERT INTO `tbl_delivery` (`transaction_id`, `delivery_date`, `delivery_status`, `customer_id`, `employee_id`) VALUES
(1, '2024-03-11', 'Pending', 3, 1),
(2, '2024-03-08', 'Pending', 4, 1),
(3, '2024-03-03', 'Pending', 2, 1),
(4, '2024-03-01', 'Completed', 1, 1),
(5, '2024-03-07', 'Completed', 5, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_employee`
--

CREATE TABLE `tbl_employee` (
  `employee_id` int(11) NOT NULL,
  `employee_name` varchar(50) DEFAULT NULL,
  `employee_phone` int(11) DEFAULT NULL,
  `employee_role` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_employee`
--

INSERT INTO `tbl_employee` (`employee_id`, `employee_name`, `employee_phone`, `employee_role`) VALUES
(1, 'Juan', 2147483647, 'Delivery Man'),
(2, 'Inday', 2147483647, 'Front Desk/Refiller'),
(3, 'Mark', 2147483647, 'Part-Timer');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_payment_method`
--

CREATE TABLE `tbl_payment_method` (
  `payment_id` int(11) NOT NULL,
  `payment_title` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_payment_method`
--

INSERT INTO `tbl_payment_method` (`payment_id`, `payment_title`) VALUES
(1, 'CASH'),
(2, 'GCASH');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaction`
--

CREATE TABLE `tbl_transaction` (
  `transaction_id` int(11) NOT NULL,
  `customer_id` int(11) DEFAULT NULL,
  `transaction_date` date DEFAULT NULL,
  `payment_method` int(11) DEFAULT NULL,
  `total_amount` decimal(10,2) DEFAULT NULL,
  `transaction_status` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_transaction`
--

INSERT INTO `tbl_transaction` (`transaction_id`, `customer_id`, `transaction_date`, `payment_method`, `total_amount`, `transaction_status`) VALUES
(1, 3, '2024-11-03', 1, 50.00, 'Completed'),
(2, 4, '2024-08-03', 1, 25.00, 'Completed'),
(3, 5, '2024-01-03', 2, 40.00, 'Completed'),
(4, 5, '2024-01-03', 2, 140.00, 'Completed'),
(5, 1, '2024-05-03', 1, 200.00, 'Completed');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_transaction_details`
--

CREATE TABLE `tbl_transaction_details` (
  `transaction_id` int(11) NOT NULL,
  `water_type` int(11) DEFAULT NULL,
  `sub_total` decimal(10,2) DEFAULT NULL,
  `quantity` int(11) DEFAULT NULL,
  `total_price` decimal(10,2) DEFAULT NULL,
  `date` date DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Table structure for table `tbl_water_type`
--

CREATE TABLE `tbl_water_type` (
  `type_id` int(11) NOT NULL,
  `type_title` varchar(50) DEFAULT NULL,
  `price` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `tbl_water_type`
--

INSERT INTO `tbl_water_type` (`type_id`, `type_title`, `price`) VALUES
(1, 'Mineral Water', 20.00),
(2, 'Purified Water', 25.00),
(3, 'Alkaline Water', 50.00);

-- --------------------------------------------------------

--
-- Structure for view `customer_payment_methods`
--
DROP TABLE IF EXISTS `customer_payment_methods`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `customer_payment_methods`  AS SELECT `c`.`customer_id` AS `customer_id`, `c`.`customer_name` AS `customer_name`, `c`.`customer_phone` AS `customer_phone`, `c`.`customer_address` AS `customer_address`, `pm`.`payment_id` AS `payment_id`, `pm`.`payment_title` AS `payment_title` FROM ((`tbl_customer` `c` left join `tbl_transaction` `t` on(`c`.`customer_id` = `t`.`customer_id`)) left join `tbl_payment_method` `pm` on(`t`.`payment_method` = `pm`.`payment_id`)) ;

-- --------------------------------------------------------

--
-- Structure for view `customer_transaction_delivery_status`
--
DROP TABLE IF EXISTS `customer_transaction_delivery_status`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `customer_transaction_delivery_status`  AS SELECT `c`.`customer_id` AS `customer_id`, `c`.`customer_name` AS `customer_name`, `c`.`customer_address` AS `customer_address`, `t`.`transaction_id` AS `transaction_id`, `t`.`transaction_date` AS `transaction_date`, `d`.`delivery_status` AS `delivery_status` FROM ((`tbl_customer` `c` left join `tbl_transaction` `t` on(`c`.`customer_id` = `t`.`customer_id`)) left join `tbl_delivery` `d` on(`t`.`transaction_id` = `d`.`transaction_id`)) ;

-- --------------------------------------------------------

--
-- Structure for view `customer_transaction_total`
--
DROP TABLE IF EXISTS `customer_transaction_total`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `customer_transaction_total`  AS SELECT `c`.`customer_id` AS `customer_id`, `c`.`customer_name` AS `customer_name`, `c`.`customer_phone` AS `customer_phone`, `c`.`customer_address` AS `customer_address`, sum(`t`.`total_amount`) AS `total_transaction_amount` FROM (`tbl_customer` `c` left join `tbl_transaction` `t` on(`c`.`customer_id` = `t`.`customer_id`)) GROUP BY `c`.`customer_id` ;

-- --------------------------------------------------------

--
-- Structure for view `employee_transaction_details`
--
DROP TABLE IF EXISTS `employee_transaction_details`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `employee_transaction_details`  AS SELECT `e`.`employee_id` AS `employee_id`, `e`.`employee_name` AS `employee_name`, `e`.`employee_phone` AS `employee_phone`, `e`.`employee_role` AS `employee_role`, `t`.`transaction_id` AS `transaction_id`, `t`.`customer_id` AS `customer_id`, `t`.`transaction_date` AS `transaction_date`, `t`.`payment_method` AS `payment_method`, `t`.`total_amount` AS `total_amount`, `t`.`transaction_status` AS `transaction_status` FROM ((`tbl_employee` `e` left join `tbl_delivery` `d` on(`e`.`employee_id` = `d`.`employee_id`)) left join `tbl_transaction` `t` on(`d`.`transaction_id` = `t`.`transaction_id`)) ;

-- --------------------------------------------------------

--
-- Structure for view `payment_method_usage`
--
DROP TABLE IF EXISTS `payment_method_usage`;

CREATE ALGORITHM=UNDEFINED DEFINER=`root`@`localhost` SQL SECURITY DEFINER VIEW `payment_method_usage`  AS SELECT `pm`.`payment_id` AS `payment_id`, `pm`.`payment_title` AS `payment_title`, count(`t`.`transaction_id`) AS `transaction_count` FROM (`tbl_payment_method` `pm` left join `tbl_transaction` `t` on(`pm`.`payment_id` = `t`.`payment_method`)) GROUP BY `pm`.`payment_id` ;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  ADD PRIMARY KEY (`customer_id`);

--
-- Indexes for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `customer_id` (`customer_id`),
  ADD KEY `employee_id` (`employee_id`);

--
-- Indexes for table `tbl_employee`
--
ALTER TABLE `tbl_employee`
  ADD PRIMARY KEY (`employee_id`);

--
-- Indexes for table `tbl_payment_method`
--
ALTER TABLE `tbl_payment_method`
  ADD PRIMARY KEY (`payment_id`);

--
-- Indexes for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `customer_id` (`customer_id`),
  ADD KEY `payment_method` (`payment_method`);

--
-- Indexes for table `tbl_transaction_details`
--
ALTER TABLE `tbl_transaction_details`
  ADD PRIMARY KEY (`transaction_id`),
  ADD KEY `water_type` (`water_type`);

--
-- Indexes for table `tbl_water_type`
--
ALTER TABLE `tbl_water_type`
  ADD PRIMARY KEY (`type_id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_customer`
--
ALTER TABLE `tbl_customer`
  MODIFY `customer_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_employee`
--
ALTER TABLE `tbl_employee`
  MODIFY `employee_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbl_payment_method`
--
ALTER TABLE `tbl_payment_method`
  MODIFY `payment_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbl_transaction_details`
--
ALTER TABLE `tbl_transaction_details`
  MODIFY `transaction_id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `tbl_water_type`
--
ALTER TABLE `tbl_water_type`
  MODIFY `type_id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=9;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_delivery`
--
ALTER TABLE `tbl_delivery`
  ADD CONSTRAINT `tbl_delivery_ibfk_1` FOREIGN KEY (`transaction_id`) REFERENCES `tbl_transaction` (`transaction_id`),
  ADD CONSTRAINT `tbl_delivery_ibfk_2` FOREIGN KEY (`customer_id`) REFERENCES `tbl_customer` (`customer_id`),
  ADD CONSTRAINT `tbl_delivery_ibfk_3` FOREIGN KEY (`employee_id`) REFERENCES `tbl_employee` (`employee_id`);

--
-- Constraints for table `tbl_transaction`
--
ALTER TABLE `tbl_transaction`
  ADD CONSTRAINT `tbl_transaction_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `tbl_customer` (`customer_id`),
  ADD CONSTRAINT `tbl_transaction_ibfk_2` FOREIGN KEY (`payment_method`) REFERENCES `tbl_payment_method` (`payment_id`);

--
-- Constraints for table `tbl_transaction_details`
--
ALTER TABLE `tbl_transaction_details`
  ADD CONSTRAINT `tbl_transaction_details_ibfk_1` FOREIGN KEY (`transaction_id`) REFERENCES `tbl_transaction` (`transaction_id`),
  ADD CONSTRAINT `tbl_transaction_details_ibfk_2` FOREIGN KEY (`water_type`) REFERENCES `tbl_water_type` (`type_id`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
