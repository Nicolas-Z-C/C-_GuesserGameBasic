using System.Linq.Expressions;
namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bucle principal del juego que permite jugar múltiples partidas
            while (true)
            {
                Console.Clear();
                // Selecciona una palabra secreta aleatoria del banco de palabras
                String secretWord = WordSelector();
                // Define el número máximo de intentos permitidos
                const int guesses = 5;
                // Variable que rastrea los intentos restantes del usuario
                int uGuesses = guesses;
                // Inicializa la cadena que mostrará los guiones bajos (palabra oculta)
                string under = " ";
                // Obtiene la longitud de la palabra secreta
                int spaces = secretWord.Length;
                // Crea los guiones bajos según la longitud de la palabra
                for (int j = 0; j < spaces; j++)
                {
                    under += "_";
                }
                // Bucle principal de intentos (máximo 5 intentos por partida)
                for (int i = 0; i < guesses; i++)
                {
                    // Muestra los intentos restantes al usuario
                    Console.WriteLine($"Tienes {uGuesses} intentos");
                    // Muestra la palabra oculta con guiones bajos
                    Console.WriteLine($"La palabra que debes encontrar es: {under}");
                    // Lee la entrada del usuario y la convierte a mayúsculas
                    string userGuess = Console.ReadLine().ToUpper();
                    // Verifica si el usuario adivinó correctamente la palabra
                    if (userGuess == secretWord)
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Felicidades has logrado adivinar la palabra");
                        Console.WriteLine("-------------------------------------------");
                        // Pregunta si el usuario quiere jugar de nuevo
                        Console.WriteLine("Deseas volver a jugar?");
                        Exit();
                    }
                    else
                    {
                        // Decrementa el contador de intentos restantes
                        uGuesses--;
                        // Verifica si se agotaron todos los intentos
                        if (uGuesses == 0)
                        {
                            // Limpia la consola antes de mostrar el mensaje de derrota
                            Console.Clear();
                            Console.WriteLine("Oh no, has utilizado todos tus intentos, deseas volver a intentarlo?");
                            // Llama a la función Exit para preguntar si quiere jugar de nuevo
                            Exit();
                        }
                    }
                }
            }

        }
        // Función que maneja la salida del juego o reinicio de partida
        static void Exit()
        {
            // Bucle que valida la respuesta del usuario (S/N)
            while (true)
            {
                Console.Clear();
                // Muestra las opciones disponibles
                Console.WriteLine("S/N");
                // Lee la respuesta del usuario y la convierte a mayúsculas
                string choice = Console.ReadLine().ToUpper();
                // Evalúa la elección del usuario
                switch (choice)
                {
                    // Casos para continuar jugando (S, SI, Y)
                    case "S":
                    case "SI":
                    case "Y":
                        return; // Retorna al juego para iniciar una nueva partida
                    // Casos para salir del juego (N, NO)
                    case "N":
                    case "NO":
                        // Muestra mensaje de despedida
                        Console.WriteLine("*******Gracias por jugar*******");
                        // Pausa de 1.5 segundos antes de cerrar
                        Thread.Sleep(1500);
                        // Termina la ejecución del programa
                        System.Environment.Exit(0);
                        break;
                    // Caso para opciones inválidas
                    default:
                        Console.WriteLine("Elige una opcion correcta");
                        continue; // Repite el bucle para pedir una opción válida
                }
            }
        }
        // Función que selecciona aleatoriamente una palabra del banco de palabras
        static string WordSelector()
        {
            // Crea una instancia del generador de números aleatorios
            Random rnd = new Random();
            // Banco de palabras disponibles para el juego
            string[] wordsBank =
            {
                "ANILLO","ARO","AVION","CARPINCHO","RATA","ALEMAN","VENEZUELA",
            };
            // Genera un índice aleatorio dentro del rango del array
            int index = rnd.Next(wordsBank.Length);
            // Selecciona la palabra en la posición del índice aleatorio
            string word = wordsBank[index++];
            // Retorna la palabra seleccionada
            return word;
        }
    }
}