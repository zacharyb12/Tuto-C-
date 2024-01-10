using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.Les_Fondamentaux.Les_Méthodes
{
    public class LaClasseArray
    {
        public LaClasseArray()
        {
            string[] tableau1 = { "zoe", "luc", "marc" };

            string[] tableau2 = new string[tableau1.Length];

            foreach (string tableau in tableau1)
            {
                tableau2 = tableau1;
            }

            Array.Copy(tableau1, tableau2, tableau1.Length);//3);

            Array.Clear(tableau2, 0, 2);

            Array.Reverse(tableau2);

            Array.Resize(ref tableau2 , /*tableau1.Length*/ 10 );

            

        }
    }
}
