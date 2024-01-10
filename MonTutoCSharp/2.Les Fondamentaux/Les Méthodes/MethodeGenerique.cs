using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.Les_Fondamentaux.Les_Méthodes
{
    public class MethodeGenerique
    {
        public void  afficheMethodeGenerique() 
        {
            int nb = 5;

            affiche(nb);

            //avec le <T> est devenue generique

            void affiche<T>(T element)
            {
                Console.WriteLine($"la valeur : {element}");
                Console.WriteLine($"Type : {element.GetType()}");
                Console.WriteLine();
            }
                Console.ReadLine();
        }
    }
}
