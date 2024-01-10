using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp
{
    public class LeIfinstructionsConditionnelles
    {
        public void  afficheLeIfinstructionsConditionnelles()
        {
            Console.WriteLine("Entrez votre age");
            int input = int.Parse(Console.ReadLine());

            if (input == 0) 
            {
                Console.WriteLine("je doute que vous ayez 0 ans");
            }
            else
                if (input < 18) 
            {
                Console.WriteLine("vous etes mineur");
            }
            else 
            if (input > 18) 
            {
                Console.WriteLine("vous etes majeur ");
            }


        }
    }
}
