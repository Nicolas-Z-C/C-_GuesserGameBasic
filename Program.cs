using System.Linq.Expressions;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                String secretWord = WordSelector();
                const int guesses = 5;
                int uGuesses = guesses;
                string under = " ";
                int spaces = secretWord.Length;
                for (int j = 0; j < spaces; j++)
                {
                    under += "_";
                }

                for (int i = 0; i < guesses; i++)
                {
        
                    Console.WriteLine($"Tienes {uGuesses} intentos");
                    Console.WriteLine($"La palabra que debes encontrar es: {under}");
                    string userGuess = Console.ReadLine().ToUpper();

                    if (userGuess == secretWord)
                    {
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Felicidades has logrado adivinar la palabra");
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Deseas volver a jugar?");
                        Exit();
                    }
                    else
                    {
                        uGuesses--;
                        if (uGuesses == 0)
                        {
                                Console.Clear();
                                Console.WriteLine("Oh no, has utilizado todos tus intentos, deseas volver a intentarlo?");
                                Exit();
                        }
                    }

                }
            }
            
        }
        static void Exit()
        {
            while(true)
            {
                Console.WriteLine("S/N");
                string choice = Console.ReadLine().ToUpper();
                switch (choice)
                {
                    case "S":
                    case "SI":
                    case "Y":
                        return;


                    case "N":
                    case "NO":
                        Console.WriteLine("*******Gracias por jugar*******");
                        Thread.Sleep(1500);
                        System.Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Elige una opcion correcta");
                        continue;
                }
            }
        }
        static string WordSelector()
        {
            Random rnd = new Random();
            string[] wordsBank =
            {
                "ANILLO","ARO","AVION","CARPINCHO","RATA","ALEMAN","VENEZUELA",
            };
            int index = rnd.Next(wordsBank.Length);
            string word = wordsBank[index++];
            return word;
        }
    }
}
