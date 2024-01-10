using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp._911_L_operateur_ternaire
{
    public class OperationsTernaire
    {
        public void afficherOperationsTernaire()
        {
            //conditions ? bloc vrai: bloc faux

            bool homme = true;

            if (homme) 
            {
                Console.WriteLine("Bonjour Monsieur");
            }
            else
            {
                Console.WriteLine("Bonjour Madame");
            }


            string message = homme ? "Bonjour Monsieur" : "Bonjour Madame";

            Console.WriteLine(message);
        }
    }
}
