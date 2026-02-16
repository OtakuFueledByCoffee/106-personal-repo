// Jonathan Alava
// 1/28/2026
// Practicing how a list of objects work
// It's 2/14/2026 now god I'm behind but I'm finishing it wooooo!
namespace PE_ListOfObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // -------------- Declaring values --------------

            // Creating Roster objects
            Roster allStudents = new Roster();
            Roster freshmen = new Roster();

            string userInput;
            int userInputAsInt = 0;

            // Loop to ask user for input until user chooses to quit

            // Give user options
            Console.Write("Choose 1 of the following options:" +
                "\n1 - Add a student" +
                "\n2 - Change major for a student" +
                "\n3 - Print the rosters" +
                "\n4 - Quit" +
                "\n> ");

            userInput = Console.ReadLine()!;

            // Check if userInput is valid
            while (userInputAsInt < 1 || userInputAsInt > 4)
            {
                while (!int.TryParse(userInput, out userInputAsInt))
                {
                    Console.Write("Invalid input: Integers 1 - 4 only. ");
                    userInput = Console.ReadLine()!;
                }
            }

            // 1 - Add a student
            allStudents.AddStudent();
        }
    }
}
