-- phpMyAdmin SQL Dump
-- version 4.1.14
-- http://www.phpmyadmin.net
--
-- Servidor: 127.0.0.1
-- Tiempo de generación: 07-06-2015 a las 08:28:47
-- Versión del servidor: 5.6.17
-- Versión de PHP: 5.5.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de datos: `sia`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `alumnos`
--

CREATE TABLE IF NOT EXISTS `alumnos` (
  `Num_Boleta` int(10) NOT NULL,
  `Nombre_Alumno` varchar(50) NOT NULL,
  `id_Grupo` varchar(5) NOT NULL,
  PRIMARY KEY (`Num_Boleta`),
  KEY `id_Grupo` (`id_Grupo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `alumnos`
--

INSERT INTO `alumnos` (`Num_Boleta`, `Nombre_Alumno`, `id_Grupo`) VALUES
(2010080852, 'Nuevo Integrante', '5IV1'),
(2012080433, 'Garcia Robles Danica Alejandra ', '6IM12'),
(2012080548, 'Gutierrez Montenegro Fanny Aylin', '6IM12'),
(2012081088, 'Pichardo Reyes Aldo Omar ', '6IM12'),
(2012081321, 'Sandoval Velasco Juan Alberto ', '6IM12'),
(2012081485, 'Vidrio Rodriguez Jose Alberto', '6IM12'),
(2013080017, 'Torres Ramirez Elionai', '6IM12'),
(2013080038, 'Matus Lopez Carlos Eduardo', '6IM12'),
(2013080133, 'Martinez Martinez Mauricio Saul', '6IM12'),
(2013080201, 'Zamora Padilla Monica Giselle ', '6IM12'),
(2013080215, 'Orozco Santiago Narayan Mahavir', '6IM12'),
(2013080218, 'De la O Hernandez Jared', '6IM12'),
(2013080262, 'Hernandez Pineda Miguel Angel', '6IM12'),
(2013080379, 'Garcia Ramirez Soemmy Guadalupe', '6IM12'),
(2013080479, 'Ponce Garcia Marco Francisco', '6IM12'),
(2013080511, 'Arizmendi Manriquez Erick', '6IM12'),
(2013080519, 'Hernandez Aguliar Damian Isaias ', '6IM12'),
(2013080545, 'Navarro Gutierrez Miguel Angel ', '6IM12'),
(2013080557, 'Trejo Grande Jorge Daniel', '6IM12'),
(2013080580, 'Saavedra Monroy Laura Rebeca', '6IM12'),
(2013080600, 'Villaseñor Jaimes Maria Alejandra', '6IM12'),
(2013080700, 'Diaz Spirito Edgar', '6IM12'),
(2013080704, 'Toxqui Navarrete Ulises ', '6IM12'),
(2013080719, 'Gomez Garcia Maria Jimena', '6IM12'),
(2013080745, 'Barrera Bravo Marco Antonio', '6IM12'),
(2013080747, 'Gomez Garcia Jose Gustavo ', '6IM12'),
(2013080762, 'Lopez Romero Cesar Alfonso', '6IM12'),
(2013080805, 'Sierra Yescas Eduardo', '6IM12'),
(2013080817, 'Ruiz Escareño Jorge Alejandro ', '6IM12'),
(2013080835, 'Rivera Vergara Susana', '6IM12'),
(2013080852, 'Estrada Granados Diego', '6IM12'),
(2013080871, 'Castillo Jimenez Jorge', '6IM12'),
(2013080919, 'Oropeza Zagala Dennise Michelle ', '6IM12'),
(2013080966, 'Monroy Romero Paulina Quetzalli', '6IM12'),
(2013080969, 'Garcia Serrano Luis Rogelio', '6IM12'),
(2013080988, 'Mata Meireles Berenice ', '6IM12'),
(2013081006, 'Reyes Medrano Alexis Daniel', '6IM12'),
(2013081103, 'Contreras Limon Alejandro', '6IM12'),
(2013081184, 'Casas Castillo David ', '6IM12'),
(2013081483, 'Sanchez Fuentes Alan Giovanni ', '6IM12');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `grupo`
--

CREATE TABLE IF NOT EXISTS `grupo` (
  `id_Grupo` varchar(5) NOT NULL,
  `Carrera` varchar(12) NOT NULL,
  `Semestre` varchar(7) NOT NULL,
  PRIMARY KEY (`id_Grupo`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `grupo`
--

INSERT INTO `grupo` (`id_Grupo`, `Carrera`, `Semestre`) VALUES
('2IM1', 'Tronco Comun', 'Segundo'),
('2IM16', 'Tronco Comun', 'Segundo'),
('2IM5', 'Tronco Comun', 'Segundo'),
('4IM13', 'Computacion', 'Cuarto'),
('4IM14', 'Computacion', 'Cuarto'),
('4IM16', 'Computacion', 'Cuarto '),
('4IM17', 'Computacion', 'Cuarto'),
('4IM18', 'Computacion', 'Cuarto'),
('6IM10', 'Computacion', 'Sexto'),
('6IM11', 'Computacion', 'Sexto'),
('6IM12', 'Computacion', 'Sexto'),
('6IM13', 'Computacion', 'Sexto');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `profesor`
--

CREATE TABLE IF NOT EXISTS `profesor` (
  `Clave_Profesor` varchar(15) NOT NULL,
  `Nombre_Profesor` varchar(50) NOT NULL,
  `Materia` varchar(40) NOT NULL,
  PRIMARY KEY (`Clave_Profesor`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `profesor`
--

INSERT INTO `profesor` (`Clave_Profesor`, `Nombre_Profesor`, `Materia`) VALUES
('JCR-AM-6IM10', 'Javier Carrillo Rodriguez', 'Aplicaciones Multimedia '),
('JCR-AM-6IM11', 'Javier Carrillo Rodriguez', 'Aplicaciones Multimedia '),
('JCR-PI-6IM12', 'Javier Carrillo Rodriguez', 'Proyecto Informatico '),
('JCR-PS-6IM10', 'Javier Carrillo Rodriguez', 'Programacion de Sistemas'),
('JCR-RC-4IM13', 'Javier Carrillo Rodriguez', 'Redes de Computadoras'),
('JCR-RC-4IM14', 'Javier Carrillo Rodriguez', 'Redes de Computadoras'),
('JCR-RC-4IM16', 'Javier Carrillo Rodriguez', 'Redes de Computadoras'),
('MCR-AB-4IM13', 'Miroslava Cardenas Rivera', 'Animacion Bidimencional '),
('MCR-CBII-2IM16', 'Miroslava Cardenas Rivera', 'Computacion Basica II'),
('MCR-CBII-2IM5', 'Miroslava Cardenas Rivera', 'Computacion Basica II'),
('MCR-PM-4IM17', 'Miroslava Cardenas Rivera', 'Programacion Modular'),
('MCR-PS-6IM10', 'Miroslava Cardenas Rivera', 'Programacion de Sistemas '),
('MCR-PS-6IM12', 'Miroslava Cardenas Rivera', 'Programacion de Sistemas '),
('MGNI-AB-4IM14', 'Maria Guadalupe Nava Ibarra', 'Animacion Bidimencional'),
('MGNI-AB-4IM18', 'Maria Guadalupe Nava Ibarra', 'Animacion Bidimencional'),
('MGNI-PM-4IM13', 'Maria Guadalupe Nava Ibarra', 'Programacion Modular'),
('MGNI-PM-4IM14', 'Maria Guadalupe Nava Ibarra', 'Programacion Modular'),
('MGNI-PS-6IM12', 'Maria Guadalupe Nava Ibarra', 'Programacion de Sistemas '),
('MGNI-RC-4IM13', 'Maria Guadalupe Nava Ibarra', 'Redes de Computadoras'),
('MGNI-RC-4IM14', 'Maria Guadalupe Nava Ibarra', 'Redes de Computadoras'),
('MGNI-SI-6IM12', 'Maria Guadalupe Nava Ibarra', 'Seguridad Informatica'),
('RMPA-AB-4IM13', 'Rosa Maria Perez Angeles', 'Animacion Bidimencional'),
('RMPA-AB-4IM16', 'Rosa Maria Perez Angeles', 'Animacion Bidimencional'),
('RMPA-AM-6IM12', 'Rosa Maria Perez Angeles', 'Apicaciones Multimedia '),
('RMPA-AM-6IM13', 'Rosa Maria Perez Angeles', 'Apicaciones Multimedia '),
('RMPA-CBII-2IM1', 'Rosa Maria Perez Angeles', 'Computacion Basica II'),
('RMPA-SI-6IM10', 'Rosa Maria Perez Angeles', 'Seguridad Informatica');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `relacion`
--

CREATE TABLE IF NOT EXISTS `relacion` (
  `Clave_Profesor` varchar(15) NOT NULL,
  `id_Grupo` varchar(5) NOT NULL,
  `id_Salon` varchar(35) NOT NULL,
  `Dia` varchar(9) NOT NULL,
  `Hora` varchar(11) NOT NULL,
  PRIMARY KEY (`Clave_Profesor`,`id_Grupo`,`id_Salon`,`Dia`,`Hora`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `relacion`
--

INSERT INTO `relacion` (`Clave_Profesor`, `id_Grupo`, `id_Salon`, `Dia`, `Hora`) VALUES
('JCR-AM-6IM10', '6IM10', 'Laboratorio F', 'Viernes', '13:00-14:00'),
('JCR-AM-6IM10', '6IM10', 'Laboratorio G', 'Miercoles', '11:00-13:00'),
('JCR-AM-6IM10', '6IM10', 'Laboratorio H', 'Miercoles', '11:00-13:00'),
('JCR-AM-6IM11', '6IM11', 'Laboratorio G', 'Lunes', '07:00-09:00'),
('JCR-AM-6IM11', '6IM11', 'Laboratorio G', 'Miercoles', '07:00-08:00'),
('JCR-PI-6IM12', '6IM12', 'A-15', 'Viernes', '07:00-08:00'),
('JCR-PI-6IM12', '6IM12', 'Laboratorio G', 'Martes', '13:00-15:00'),
('JCR-PI-6IM12', '6IM12', 'Laboratorio H', 'Lunes', '13:00-15:00'),
('JCR-PI-6IM12', '6IM12', 'Laboratorio H', 'Martes', '13:00-15:00'),
('JCR-PS-6IM10', '6IM10', 'Laboratorio G', 'Miercoles', '09:00-11:00'),
('JCR-PS-6IM10', '6IM10', 'Laboratorio G', 'Viernes', '09:00-11:00'),
('JCR-PS-6IM10', '6IM10', 'Laboratorio H', 'Miercoles', '09:00-11:00'),
('JCR-PS-6IM10', '6IM10', 'Laboratorio H', 'Viernes', '09:00-11:00'),
('JCR-RC-4IM13', '4IM13', 'Laboratorio E', 'Jueves', '12:00-13:00'),
('JCR-RC-4IM13', '4IM13', 'Laboratorio E', 'Martes', '10:00-11:00'),
('JCR-RC-4IM13', '4IM13', 'Laboratorio E', 'Martes', '10:00-12:00'),
('JCR-RC-4IM14', '4IM14', 'Laboratorio E', 'Martes', '07:00-09:00'),
('JCR-RC-4IM16', '4IM16', 'Laboratorio E', 'Jueves', '10:00-12:00'),
('JCR-RC-4IM16', '4IM16', 'Laboratorio E', 'Martes', '12:00-13:00'),
('MCR-CBII-2IM16', '2IM16', 'C-16', 'Jueves', '08:00-09:00'),
('MCR-CBII-2IM16', '2IM16', 'Laboratorio A', 'Jueves', '07:00-08:00'),
('MCR-CBII-2IM16', '2IM16', 'Laboratorio A', 'Martes', '07:00-09:00'),
('MCR-CBII-2IM16', '2IM16', 'Laboratorio B', 'Jueves', '07:00-08:00'),
('MCR-CBII-2IM16', '2IM16', 'Laboratorio B', 'Martes', '07:00-09:00'),
('MCR-CBII-2IM5', '2IM5', 'C-5', 'Jueves', '10:00-11:00'),
('MCR-CBII-2IM5', '2IM5', 'Laboratorio A', 'Jueves', '09:00-10:00'),
('MCR-CBII-2IM5', '2IM5', 'Laboratorio A', 'Martes', '09:00-11:00'),
('MCR-CBII-2IM5', '2IM5', 'Laboratorio B', 'Jueves', '09:00-10:00'),
('MCR-CBII-2IM5', '2IM5', 'Laboratorio B', 'Martes', '09:00-11:00'),
('MCR-PM-4IM17', '4IM17', 'Laboratorio C', 'Miercoles', '07:00-09:00'),
('MCR-PM-4IM17', '4IM17', 'Laboratorio de Dibujo', 'Miercoles', '07:00-09:00'),
('MCR-PS-6IM10', '6IM10', 'A-13', 'Lunes', '12:00-13:00'),
('MCR-PS-6IM10', '6IM10', 'Laboratorio F', 'Miercoles', '09:00-11:00'),
('MCR-PS-6IM10', '6IM10', 'Laboratorio G', 'Viernes', '09:00-11:00'),
('MCR-PS-6IM10', '6IM10', 'Laboratorio H', 'Viernes', '09:00-11:00'),
('MCR-PS-6IM12', '6IM12', 'A-15', 'Jueves', '12:00-13:00'),
('MCR-PS-6IM12', '6IM12', 'Laboratorio G', 'Miercoles', '13:00-15:00'),
('MCR-PS-6IM12', '6IM12', 'Laboratorio G', 'Viernes', '13:00-15:00'),
('MCR-PS-6IM12', '6IM12', 'Laboratorio H', 'Miercoles', '13:00-15:00'),
('MGNI-PM-4IM13', '4IM13', 'Laboratorio C', 'MIercoles', '09:00-10:00'),
('MGNI-PM-4IM13', '4IM13', 'Laboratorio de Dibujo', 'MIercoles', '09:00-10:00'),
('MGNI-PM-4IM13', '4IM13', 'Laboratorio E', 'Viernes', '08:00-10:00'),
('MGNI-PM-4IM14', '4IM14', 'Laboratorio C', 'Miercoles', '10:00-12:00'),
('MGNI-PM-4IM14', '4IM14', 'Laboratorio E', 'Viernes', '10:00-11:00'),
('MGNI-PS-6IM12', '6IM12', 'Laboratorio G', 'Miercoles', '13:00-15:00'),
('MGNI-PS-6IM12', '6IM12', 'Laboratorio G', 'Viernes', '13:00-15:00'),
('MGNI-PS-6IM12', '6IM12', 'Laboratorio H', 'Miercoles', '13:00-15:00'),
('MGNI-RC-4IM13', '4IM13', 'A-1', 'Jueves', '11:00-12:00'),
('MGNI-RC-4IM13', '4IM13', 'Laboratorio E', 'Jueves', '12:00-13:00'),
('MGNI-RC-4IM13', '4IM13', 'Laboratorio E', 'Martes', '10:00-12:00'),
('MGNI-RC-4IM14', '4IM14', 'A-2', 'Viernes', '12:00-13:00'),
('MGNI-RC-4IM14', '4IM14', 'Laboratorio E', 'Jueves', '09:00-10:00'),
('MGNI-RC-4IM14', '4IM14', 'Laboratorio E', 'Martes', '07:00-09:00'),
('MGNI-SI-6IM12', '6IM12', 'A-15', 'Miercoles', '12:00-13:00'),
('MGNI-SI-6IM12', '6IM12', 'Laboratorio G', 'Jueves', '07:00-09:00'),
('RMPA-AB-4IM13', '4IM13', 'A-1', 'Miercoles', '14:00-15:00'),
('RMPA-AB-4IM16', '4IM16', 'A-4', 'Lunes', '12:00-13:00'),
('RMPA-AM-6IM12', '6IM12', 'A-15', 'Martes', '08:00-09:00'),
('RMPA-AM-6IM12', '6IM12', 'Laboratorio G', 'Lunes', '09:00-10:00'),
('RMPA-AM-6IM12', '6IM12', 'Laboratorio G', 'Miercoles', '08:00-10:00'),
('RMPA-AM-6IM13', '6IM13', 'A-16', 'Miercoles', '11:00-12:00'),
('RMPA-AM-6IM13', '6IM13', 'Laboratorio G', 'Lunes', '10:00-12:00'),
('RMPA-AM-6IM13', '6IM13', 'Laboratorio G', 'Miercoles', '10:00-11:00'),
('RMPA-AM-6IM13', '6IM13', 'Laboratorio H', 'Miercoles', '10:00-11:00'),
('RMPA-CBII-2IM1', '2IM1', 'Laboratorio A', 'Lunes', '07:00-09:00'),
('RMPA-CBII-2IM1', '2IM1', 'Laboratorio A', 'Miercoles', '07:00-08:00'),
('RMPA-CBII-2IM1', '2IM1', 'Laboratorio B', 'Lunes', '07:00-09:00'),
('RMPA-CBII-2IM1', '2IM1', 'Laboratorio B', 'Miercoles', '07:00-08:00'),
('RMPA-SI-6IM10', '6IM10', 'A-13', 'Viernes', '14:00-15:00'),
('RMPA-SI-6IM10', '6IM10', 'Laboratorio G', 'Viernes', '11:00-13:00');

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `salon`
--

CREATE TABLE IF NOT EXISTS `salon` (
  `id_Salon` varchar(35) NOT NULL,
  `ubicacion` varchar(25) NOT NULL,
  PRIMARY KEY (`id_Salon`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Volcado de datos para la tabla `salon`
--

INSERT INTO `salon` (`id_Salon`, `ubicacion`) VALUES
('A-1', 'Edificio A'),
('A-13', 'Edificio A'),
('A-14', 'Edificio A'),
('A-15', 'Edificio A'),
('A-16', 'Edificio A'),
('A-2', 'Edificio A'),
('A-3', 'Edificio A'),
('A-4', 'Edificio A'),
('A-6', 'Edificio A'),
('C-1', 'Edificio C'),
('C-16', 'Edificio C'),
('C-2', 'Edificio C'),
('C-3', 'Edificio C'),
('C-4', 'Edificio C'),
('C-5', 'Edificio C'),
('C-6', 'Edificio C'),
('Laboratorio A', 'Edificio B'),
('Laboratorio B', 'Edificio B'),
('Laboratorio C', 'Edificio B'),
('Laboratorio de Dibujo', 'Edificio B'),
('Laboratorio E', 'Edificio B'),
('Laboratorio F', 'Edificio B'),
('Laboratorio G', 'Edificio B'),
('Laboratorio H', 'Edificio B');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
