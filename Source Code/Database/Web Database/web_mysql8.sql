CREATE TABLE `question_data` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `Code` int(11) NOT NULL,
  `Question` varchar(300) DEFAULT NULL,
  `Option1` varchar(300) DEFAULT NULL,
  `Option2` varchar(300) DEFAULT NULL,
  `Option3` varchar(300) DEFAULT NULL,
  `Option4` varchar(300) DEFAULT NULL,
  `Answer` int(11) DEFAULT NULL,
  `ImageID` varchar(45) NOT NULL DEFAULT '0',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `ID_UNIQUE` (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=1017 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `quiz_record` (
  `Code` int(11) NOT NULL AUTO_INCREMENT,
  `User` int(11) DEFAULT NULL,
  `Title` varchar(100) DEFAULT NULL,
  `Subject` varchar(45) DEFAULT NULL,
  `Sem` int(11) DEFAULT NULL,
  `Branc` varchar(2) DEFAULT NULL,
  `Time` int(11) DEFAULT NULL,
  `Slot` int(11) DEFAULT NULL,
  `Status` int(11) DEFAULT NULL,
  `Password` varchar(10) DEFAULT NULL,
  `Elective` int(11) DEFAULT NULL,
  PRIMARY KEY (`Code`),
  UNIQUE KEY `Code_UNIQUE` (`Code`)
) ENGINE=InnoDB AUTO_INCREMENT=123457 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `user_profile` (
  `user_id` int(11) NOT NULL,
  `vote` int(11) DEFAULT '0',
  PRIMARY KEY (`user_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
CREATE TABLE `user_record` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `USN` varchar(10) NOT NULL,
  `Name` varchar(45) NOT NULL,
  `Email` varchar(45) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `Semester` int(11) NOT NULL,
  `Branch` varchar(2) NOT NULL,
  `Section` varchar(1) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `PasswordHash` varchar(64) NOT NULL,
  `Status` int(11) DEFAULT '1',
  PRIMARY KEY (`ID`),
  UNIQUE KEY `USN_UNIQUE` (`USN`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*
SQL Statement to create USER Response Table
*/
CREATE TABLE `user_response` (
  `ID` int(11) NOT NULL AUTO_INCREMENT,
  `USN` varchar(10) DEFAULT NULL,
  `Code` int(11) DEFAULT NULL,
  `Time` varchar(22) DEFAULT NULL,
  `Marks` varchar(3) DEFAULT NULL,
  PRIMARY KEY (`ID`)
) ENGINE=InnoDB AUTO_INCREMENT=119 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
