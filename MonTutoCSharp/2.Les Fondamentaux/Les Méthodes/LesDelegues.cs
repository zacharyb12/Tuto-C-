using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MonTutoCSharp.Les_Fondamentaux.Les_Méthodes
{
    public class LesDelegues
    {
        //declaration
        delegate void MyDelegate(int nb1, int nb2);
        
        public LesDelegues()
        {

            //declaration dans le programme
            MyDelegate myDelegate = delegate
            {
                myDelegate = addition;

                myDelegate += soustraction;
            };

            myDelegate(10, 10);

            void addition(int nb1 , int nb2)
            {
                Console.WriteLine(nb1+nb2);
            }

            void soustraction(int nb1,int nb2)
            {
                Console.WriteLine(nb1-nb2);
            }

            //Actions un type de delegué

            Action<string> affiche;

            affiche = print;

            void print(string str)
            {
                Console.WriteLine(str);
            }

            Action<int> calcul;

            calcul = printCalcul;

            void printCalcul(int str)
            {
                Console.WriteLine(str);
            }

            Action<string> show = str =>Console.WriteLine(str);

            show("texte");

            Action<string> showTwo = delegate (string str)
            {
                Console.WriteLine(str);
            };

            showTwo("Texte");


        }
    }
}
