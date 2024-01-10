using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp._9.Enumeration_et_Constantes
{
    public class ConstEtEnum
    {
        public void afficheConstEtEnum()
        {
            //const non modifiable apres initialisation
            const double pi = 3.14;

            const mois m = mois.janvier;
        }

        enum mois 
        { 
            janvier,//index1
            fevrier,//index2
            mars,//index3 etc
            avril,
            mai,
            juin,
            juillet,
            aout,
            septembre,
            octobre,
            novembre,
            decembre   
        }

    }
}
