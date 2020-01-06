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

        public static bool RequestLogin(string login)
        {
            bool valid = false;
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "SELECT login FROM Visiteur";

            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                if (login.Equals(String.Format("{0}", dataReader[0])))
                {
                    valid = true;
                }
            }
            dataReader.Close();
            return valid;
        }

        public static string RequestMDP(string visiteur)
        {
            string mdp = " ";

            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "SELECT mdp FROM Visiteur WHERE login ='" + visiteur + "'";

            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();

            if (dataReader.Read())
            {
                    mdp = String.Format("{0}", dataReader[0]);
            }
            dataReader.Close();
            return mdp;
        }

        

    }
}
