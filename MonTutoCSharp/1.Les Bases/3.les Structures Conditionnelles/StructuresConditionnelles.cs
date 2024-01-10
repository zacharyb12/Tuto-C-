using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.les_Structures_Conditionnelles
{
    public class StructuresConditionnelles
    {
        public void afficheStructuresConditionnelles()
        {
            
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("la veleur de i " + i);

            }

            int j = 0;
            //tant que conditions 
            while (j < 3) 
            {
                Console.WriteLine("faire quelque chose");
                j++;
            }
        }
    }
}
