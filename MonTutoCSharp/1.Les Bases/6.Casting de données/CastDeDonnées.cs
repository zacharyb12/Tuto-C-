using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.Casting_de_données
{
    public class CastDeDonnées
    {
        public void afficheCastDeDonnées()
        {

            string input = Console.ReadLine();
            int number;
            float nb = 10.85f;
            try
            {
                number = Convert.ToInt32(input);
                Console.WriteLine(number);

                number = int.Parse(input);
                Console.WriteLine(number);
                
                number = (int)nb;
                Console.WriteLine(number);
            }
            catch 
            {
                Console.WriteLine("parse echoué");
            }
            finally 
            {
                Console.WriteLine("fin de l'execution");
            }

            //tentative de convertion de données
            if (int.TryParse(input, out number))
            {
                Console.WriteLine(number);
            }
        }
    }
}
