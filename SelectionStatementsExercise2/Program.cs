namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "math":
                    case "mathematics":
                        Console.WriteLine("Math huh, you must be smart.");
                        break;
                case "science":
                    Console.WriteLine("You a science nerd?");
                    break;
                case "english":
                    Console.WriteLine("Me LikE to ReaD 2.");
                    break;
                case "history":
                    Console.WriteLine("History? Like Dinosaurs?");
                    break;
                case "pe":
                    case "physical eduction":
                        Console.WriteLine("No Way, me too!");
                        break;
                default:
                    Console.WriteLine($"{favoriteSubject}? Never heard of it.");
                    break;
            }

        }
    }
}