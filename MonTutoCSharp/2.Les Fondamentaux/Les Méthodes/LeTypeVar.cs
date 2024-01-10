using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MonTutoCSharp.Les_Fondamentaux.Les_Méthodes
{
    public class LeTypeVar
    {
        public LeTypeVar()
        {
            var i = "azerty";

            Console.WriteLine(i.GetType());

            i= "texte";

            var j = 22;
            j = j + 1;

            
        }

        
    }
}
