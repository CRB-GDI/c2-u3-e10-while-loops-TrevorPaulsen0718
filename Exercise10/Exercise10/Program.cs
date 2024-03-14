using System.ComponentModel.Design;
using System.Xml.Serialization;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
          
        {
            int choice;
            Console.WriteLine("**************");
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine("**************");
            Console.WriteLine("");

            // Choice
            Console.Write("Select Choice (1, 2, 3, 4): ");
            choice = int.Parse(Console.ReadLine());
            Console.WriteLine("");

            while (choice < 4)
            {
                if (choice == 1);
                Console.WriteLine("Starting New Game");

            }

        }
    }
}