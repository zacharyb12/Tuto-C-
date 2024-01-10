using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp
{
    public class lesVariables
    {
        public void affichelesVariables()
        {
            Console.WriteLine("les variables se dans la zone ou elles vont etre utilisées la portée ");
            Console.WriteLine("string mot = \"le mot\"");
            Console.WriteLine("int number = 17");
            // boolean
            bool estvrai = true;
            Console.WriteLine(estvrai);

            //integer
            int age = 33;
            Console.WriteLine(age);

            //float 
            float taille = 1.80F;
            Console.WriteLine(taille);

            //string
            string nom = "mon nom";
            Console.WriteLine(nom);

        }
    }
}
