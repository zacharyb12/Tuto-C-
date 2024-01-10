using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.IO;

namespace MonTutoCSharp._4.La_persistance_des_données
{
    public class Serialisation_objet_JSON
    {
        public void  afficheSerialisation_objet_JSON()
        {

            //client c1 = new client("bob", "jhon");
            //string jsonString = JsonSerializer.Serialize(c1);
            //File.WriteAllText("C:\\Users\\boual\\Documents\\test.json", jsonString);

            //Deserialisation

            string jsonString = File.ReadAllText("C:\\Users\\boual\\Documents\\test.json");
            client c1 = JsonSerializer.Deserialize<client>(jsonString);




            client c2 = new client("bob", "jhon");
            client c3 = new client("bob", "jhon");

            List<client> list = new List<client>();

            list.Add(c2);
            list.Add(c3);

            string jsonString2 = JsonSerializer.Serialize(list);
            File.WriteAllText("C:\\Users\\boual\\Documents\\test.json",jsonString2);


            List<client> list2 = new List<client>();

            string jsonString3 = File.ReadAllText("C:\\Users\\boual\\Documents\\test.json");
            // list = JsonSerializer.Deserialize<<List<client>>(jsonString3);

        }



        class client
        {
            string _nom;
            string _prenom;



            public client(string Nom,string Prenom)
            {
                _nom = Nom;
                _prenom = Prenom;

            }

        }
        
    }
}

