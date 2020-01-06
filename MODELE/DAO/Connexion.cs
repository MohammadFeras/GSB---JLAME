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

        public static bool RequestLogin(string visiteur)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "SELECT login FROM Visiteur WHERE login ='" + visiteur + "'";

            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();
            bool trouve = dataReader.Read();
            dataReader.Close();
            return trouve;
        }

        public static List<string> RequestCompleteComboBoxLogin()
        {
            List<string> toReturn = new List<string>();
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "SELECT prenom FROM Visiteur";

            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                toReturn.Add(dataReader[0].ToString());
            }
            dataReader.Close();

            return toReturn;
        }

        public static string RequestMDP(string visiteur)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();

            string requete = "SELECT mdp FROM Visiteur WHERE login ='" + visiteur + "'";
            command.CommandText = requete;

            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();
            string mdp = " ";

            if (dataReader.Read())
            {
                mdp = String.Format("{0}", dataReader[0]);
                mdp = mdp.Trim();
            }
            dataReader.Close();
            return mdp;
        }

        

    }
}
