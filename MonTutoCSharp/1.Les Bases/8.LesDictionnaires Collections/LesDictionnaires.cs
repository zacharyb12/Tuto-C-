using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp._8.LesDictionnaires_Collections
{
    public class LesDictionnaires
    {
        public void afficheLesDictionnaires()
        {
            //le dictionnaire est accessible grace a une clé ici int et contient un elementj a cet emplacement ici un string
            Dictionary<int,string> dictionnary = new Dictionary<int,string>();

            dictionnary.Add(1,"bonjour");
            dictionnary.Add(2, "je m'appelle");
            dictionnary.Add(3, "Mr dictionnaire");

            //affiche le nombre d'element
            Console.WriteLine(dictionnary.Count);

            //aller chercher un element grace a sa clé
            Console.WriteLine(dictionnary[1]);

            //supprime un element
            dictionnary.Remove(1);

            if (dictionnary.ContainsKey(1))
            {
                Console.WriteLine(dictionnary[1]);
            }
            else
                Console.WriteLine("le dictionnaire ne contient pas d'element pour la clé [1] ");
        }
    }
}
