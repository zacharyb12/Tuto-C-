using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.OrienteObjet
{
    public interface IlesIntefaces
    {
        //comme une classe qui est un moule 
        //un contrat qui va definir des methodes et des propriétées

        //vehicule a moteur
        //voiture - bateau

        //utile en cas d'heritage multiple

        int nb { get; set; }

        int nb2 { get; set; }

        //sera implementer dans la classe enfant

        void addition();


        //   :ILesInterfaces

        // le code au dessus doit se retrouver dans la classe enfant

        //int nb { get;set;}

        //int nb2 { get; set; }

        //sera implementer dans la classe enfant

        //void addition()
        // {
        //      Console.Writeline(nb1+nb2);
        // }
    }
}
