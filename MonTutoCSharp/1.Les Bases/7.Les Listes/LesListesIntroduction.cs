using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp._7.Les_Listes
{
    public class LesListesIntroduction
    {
        public void afficherLesListesIntroduction()
        {
            List<string> Liststrings = new List<string>();
            Liststrings.Add("alpha");
            Liststrings.Add("bravo");
            Liststrings.Add("charlie");

            Console.WriteLine(Liststrings.Count());
            Console.WriteLine(Liststrings[2]);

            foreach (string str in Liststrings) 
            {
                Console.WriteLine(str);
            }
            // Liststrings. affiche les methode associé au listes



        }
    }
}
