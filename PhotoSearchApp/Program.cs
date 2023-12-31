﻿// See https://aka.ms/new-console-template for more information

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

            input = input.Trim().ToLower();

            if (input == "x")
            {
                Environment.Exit(0);
            }  
            else if (input == "x")
            {
                endApp = true;
            }
            else if (input.StartsWith("a") || input.Trim().ToLower().StartsWith("p"))
            {
                int result = 0;

                if (int.TryParse(input.Substring(1), out result))
                {
                    Search search = new Search();
                    Console.WriteLine(search.GetPhotoOrAlbum(input));
                }
                else
                {
                    Console.WriteLine("Input not understood, try again.");
                }

            }
            else
            {
                Console.WriteLine("Input not understood, try again.");
            }

            Console.WriteLine("------------------------\n");
        }
    }
}