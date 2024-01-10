using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace MonTutoCSharp
{
    public class Concatenation
    {
        public void afficheConcatenation()
        {

            int age = 33;
            string nom = "john do";
            Console.WriteLine("bonjour je suis " + nom + " et j'ai " + age + " ans");
            Console.WriteLine($"bonjour je suis {nom} et j'ai {age} ans");

        }
    }
}
