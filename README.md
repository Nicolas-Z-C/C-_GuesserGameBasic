# Guessing Game - Juego de Adivinanza de Palabras

## Descripción

Este es un juego de consola desarrollado en C# donde el jugador debe adivinar una palabra secreta seleccionada aleatoriamente. El jugador tiene un máximo de 5 intentos para adivinar correctamente la palabra antes de perder la partida.

## Estructura del Proyecto
```
GuessingGame/
|
|--- GuessingGame.csproj
|--- Program.cs          
|--- README.md          
```

## Características

- **Selección aleatoria de palabras**: El juego selecciona una palabra al azar de un banco predefinido
- **Sistema de intentos**: El jugador tiene 5 oportunidades para adivinar la palabra
- **Modo rejugable**: Después de ganar o perder, el jugador puede elegir jugar nuevamente
- **Interfaz simple**: Interacción clara y directa a través de la consola
- **Validación de entrada**: El juego acepta múltiples formatos de respuesta (S/SI/Y para continuar, N/NO para salir)

## Requisitos

- .NET Framework o .NET Core
- Sistema operativo compatible con aplicaciones de consola C#

## Instalación y Ejecución

1. Clona o descarga el proyecto
2. Abre una terminal en la carpeta del proyecto
3. Ejecuta el siguiente comando:
```bash
   dotnet run
```

## Cómo Jugar

1. Ejecuta el programa
2. El juego te mostrará cuántos intentos tienes y la longitud de la palabra oculta (representada con guiones bajos)
3. Escribe tu intento y presiona Enter
4. Si aciertas, ¡felicidades! Si no, se restará un intento
5. Después de 5 intentos fallidos, el juego termina
6. Al finalizar (ganando o perdiendo), puedes elegir jugar de nuevo o salir

## Métodos Principales

- **Main()**: Contiene el bucle principal del juego y la lógica de intentos
- **Exit()**: Maneja la pregunta de continuar o salir del juego, validando las respuestas del usuario
- **WordSelector()**: Selecciona aleatoriamente una palabra del banco de palabras disponibles

## Banco de Palabras

El juego incluye las siguientes palabras:
- ANILLO
- ARO
- AVION
- CARPINCHO
- RATA
- ALEMAN
- VENEZUELA

## Posibles Mejoras Futuras

- Agregar más palabras al banco
- Implementar niveles de dificultad
- Mostrar letras correctas en su posición
- Agregar pistas después de ciertos intentos
- Sistema de puntuación
- Guardar estadísticas del jugador

## Autor

Nicolas-Zabala-Castaneda

## Licencia

Libre uso para propósitos educativos