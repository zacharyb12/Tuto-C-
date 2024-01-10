using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.Les_Fondamentaux.Les_Méthodes
{
    public class SurchargeDeMethode
    {
        public void  afficherSurchargeDeMethode()
        {
            // exemple Console.Writeline
            Console.WriteLine("hello");
            Console.WriteLine($"hello {6}");
            Console.WriteLine("hello " + 6 );

            // somme possede desormais deux possibilitées avec deux ou trois valeurs

            Somme(1, 1);
            Somme(1,1,1);
        }

            static void Somme(int nb1 , int nb2)
            {
                Console.WriteLine(nb1 + nb2);
            }

            private static void Somme(int nb1, int nb2, int nb3)
            {
                Console.WriteLine(nb1 + nb2 + nb3);
            }
    }
}
