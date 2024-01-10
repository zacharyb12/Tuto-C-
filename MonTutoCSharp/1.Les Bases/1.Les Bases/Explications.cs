using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp
{
    public class Explications
    {
        public void  afficherExplications() 
        { 
            Console.WriteLine("Tout d'abord nous avons notre fichier programme qui se situe dans notre solution qui est a gauche dans l'explorateur de solution");
            Console.WriteLine("Ce sera la base de notre programe la ou va se lancer les methode fonction et autres element du \"programme\"");
            Console.WriteLine("le static void main n'existe plus en dotnet 6.0 il est generé automatiquement par visual studio");
            Console.ReadLine();

            Console.WriteLine("certaines fonctionnalitées dependent des \" using\" comme  system; ou Microoft.Framework.Core;");
            Console.WriteLine("il y a le namespace qui represente le l'espace du projet il peut y avoir plusieurs projet dans un programme ");
            Console.WriteLine("nous avons les classes qui reresentent un objet tout est objet en C# d'ou le nom d'orienté objet");
            Console.WriteLine("les clases contiennent des propriétées et des méthodes ");

            Console.WriteLine("il y a des methodes qui renvoi quelque chose par exemple une valeur int ou string  \"public int Calcul()\" ");
            Console.WriteLine("et des methodes qui vont faire une action ces methodes seront non typé et possederont \"void\" a la place du type \"public void afficherCalcul()\"");
            Console.WriteLine("les methodes possedent des argument typés comme int num ou string mot qui seront utilisés uniquement dans la méthode");
            Console.WriteLine("les ordres donnés au programme se terminent par un - ; - et il y a une sensibilité a la casse majuscule ou minuscule string n'est pas identique a StRiNg");

            Console.WriteLine(" les commentaires sont ecrit avec /* pour ouvrir et */ pour fermer ou // pour mettre la ligne en commentaire");
        }   
    }
}
