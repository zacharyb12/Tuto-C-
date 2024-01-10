using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.Les_Fondamentaux.Les_Méthodes
{
    public class MotscléREFetOUT
    {
        // ref passe une variable par valeur 
        //une methode avec ref va utilisé la variable nommée



        void methodeParVal(string str)
        {
            str = "Toto";
        }

        string prenom = "jean";

        //methodeParVal(prenom;) garde le nom jean
        //methodeParRef(prenom;) prend le nom TOTO


        void methodeParRef(ref string str)
        {
            str = "Toto";
        }
    }

}
