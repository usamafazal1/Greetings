using System;

namespace QuestionNo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            // Ask for input and store that input in a string variable 
            string name = Console.ReadLine();
            // Print the string and concatenate the variable
            Console.WriteLine("Hello " + name + "!");
         
        }
    }
}
