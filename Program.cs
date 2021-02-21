using System;

namespace LesVariablesExo4
{
    class Program
    {
        /*Créer trois variables contenant respectivement les éléments suivants :
    Monsieur
    Vincent
    1
 En utilisant les variables, faire en sorte que la console affiche le message suivant :
 « Bonjour Monsieur Vincent, vous êtes venu nous rendre visite 1 fois »*/

        static void Main(string[] args)
        {
            string s1 = "Monsieur";
            string s2 = " Vincent";
            string s3 = string.Concat(s1, s2);
            int number1 = 1;

            Console.WriteLine("Bonjour " + s1 + " " +s2  + ", vous êtes venu nous rendre visite " + number1 + " fois");

        }
    }
}
