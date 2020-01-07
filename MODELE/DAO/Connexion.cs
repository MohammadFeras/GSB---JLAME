using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GSB___JLAME
{
    class Connexion
    {
        private static SqlConnection LaConnexion { get; set; } = null;

        public static SqlConnection GetInstance()
        {
            // Préparation de la connexion à la base de données
            if (LaConnexion == null)
            {
                string nomBD = "GSB PPE";//Nom de la BD SQL
                string nomServeur = "BTSWIN7-99\\SQLEXPRESS";//Erwann,Loic,Mohammad
                                                             //"BTSWIN7-99";//Jonathan
                                                             //"ADMIN-PC\\SQLSERVERPERSO";//Amélie
                string connetionString = "Data Source=" + nomServeur + ";Initial Catalog=" + nomBD + "; Integrated Security=true";//Paramètre de connection à la BD
                LaConnexion = new SqlConnection(connetionString);
                try
                {
                    // Connexion à la base de données
                    LaConnexion.Open();
                    Console.WriteLine("connecté");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("PROBLEME " + ex.Message);
                }
            }
            return LaConnexion;
        }


        private Connexion() { }


        

        

    }
}
