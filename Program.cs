/*
 * Josef Forkman
 * SUT24
 */

public enum ProgramState
{
    Stop,
    Easy,
    Medium,
    Hard,
};

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                ProgramState difficulty;
                ProgramState.TryParse(
                    Ask("select difficulty level Easy, Medium or Hard. If you don´t whant to play type Stop"),
                    out difficulty);

                if (difficulty == ProgramState.Stop)
                {
                    break;
                }

                switch (difficulty)
                {
                    case ProgramState.Easy:
                        Run(6, 10);
                        break;
                    case ProgramState.Medium:
                        Run(5, 25);
                        break;
                    case ProgramState.Hard:
                        Run(3, 50);
                        break;
                }
            }
        }

        private static void Run(int numberOfAtempts, int maxNumber)
        {
            int number = new Random().Next(1, maxNumber);
            int numbersOfguess = 0;

            Console.WriteLine(
                $"Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får {numberOfAtempts} försök att gissa mellan 1 och {maxNumber}.");

            while (!int.TryParse(Ask("Gissa på ett nummer!"), out int guess) || numbersOfguess < numberOfAtempts)
            {
                Console.Clear();
                if (Check(number, guess)) break;
                Console.WriteLine("Försök igen.");
                numbersOfguess++;
            }

            if (numbersOfguess == numberOfAtempts)
            {
                Console.WriteLine($"Tyvärr du lyckades inte gissa talet på {numberOfAtempts} försök!");
            }
        }

        private static string Ask(string question)
        {
            Console.WriteLine(question);

            return Console.ReadLine() ?? "";
        }

        private static bool Check(int number, int guess)
        {
            int radom = new Random().Next(0, 3);
            Console.Clear();
            if (guess == number)
            {
                string[] isEqual = ["Wohoo! Du gjorde det!", "Du vann en guld stjärna", "Du får en kop kaffe"];
                Console.WriteLine(isEqual[radom]);
                return true;
            }

            if (guess < number)
            {
                string[] toSmal = ["Tyvärr du gissade för lågt!", "Nära sjuter ingen hare. Provva med något högre.", "Nästan rätt! Tänk dig ett tal som är ännu större."];
                Console.WriteLine(toSmal[radom]);
                return false;
            }
            string[] toHigh = ["Tyvärr du gissade för högt!", "Det är ett bra försök, men du kan sikta lite lägre nästa gång.", "Lite för högt, men du är nära!"];
            Console.WriteLine(toHigh[radom]);
            return false;
        }
    }
}