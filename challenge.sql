-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Servidor: 127.0.0.1:3306
-- Tiempo de generación: 14-01-2022 a las 13:38:52
-- Versión del servidor: 8.0.21
-- Versión de PHP: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Base de datos: `challenge`
--

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `participante`
--

DROP TABLE IF EXISTS `participante`;
CREATE TABLE IF NOT EXISTS `participante` (
  `ID_Participante` int NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(40) NOT NULL,
  `Puntaje` float NOT NULL,
  PRIMARY KEY (`ID_Participante`)
) ENGINE=MyISAM AUTO_INCREMENT=9 DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `participante`
--

INSERT INTO `participante` (`ID_Participante`, `Nombre`, `Puntaje`) VALUES
(1, 'Sindy Isaza', 0),
(2, 'Adriana Rojas', 500),
(3, 'Luz Mary Rojas', 0),
(4, 'Miguel Rueda', 200),
(5, 'Angela Ocampo', 300),
(6, 'Carmen Rodas', 500);

-- --------------------------------------------------------

--
-- Estructura de tabla para la tabla `preguntas`
--

DROP TABLE IF EXISTS `preguntas`;
CREATE TABLE IF NOT EXISTS `preguntas` (
  `Id_Pregunta` varchar(4) NOT NULL,
  `Pregunta` varchar(200) DEFAULT NULL,
  `Respuesta_Uno` varchar(100) DEFAULT NULL,
  `Respuesta_Dos` varchar(100) DEFAULT NULL,
  `Respuesta_Tres` varchar(100) DEFAULT NULL,
  `Respuesta_Cuatro` varchar(100) DEFAULT NULL,
  `Respuesta_Correcta` varchar(100) DEFAULT NULL,
  `Categoria` varchar(3) NOT NULL,
  PRIMARY KEY (`Id_Pregunta`,`Categoria`)
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Volcado de datos para la tabla `preguntas`
--

INSERT INTO `preguntas` (`Id_Pregunta`, `Pregunta`, `Respuesta_Uno`, `Respuesta_Dos`, `Respuesta_Tres`, `Respuesta_Cuatro`, `Respuesta_Correcta`, `Categoria`) VALUES
('1', '¿Cuál es el nombre del río más largo del mundo?', 'Río Nilo', 'Río Amazonas', 'Río Danubio', 'Ninguna de las anteriores', 'Río Amazonas', '1'),
('2', '¿Cuál es el océano más grande del mundo?', 'Océano Pacífico', 'Océano Índico', 'Océano Atlántico', 'Océano Ártico', 'Océano Pacífico', '1'),
('3', '¿Cuál es el país más grande del mundo?', 'China', 'Rusia', 'India', 'Colombia', 'Rusia', '1'),
('4', '¿Cuál es el país que tiene forma de bota?', 'España', 'Honduras', 'Perú', 'Italia', 'Italia', '1'),
('5', '¿Cuál es el país más poblado de la tierra?', 'Estados Unidos', 'China', 'Rusia', 'Japón', 'China', '1'),
('1', '¿Cuál es la ciudad de los rascacielos?', 'Tokio', 'New York', 'Hong Kong', 'Dubái', 'New York', '2'),
('2', '¿En qué país se encuentra ubicada la Casa Rosada?', 'Argentina', 'Chile', 'Mexico', 'Venezuela', 'Argentina', '2'),
('3', '¿Cuál es la capital de Nicaragua?', 'Santiago', 'Brasilia', 'Managua', 'Honduras', 'Managua', '2'),
('4', '¿En qué país está ubicada la ciudad de Medellín?', 'Colombia', 'Venezuela', 'Perú', 'México', 'Colombia', '2'),
('5', '¿En qué continente se encuentra Surinam?', 'África', 'América del Sur', 'Oceanía', 'América del Norte', 'América del Sur', '2'),
('1', '¿Cuál es la nación más pequeña del mundo?', 'Andorra', 'Mónaco', 'El Vaticano', 'Haití', 'El Vaticano', '3'),
('2', '¿Cuándo terminó la II Guerra Mundial?', '1945', '1947', '1943', '1942', '1945', '3'),
('3', '¿En qué año llegó Cristobal Colón a América?', '1429', '1492', '1592', '1428', '1429', '3'),
('4', '¿Cuál es el libro sagrado de los musulmanes?', 'La Biblia', 'El Talmud', 'El Corán', 'Ninguna de las anteriores', 'El Corán', '3'),
('5', '¿En qué país se usó la primera bomba atómica?', 'Rusia', 'Estados Unidos', 'Japón', 'Alemania', 'Japón', '3'),
('1', '¿Cuál es el idioma más antiguo que pervive en Europa?', 'Vasco', 'Inglés', 'Francés', 'Latín', 'Vasco', '4'),
('2', '¿Cuál fue el primer hombre en ir a la luna?', 'Louis Armstrong', 'Neil Armstrong', 'Michael Armstrong', 'Jam Armstrong', 'Neil Armstrong', '4'),
('3', '¿Quién escribió La Odisea?', 'Homero', 'Virgilio', 'Cervantes', 'Bart', 'Homero', '4'),
('4', '¿Cuál es la obra más importante de la literatura en español?', 'El Principito', 'Don Quijote de la Mancha', 'Cien años de soledad', 'Crónicas De Una Muerte Anunciada', 'Don Quijote de la Mancha', '4'),
('5', '¿Cómo se llama el Himno Nacional de Francia?', 'La Internacional', 'La Marsellesa', 'La solitaria', 'La Francesita', 'La Marsellesa', '4'),
('1', '¿Cómo se llama la estrofa poética que está conformada por 10 versos de 8 sílabas cada uno?', 'Décima espinela', 'Decasílabo', 'Decasílabo octogonal', 'Décima', 'Décima espinela', '5'),
('2', '¿Cúal fue el vocalista de la agrupación PXNDX?', 'Jose Madero', 'Arturo Arredondo', 'Jose Morales', 'Michael Jackson', 'Jose Madero', '5'),
('3', '¿Cuáles son las notas musicales?', 'Do, Re, Mi', 'Do, Re, Mi, Sol, La, Si, Do', 'Do, Re, Mi, Fa,', 'Do, Re, Mi, Fa, Sol, La, Si', 'Do, Re, Mi, Fa, Sol, La, Si', '5'),
('4', '¿Quién pintó La noche estrellada?', 'Vincent van Gogh', 'Rembrandt', 'Velazquez', 'Davinci', 'Vincent van Gogh', '5'),
('5', '¿Quién es denominado el Rey del Rock and Roll en Estados Unidos?', 'Bruce Springsteen', 'Michael Jackson', 'Elvis Presley', 'Jason Derulo', 'Elvis Presley', '5');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
