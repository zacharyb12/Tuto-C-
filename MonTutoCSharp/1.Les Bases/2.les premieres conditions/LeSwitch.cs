using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp
{
    public class LeSwitch
    {
        public void afficheLeSwitch() 
        {
            Console.WriteLine("entrez a , b ou c");
            string input = Console.ReadLine();

            switch(input) 
            {
                case "a":
                    Console.WriteLine("vous avez entrez a");
                    break;
                case "b":
                    Console.WriteLine("vous avez entrez b");
                    break;
                case "c":
                    Console.WriteLine("vous avez  entrez c");
                    break;
            }
        }
    }
}
