namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subject in school?");
            string favSubject = Console.ReadLine();

            switch (favSubject)
            {
                case "Math":
                    Console.WriteLine("Nice, I like math...");
                    break;
                case "Biology":
                    Console.WriteLine("Nice, I like biology...");
                    break;
                case "History":
                    Console.WriteLine("Lame..., I'm not into history...");
                    break;
                case "Science":
                    Console.WriteLine("NERD");
                    break;
                case "Art":
                    Console.WriteLine("Awesome, I love art!");
                    break;
                default:
                    Console.WriteLine("Something went wrong...");
                    break;
            }
        }
    }
}