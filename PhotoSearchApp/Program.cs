// See https://aka.ms/new-console-template for more information

using System.Runtime.InteropServices;
using PhotoSearch;

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;

        while (!endApp)
        {
            Console.WriteLine("Welcome to the Search Photo.");

            Console.WriteLine("Enter A for album list or P for photo followed by the appropriate ID:");

            Console.WriteLine("To exit type (x)");

            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input not understood, try agian.");
            }

            if (input.Trim().ToLower() == "x")
            {
                Environment.Exit(0);
            }  
            else if (input.ToLower() == "x")
            {
                endApp = true;
            }
            else if (input.Trim().ToLower().StartsWith("a") || input.Trim().ToLower().StartsWith("p"))
            {
                // make call with input
                new Search();
            }
            else
            {
                Console.WriteLine("Input not understood, try again.");
            }
        }
    }
}