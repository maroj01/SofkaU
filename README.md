# SofkaU
- Se crea el programa con lenguaje de programación C#.
- Se usa el IDE Visual Studio 2019.
- La base de datos es MYSQL, por medio del gestor de bases de datos phpMyAdmin 5.0.2
- Los datos para realizar la conexión a base de datos, se encuentran en la ruta: \RetoSofka\ConexionBd.cs
- En el proyecto se encuentra el archivo (challenge.sql) de la base de datos.
- La persistencia en la base de datos se presenta en tres momentos:
1- Cuando el jugador pierde.
2- Cuando el jugador se desea retirar.
3- Cuando el jugador es ganador.

Instrucciones de uso

Para iniciar el juego, el jugador debe ingresar su nombre y dar Click en (Registrar participante).
Muestra una de las preguntas, elegida aleatoriamente de la categoría uno de cinco.
El jugador selecciona una opción de respuesta que tiene y da Click en (enviar), si pierde se finaliza el
juego.
Si el jugador gana continua a la siguiente categoría y debe dar Click en (siguiente) para que se habilite la siguiente pregunta.
Si el jugador responde correctamente las preguntas hasta la categoría cinco, es ganador del juego y este se termina.
