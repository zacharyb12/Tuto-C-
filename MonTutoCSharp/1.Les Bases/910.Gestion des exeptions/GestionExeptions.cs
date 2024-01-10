using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonTutoCSharp._910.Gestion_des_exeptions
{
    public class GestionExeptions
    {
        public void  afficherGestionExeptions()
        {
            Console.WriteLine("entrez un nombre");
            try 
            { 

                int nb = int.Parse(Console.ReadLine());
                Console.WriteLine($" 1024 / {nb} = {1024/nb}");
            } 
            catch (DivideByZeroException ex) 
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("division par zero impossile");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("la valeur depasse la capacité prevu");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                //exeptions generale
                Console.WriteLine(ex.Message);
            }
            finally 
            {
                //execution finale facultative
                Console.WriteLine("finally");
            }
        }
    }
}
