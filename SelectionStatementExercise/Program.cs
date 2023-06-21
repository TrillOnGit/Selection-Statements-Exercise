namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1,100);
            
            // The following code will allow the user to guess what your favorite number is
            // (be sure to prompt the user what to input):
            Console.WriteLine("Guess what my favorite number is (its a number between 1 and 100)!");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
            {
                Console.WriteLine("You're too low.");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine("That's too high!");
            }
            else
            {
                Console.WriteLine("That's correct!");
            }
        }
    }
}
