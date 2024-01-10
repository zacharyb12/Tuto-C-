using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.Saise_au_Clavier
{
    public class SaisieAuClavier
    {
        public void afficherSaisieAuClavier()
        {
            Console.WriteLine("entrez un nombre");
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine("l'entree au clavier en string a ete traduit en int grace au int.Parse");
            Console.WriteLine("int input = int.Parse(Console.ReadLine());");
            Console.WriteLine("obligatoire pour pouvoir calculer avec l'entrée utilisateur");

        }
    }
}
