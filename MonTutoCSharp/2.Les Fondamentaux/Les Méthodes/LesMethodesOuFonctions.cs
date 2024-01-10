using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.Les_Fondamentaux.Les_Méthodes
{
    public class LesMethodesOuFonctions
    {
        public void  afficherLesMethodesOuFonctions()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*********************");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Une erreur est survenue !");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*********************");
            Console.ForegroundColor = ConsoleColor.White;
        }

        //  le code en dessous permet d'executer le code au dessus
        //  afficherLesMethodesOuFonctions();
        // void donc se contente d'executer une action mais ne renvoie pas de valeur
        // public void  afficherLesMethodesOuFonctions() { code a executer }

        //pour renvoyer une valeur on va typé la methode et  passer en argument le type a renvoyer
        public int RenvoieUneValeur(int nombre1 , int nombre2)
        {
            int nombre = nombre1 + nombre2;
            return nombre;
        }

        //    int result = RenvoieUneValeur(10,10);

        //    result aura pris 20 comme valeur 20
    }
}
