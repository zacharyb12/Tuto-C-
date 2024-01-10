using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp.OrienteObjet
{
    public class OrienteObjetintro
    {
        //protected heritage dans les classe enfant
        //private accessible dans la classe uniquement
        private int _id { get; set; }
        private string _name { get; set; }
        private string _description { get; set; }

        public int Id 
        { 
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Description 
        { 
            get { return _description; }
            set { _description = value; }
        }
        
         //constructeur
        public OrienteObjetintro(int Id,string Name,string Description)
        {
            _id = Id;
            _name = Name;
            _description = Description;
        }

        //instanciation 
        
        //Orienteobjetintro objet = new OrienteObjet();
        
        //Orienteobjetintro objet = new ();


    }

}
