-- phpMyAdmin SQL Dump
-- version 3.2.4
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Oct 12, 2017 at 10:21 PM
-- Server version: 5.1.41
-- PHP Version: 5.3.1

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `lbsis_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_citizenship`
--

CREATE TABLE IF NOT EXISTS `tbl_citizenship` (
  `citizenship_id` int(11) NOT NULL AUTO_INCREMENT,
  `citizenship` varchar(30) NOT NULL,
  PRIMARY KEY (`citizenship_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `tbl_citizenship`
--

INSERT INTO `tbl_citizenship` (`citizenship_id`, `citizenship`) VALUES
(1, 'Filipino'),
(2, 'Chinese'),
(3, 'American'),
(4, 'Indonesian'),
(5, 'Malaysian'),
(6, 'Korean'),
(7, 'Japanese'),
(8, 'Russian'),
(9, 'Taiwanese');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_login`
--

CREATE TABLE IF NOT EXISTS `tbl_login` (
  `name` varchar(100) NOT NULL,
  `position` varchar(9) NOT NULL,
  `address` varchar(100) NOT NULL,
  `username` varchar(20) NOT NULL,
  `password` varchar(16) NOT NULL,
  PRIMARY KEY (`username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_login`
--

INSERT INTO `tbl_login` (`name`, `position`, `address`, `username`, `password`) VALUES
('nazerdan', 'Admin', 'CAGAYAN DE ORO', 'admin', 'admin'),
('Mr. Pacs', 'Registrar', 'bz', 'registrar', '123'),
('Mr. Baluran', 'Teacher', 'Kauswagan, CDOasdasd', 'teacher', 'teacher');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_religion`
--

CREATE TABLE IF NOT EXISTS `tbl_religion` (
  `religion_id` int(11) NOT NULL AUTO_INCREMENT,
  `religion` varchar(63) NOT NULL,
  PRIMARY KEY (`religion_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=25 ;

--
-- Dumping data for table `tbl_religion`
--

INSERT INTO `tbl_religion` (`religion_id`, `religion`) VALUES
(1, 'Roman Catholic'),
(2, 'Islam'),
(3, 'Evangelicals (PCEC)'),
(4, 'Iglesia ni Cristo'),
(5, 'Aglipayan'),
(6, 'Seventh-day Adventist'),
(7, 'Bible Baptist Church'),
(8, 'United Church of Christ in the Philippines'),
(9, 'Jehova''s Witness'),
(10, 'Church of Christ'),
(11, 'Jesus is Lord Church'),
(12, 'United Pentecostal Church (Phil) Inc.'),
(13, 'Philippine Independent Catholic Church'),
(14, 'Union Epiritista Cristiana de Filipinas, Inc.'),
(15, 'Church of Jesus Christ of the Latter Day Saints'),
(16, 'Association of Fundamental Baptist Churches in the Philippines'),
(17, 'Evangelical Christian Outreach Foundation'),
(18, 'Convention of the Philippine Baptis Church'),
(19, 'Crusaders of the Divine Church of Christ Inc.'),
(20, 'Buddhist'),
(21, 'Lutheran Church of the Philippines'),
(22, 'Iglesia sa Dios Espiritu Santo Inc.'),
(23, 'Philippine Benevolent Missionaries Association'),
(24, 'Faith Tabernacle Church (Living Rock Ministries)');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_schedule`
--

CREATE TABLE IF NOT EXISTS `tbl_schedule` (
  `sched_id` int(11) NOT NULL AUTO_INCREMENT,
  `section_id` int(11) NOT NULL,
  `subject_id` int(11) NOT NULL,
  `teacher` varchar(20) NOT NULL,
  `time` text NOT NULL,
  `day` text NOT NULL,
  PRIMARY KEY (`sched_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=20 ;

--
-- Dumping data for table `tbl_schedule`
--

INSERT INTO `tbl_schedule` (`sched_id`, `section_id`, `subject_id`, `teacher`, `time`, `day`) VALUES
(15, 17, 64, 'Ms. Jalou Apos', '    7:30AM - 8:30AM', 'Wednesday'),
(16, 17, 64, 'Ms. Kristine Gabica', '    7:30AM - 8:30AM', 'Tuesday'),
(12, 16, 61, 'Ms. Jalou Apos', '    8:30AM - 9:30AM', 'Monday'),
(11, 15, 62, 'Ms. Kristine Gabica', '    7:30AM - 8:30AM', 'Monday'),
(17, 9, 63, 'Ms. Kristine Gabica', '    8:30AM - 9:30AM', 'Wednesday'),
(18, 17, 63, 'Ms. Kristine Gabica', '    8:30AM - 9:30AM', 'Tuesday'),
(19, 15, 61, 'Ms. Kristine Gabica', '    3:00PM - 4:00PM', 'Tuesday');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_section`
--

CREATE TABLE IF NOT EXISTS `tbl_section` (
  `section_id` int(11) NOT NULL AUTO_INCREMENT,
  `section` varchar(20) NOT NULL,
  `adviser` varchar(20) NOT NULL,
  `grade_level` varchar(3) NOT NULL,
  `schedule` varchar(9) NOT NULL,
  PRIMARY KEY (`section_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=25 ;

--
-- Dumping data for table `tbl_section`
--

INSERT INTO `tbl_section` (`section_id`, `section`, `adviser`, `grade_level`, `schedule`) VALUES
(17, 'K2 - Good Boy', 'Ms. Jalou Apos', 'K2', 'Morning'),
(4, 'K2 - Lazy', 'Ms. Jalou Apos', 'K2', 'Afternoon'),
(7, '1 - Gold', 'Ms. Kristine Gabica', '1', 'Morning'),
(9, '2 - Millio', 'Ms. Jalou Apos', '2', 'Afternoon'),
(10, '3 - millio', 'Ms. Jemimah Pacana', '3', 'Afternoon'),
(11, '4 - Billio', 'Ms. Kristine Gabica', '4', 'Morning'),
(12, '5 - Silver', 'Ms. Jalou Apos', '5', 'Afternoon'),
(13, '6 - Bronze', 'Ms. Jemimah Pacana', '6', 'Afternoon'),
(14, '1 - Thousa', 'Ms. Jemimah Pacana', '1', 'Afternoon'),
(15, 'K1 - KPOP', 'Ms. Jalou Apos', 'K1', 'Afternoon'),
(16, 'K1 - KPOPses', 'Ms. Jemimah Pacana', 'K1', 'Morning'),
(18, '2 - Lipstick', 'Ms. Jemimah Pacana', '2', 'Morning'),
(19, '3 - Glasses', 'Ms. Jemimah Pacana', '3', 'Morning'),
(20, '4 - Handsome', 'Ms. Jalou Apos', '4', 'Afternoon'),
(21, '5 - yellow', 'Ms. Jalou Apos', '5', 'Morning'),
(22, '6 - Never Give Up', 'Ms. Jemimah Pacana', '6', 'Morning');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_studlist`
--

CREATE TABLE IF NOT EXISTS `tbl_studlist` (
  `studlist_id` int(4) NOT NULL AUTO_INCREMENT,
  `stud_id` int(4) NOT NULL,
  PRIMARY KEY (`studlist_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=41 ;

--
-- Dumping data for table `tbl_studlist`
--

INSERT INTO `tbl_studlist` (`studlist_id`, `stud_id`) VALUES
(37, 2),
(40, 1);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_studprof`
--

CREATE TABLE IF NOT EXISTS `tbl_studprof` (
  `stud_id` int(11) NOT NULL,
  `section_id` int(11) NOT NULL,
  `schedule` varchar(9) NOT NULL,
  `status` varchar(12) NOT NULL,
  `stud_gradelevel` varchar(2) NOT NULL,
  `stud_lastname` varchar(30) NOT NULL,
  `stud_firstname` varchar(30) NOT NULL,
  `stud_middlename` varchar(30) NOT NULL,
  `stud_birthdate` varchar(18) NOT NULL,
  `stud_age` int(2) NOT NULL,
  `stud_gender` varchar(6) NOT NULL,
  `citizenship_id` int(11) NOT NULL,
  `religion_id` int(11) NOT NULL,
  `stud_address` varchar(100) NOT NULL,
  `stud_contactnum` varchar(15) NOT NULL,
  `stud_mothername` varchar(60) NOT NULL,
  `stud_motherocc` varchar(30) NOT NULL,
  `stud_fathername` varchar(60) NOT NULL,
  `stud_fatherocc` varchar(30) NOT NULL,
  `stud_health` varchar(30) NOT NULL,
  `stud_allergy` varchar(30) NOT NULL,
  PRIMARY KEY (`stud_id`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_studprof`
--

INSERT INTO `tbl_studprof` (`stud_id`, `section_id`, `schedule`, `status`, `stud_gradelevel`, `stud_lastname`, `stud_firstname`, `stud_middlename`, `stud_birthdate`, `stud_age`, `stud_gender`, `citizenship_id`, `religion_id`, `stud_address`, `stud_contactnum`, `stud_mothername`, `stud_motherocc`, `stud_fathername`, `stud_fatherocc`, `stud_health`, `stud_allergy`) VALUES
(1, 16, 'N/A', 'Enrolled', 'K1', 'Pablico', 'Angel', 'Mae', '05/6/2011', 6, 'Female', 1, 1, 'balulang', '09354444112', 'Christy', 'House wife', 'James', 'Programmer', 'None', 'None'),
(2, 15, 'N/A', 'Enrolled', 'K1', 'Villagracia', 'Dodong', 'Querol', '05/26/2011', 6, 'Male', 1, 1, 'gusa', '09055454123', 'Hana', 'teacher', 'Vincent', 'Hitman', 'None', 'None'),
(4, 16, 'N/A', 'Not Enrolled', 'K2', 'Tion', 'Angel', 'Buslon', '04/19/2012', 6, 'Female', 1, 1, 'Gusa', '09285555142', 'Ketty', 'Singer', 'Neyo', 'Computer Eng.', 'None', 'None'),
(5, 0, 'N/A', 'Not Enrolled', '1', 'Ablin', 'Bridon', 'Doming', '05/31/2010', 8, 'Male', 1, 1, 'lumbia', '09354834221', 'Korason', 'House wife', 'Bobby', 'Boxer', 'None', 'None'),
(7, 24, 'N/A', 'Not Enrolled', '2', 'Obanon', 'Lyn', 'Lee', '05/22/2010', 8, 'Female', 1, 1, 'gusa', '09354856124', 'Martha', 'Singer', 'Dale Dexter', 'Computer Sci', 'None', 'None'),
(8, 24, 'N/A', 'Not Enrolled', '2', 'Delos Santos', 'Iya', 'Go', '07/22/2010', 8, 'Female', 1, 1, 'gusa', '09358845652', 'Jovena', 'Housewife', 'Jove', 'Soldier', 'None', 'None'),
(9, 24, 'N/A', 'Not Enrolled', '3', 'Dakoko', 'James', 'Bilda', '08/15/2009', 9, 'Male', 1, 1, 'gusa', '09355965142', 'April', 'Chef', 'Vincent', 'Chef', 'None', 'None'),
(10, 24, 'N/A', 'Not Enrolled', '3', 'Simene', 'Guilbert', 'Daspan', '05/16/2009', 9, 'Male', 1, 1, 'gusa', '09356451154', 'Ruth', 'teacher', 'Guilbert', 'teacher', 'None', 'None'),
(11, 24, 'N/A', 'Not Enrolled', '4', 'Han', 'James', 'Nobita', '05/21/2008', 10, 'Male', 2, 1, 'gusa', '09354884215', 'Norilita', 'Nurse', 'Normilindo', 'Doctor', 'None', 'None'),
(12, 24, 'N/A', 'Not Enrolled', '4', 'Bitoy', 'Shandon', 'Herrera', '01/15/2006', 11, 'Male', 1, 1, 'gusa', '09065157122', 'Dara', 'Teacher', 'James', 'Teacher', 'None', 'None'),
(13, 24, 'N/A', 'Not Enrolled', '5', 'Macababayao', 'Giancarlo', 'Talipan', '05/21/2006', 11, 'Male', 1, 1, 'Lumbia', '09069007831', 'Teresita', 'Housewife', 'Noel', 'Soldier', 'None', 'None'),
(14, 24, 'N/A', 'Not Enrolled', '5', 'Mofar', 'Jolina', 'Tacandong', '02/16/2006', 11, 'Female', 1, 1, 'cogon', '09351684135', 'Jona', 'Kagawad', 'Carlito', 'Gym Intructor', 'None', 'None'),
(15, 24, 'N/A', 'Not Enrolled', '6', 'Abacahin', 'Keene Jasper', 'Dahinog', '02/15/2005', 12, 'Male', 1, 1, 'Lumbia', '09361654125', 'Jedi', 'Driver', 'Linet', 'BJMP', 'None', 'None'),
(16, 24, 'N/A', 'Not Enrolled', '6', 'Baluran', 'Nazerdan', 'Gwapo', '01/09/2005', 12, 'Male', 1, 1, 'NHA', '09053216152', 'Christy', 'Housewife', 'James', 'Doctor', 'None', 'None'),
(17, 24, 'N/A', 'Not Enrolled', '1', 'Villagracia', 'Regie', 'Lumagbas', '05/15/2010', 7, 'Male', 1, 1, 'NHA', '09351654125', 'Lyn Lee', 'Housewife', 'Jaybugs', 'Doctor', 'None', 'None'),
(20, 0, 'N/A', 'Not Enrolled', 'K2', 'asdasd', 'asdasd', 'asdasd', 'asdasd', 12, 'Male', 1, 2, 'asd', '12', 'asdasd', 'asdasd', 'asdasd', 'asdasd', 'None', 'None'),
(21, 11, 'N/A', 'Not Enrolled', '4', 'asdas', 'asdasd', 'aasd', 'asdasdasd', 1, 'Male', 1, 6, 'asdasdas', '123', 'asdasdasda', 'asdasd', 'asdasd', 'asdasd', 'None', 'None'),
(22, 4, 'N/A', 'Not Enrolled', 'K2', 'asd', 'asd', 'asd', 'asdasd', 1, 'Male', 2, 2, 'asdasd', '123', 'asdasd', 'asdasd', 'asdasd', 'asdasd', 'None', 'None');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_subject`
--

CREATE TABLE IF NOT EXISTS `tbl_subject` (
  `subject_id` int(6) NOT NULL AUTO_INCREMENT,
  `teacher_id` int(11) NOT NULL,
  `subject` varchar(30) NOT NULL,
  `grade_level` varchar(2) NOT NULL,
  PRIMARY KEY (`subject_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=77 ;

--
-- Dumping data for table `tbl_subject`
--

INSERT INTO `tbl_subject` (`subject_id`, `teacher_id`, `subject`, `grade_level`) VALUES
(64, 2, 'Aralin Panlipunan', 'K2'),
(62, 1, 'English', 'K1'),
(63, 2, 'Filipino', 'K2'),
(61, 1, 'Math', 'K1'),
(65, 3, 'Science', '1'),
(66, 3, 'Math', '1'),
(67, 1, 'English', '2'),
(68, 1, 'Filipino', '2'),
(69, 3, 'Science', '3'),
(70, 3, 'Aralin Panlipunan', '3'),
(71, 2, 'Mapeh', '4'),
(72, 3, 'English', '4'),
(73, 2, 'Math', '5'),
(74, 2, 'Science', '5'),
(75, 1, 'Filipino', '6'),
(76, 1, 'Mapeh', '6');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_teacher`
--

CREATE TABLE IF NOT EXISTS `tbl_teacher` (
  `teacher_id` int(6) NOT NULL AUTO_INCREMENT,
  `name` varchar(20) NOT NULL,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP ON UPDATE CURRENT_TIMESTAMP,
  PRIMARY KEY (`teacher_id`)
) ENGINE=MyISAM  DEFAULT CHARSET=latin1 AUTO_INCREMENT=13 ;

--
-- Dumping data for table `tbl_teacher`
--

INSERT INTO `tbl_teacher` (`teacher_id`, `name`, `date`) VALUES
(1, 'Ms. Kristine Gabica', '2017-07-22 17:28:00'),
(2, 'Ms. Jalou Apos', '2017-07-22 17:28:49'),
(3, 'Ms. Jemimah Pacana', '2017-07-22 17:29:09');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tempsec`
--

CREATE TABLE IF NOT EXISTS `tbl_tempsec` (
  `section_id` int(2) NOT NULL,
  `section` varchar(3) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tbl_tempsec`
--

INSERT INTO `tbl_tempsec` (`section_id`, `section`) VALUES
(1, 'N/A');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_violation`
--

CREATE TABLE IF NOT EXISTS `tbl_violation` (
  `violation_id` int(11) NOT NULL AUTO_INCREMENT,
  `date_violation` varchar(50) NOT NULL,
  `violation` varchar(200) NOT NULL,
  `student_id` varchar(11) NOT NULL,
  `teacher_id` int(11) NOT NULL,
  PRIMARY KEY (`violation_id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `tbl_violation`
--

INSERT INTO `tbl_violation` (`violation_id`, `date_violation`, `violation`, `student_id`, `teacher_id`) VALUES
(5, 'Sunday, August 27, 2017', 'Shouting at Teachers', '10', 1),
(6, 'Sunday, August 27, 2017', 'Speaking bad words', '10', 2),
(7, 'Friday, September 29, 2017', 'NOT MAKING ASSIGNMENTS', '1', 3),
(8, 'Sunday, September 17, 2017', 'Shouting', '1', 3),
(9, 'Tuesday, September 12, 2017', 'Gamay ug lubot na studyante', '2', 1),
(10, 'Thursday, September 21, 2017', 'going out', '1', 1);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
