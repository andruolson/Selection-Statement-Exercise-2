namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey, what's your favorite subject in school?");
            
            string userChoise = Console.ReadLine();

            switch (userChoise.ToUpper())
            {
                case "MATH":
                    Console.WriteLine("Gross, I hate math...");
                    break;
                case "SCIENCE":
                    Console.WriteLine("Nerd!");
                    break;
                case "WRITING":
                    Console.WriteLine("You'd think because I can read, I should be able to write..");
                    break;
                case "SPORTS":
                    Console.WriteLine("I'm more of a chess guy.. but sports are cool");
                    break;
                case "ART":
                    Console.WriteLine("I like doing art too!");
                    break;
                default:
                    Console.WriteLine("Ok....");
                    break;
                    
            }
        }
    }
}