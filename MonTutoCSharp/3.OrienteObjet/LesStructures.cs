using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.OrienteObjet
{
    
    public class LesStructures
    {
        struct LesStructure 
        {
            public string nom {  get; set; }

            //public string prenom { get; set; }

            public LesStructure(string nom)//,string prenom) 
            { 
                this.nom = nom;
            }

            public void Ecrire(string nom) 
            {
                Console.WriteLine(nom);
            }

            //peut etre cree sans operateur new
            //soit incure tout les menbre de la structures
            //la structure ne peut pas etre herité ou herité
            //pas de abstract sealed
            // type valeur la classe est de type references
            //si ca devient volumineux mieux vaut une classe
        
        }

    }
}
