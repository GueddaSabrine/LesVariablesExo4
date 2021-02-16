using System;

namespace LesVariablesExo4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Monsieur";
            string s2 = " Vincent";
            string s3 = string.Concat(s1, s2);
            int number1 = 1;

            Console.WriteLine("Bonjour " + s3 + ", vous êtes venu nous rendre visite " + number1 + " fois");

        }
    }
}
