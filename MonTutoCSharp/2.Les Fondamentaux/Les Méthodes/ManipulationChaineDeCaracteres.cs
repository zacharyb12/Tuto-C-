using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.Les_Fondamentaux.Les_Méthodes
{
    public class ManipulationChaineDeCaracteres
    {
        public ManipulationChaineDeCaracteres()
        {
            string mystring = ("le c# c'est Top   .   ");

            mystring.Trim();
            mystring.ToLower();
            mystring.ToUpper();

            //remplacer un caractere
            mystring.Replace('C', 'F');

            mystring.Remove(0, 3);
            // c# c'est top

            Console.WriteLine(mystring.Length);

            if(mystring.Contains('.'))
            {
                Console.WriteLine("my string contient bien un point");
            }

            //decoupage

            mystring.Substring(5);
            // a patir du 5iem caractere

            mystring.Substring(0, 3);
            //(0,3) 0 represente l'index de depart de la decoupe et 3 la fin

            string str = "jean,luc,marc,zoe,lana";

            string[] tabstr = str.Split(",");
            

        }
    }
}
