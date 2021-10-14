using System;
using System.Linq;
namespace Laborator1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program.RunFirstExercise();
            Program.RunSecondExercise();
        }

        static void RunFirstExercise()
        {
            int employmentYears = 10;
            DateTime endDate = DateTime.UtcNow.AddYears(employmentYears);

            Manager manager = new Manager("Ioana", "Grigore", DateTime.Now, endDate, 5621);
            Architect architect = new Architect("Andrei", "Vasiliu", DateTime.Now, endDate, 3231);

            Employee employee = manager;
            Console.WriteLine(employee.Salutation());
            employee = architect;
            Console.WriteLine(employee.Salutation());

            //Explain the option for Salutation method
            /*
             The Employee abstract class overrides the ToString method to set the common fields serialization method
            and the abstract Salutation method forses the derived clases to implement the method in their own way
             */
        }

        static void RunSecondExercise()
        {
            string sentence = "Create an extension method that allows us computing" +
                " words from a sentence (hint: make use of split extension)";
            string[] words = sentence.SplitToWords();
            Console.WriteLine($"The sentence received: {sentence}");
            Console.WriteLine($"The words extracted: [{string.Join(", ", words)}]");
        }
    }
}
