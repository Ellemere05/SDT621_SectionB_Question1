namespace SDT621_SectionB_Question1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Structure of a C# Program Demo!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!\n");

            Console.WriteLine("Program Structure Demonstrated:" +
                "\n1. using System : imports functionality" +
                "\n2. namespace : organizes code" +
                "\n3. class Program : container for code" +
                "\n4. Main() : entry point of program" +
                "\n5. Comments :  explain logic and documentation\n" +
                "\nProgram Executed Successfully!");
        }
    }
}
