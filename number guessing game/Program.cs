using System.Threading.Channels;

namespace number_guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isCorrectguess = false;
            Random random = new Random();
            int randomNum = random.Next(1, 11);

            Console.WriteLine("Welcome to my number guessing game");
            Console.WriteLine("A number between 1 and 10 will be generated.");
            Console.WriteLine("If you guess the correct number you will win");

            while (!isCorrectguess)
            {
                Console.WriteLine("please guess a number.");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > randomNum)
                {
                    Console.WriteLine("your guess is too high");
                }
                else if(guess < randomNum)
                {
                    Console.WriteLine("your guess is too low ");
                }
                else
                {
                    Console.WriteLine("your guess is correct");
                    isCorrectguess = true;
                }
            }
            Console.WriteLine("congratulations you won the game!!!");
        }
    }
}
