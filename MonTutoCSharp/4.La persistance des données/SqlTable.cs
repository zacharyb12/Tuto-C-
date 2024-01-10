using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer;
using System.Data.SQLite;
using System.IO;

namespace MonTutoCSharp._4.La_persistance_des_données
{
    public class SqlTable
    {
        public void afficheSqlTable() 
        {
            string BddPath = "C:\\Users\\boual\\Documents\\Bdd.sqlite";
            if (!File.Exists(BddPath)) CreateBDD();

            void CreateBDD()
            {
                SQLiteConnection.CreateFile(BddPath);
                SQLiteConnection con = new SQLiteConnection("Data Source = C:\\Users\\boual\\Documents\\Bdd.sqlite;Version = 3;");
                con.Open();

                string sql = "create table clients" +
                            "(nom varchar(50)," +
                            "prenom varchar(50)";

                SQLiteCommand command = new SQLiteCommand(sql, con);

                command.ExecuteNonQuery();

                con.Close();
            }


        }
    }
}
