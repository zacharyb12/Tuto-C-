using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.les_Tableaux
{
    public class lesTableauxUnidimensionnels
    {
        public void affichelesTableauxUnidimensionnels()
        {
            Console.WriteLine("tableaux accessible par sa position qui commence a 0");

            Console.WriteLine("tableau de 12 element de type string  de l'index 0 a 11");
            string[] strings = 
            {
                "janvier",
                "fevrier",
                "mars",
                "avril",
                "mai",
                "juin",
                "juillet",
                "aout",
                "septembre",
                "octobre",
                "novembre",
                "decembre"
            };

            Console.WriteLine();
            foreach (string s in strings) 
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("taleaux de int de onze  elements allant de 0 a 10");
            int[] ints = 
            {
                0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };
            foreach (int i in ints) 
            {
                Console.WriteLine(i);
            }

        }
    }
}
