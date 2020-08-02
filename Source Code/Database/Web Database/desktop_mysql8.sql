CREATE TABLE `data_misc` (
  `Passcode` int(11) NOT NULL DEFAULT '0',
  `Subject` varchar(45) DEFAULT NULL,
  `Duration` int(11) DEFAULT NULL,
  `Access` int(11) DEFAULT NULL,
  `Code` int(11) DEFAULT NULL,
  `DurationLimit` int(11) DEFAULT NULL,
  PRIMARY KEY (`Passcode`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `question_data` (
  `ID` int(11) NOT NULL,
  `Code` int(11) DEFAULT NULL,
  `Question` varchar(300) DEFAULT NULL,
  `Option1` varchar(200) DEFAULT NULL,
  `Option2` varchar(200) DEFAULT NULL,
  `Option3` varchar(200) DEFAULT NULL,
  `Option4` varchar(200) DEFAULT NULL,
  `Answer` int(11) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `response_data` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `USN` varchar(45) DEFAULT NULL,
  `Marks` int(11) DEFAULT NULL,
  `Hash` varchar(65) DEFAULT NULL,
  `Email` int(11) DEFAULT NULL,
  `Time` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=77 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `user_misc` (
  `USN` varchar(10) NOT NULL,
  `Quiz` int(11) DEFAULT NULL,
  PRIMARY KEY (`USN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `user_profile` (
  `USN` varchar(11) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Phone` varchar(10) DEFAULT NULL,
  `DateofBirth` datetime DEFAULT NULL,
  `Email` varchar(45) DEFAULT NULL,
  `Password` varchar(65) DEFAULT NULL,
  `code` varchar(65) DEFAULT NULL,
  PRIMARY KEY (`USN`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
