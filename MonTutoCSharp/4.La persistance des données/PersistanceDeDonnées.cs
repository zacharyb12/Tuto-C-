using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MonTutoCSharp._4.La_persistance_des_données
{
    public class PersistanceDeDonnées
    {
        public PersistanceDeDonnées()
        {
            
        // using System.IO

            using(StreamWriter nom = new StreamWriter("C:\\Users\\boual\\Documents\\test.txt"/*string nomName, Encoding encoding*/))
            {
                //si utiliser plusieurs fois reecrit dans le meme fichier
                nom.WriteLine("bonjour texte pour le fichier test.txt");
            }
            //pour ajouter au fichier
            using (StreamWriter ajoutDenote = File.AppendText("C:\\Users\\boual\\Documents\\test.txt"))
            {
                ajoutDenote.WriteLine("ceci est le texte ajouter");
            }

            //pour recuperer le texte du fichier
            using (StreamReader lecteur = new StreamReader("C:\\Users\\boual\\Documents\\test.txt"))
            {
                string texteRecuperer = null;
                 texteRecuperer =lecteur.ReadLine();
                
                while (texteRecuperer != null) 
                {
                    Console.WriteLine(texteRecuperer);
                    texteRecuperer = lecteur.ReadLine();
                }
            }

            //recupere l'integralité du fichier
            using (StreamReader lect = new StreamReader ("C:\\Users\\boual\\Documents\\test.txt"))
            {
                string file = lect.ReadToEnd();
                Console.WriteLine(file);
            }
        

            // et bien d'autres 
        }
    
    }
}
