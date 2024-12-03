namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Ask user for favorite school subject
            Console.WriteLine("What is your favorite school subject?");

            //Storing user answer
            string Subject = Console.ReadLine();

            //Switch statements
            switch (Subject)

            {
                case "Math":
                    Console.WriteLine("You hate Math! It's too difficult.");
                    break;
                case "Science":
                    Console.WriteLine("You love science! You can create experiments!");
                    break;
                case "History":
                    Console.WriteLine("History tells you about the people of the past!");
                    break;
                case "Gym Class":
                    Console.WriteLine("You and everyone else loves gym class!");
                    break;
                case "Art":
                    Console.WriteLine("You love to draw and paint!");
                    break;
                default:
                    Console.WriteLine("I do not know much of this subject");
                    break;
            }
         }
    }
}