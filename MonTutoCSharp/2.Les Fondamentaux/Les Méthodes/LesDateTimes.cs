using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.Les_Fondamentaux.Les_Méthodes
{
    public class LesDateTimes
    {
        public LesDateTimes()
        {
            DateTime maintenant = DateTime.Now;

            Console.WriteLine(maintenant);

            Console.WriteLine(maintenant.Day);
            Console.WriteLine(maintenant.Minute);
            Console.WriteLine(maintenant.Year);

            TimeSpan heureDuJour = maintenant.TimeOfDay;
            Console.WriteLine("heure actuelle " + heureDuJour);
            // heure actuelle 17:11:15:3033215

            //cree une intervalle

            TimeSpan interval = new TimeSpan(0, 10, 0);

            Console.WriteLine("heure plus dix minutes " + heureDuJour + interval);
            //heure plus dix minutes 17:21:15:3033215

        }
    }
}
