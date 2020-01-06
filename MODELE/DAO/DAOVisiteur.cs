using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GSB___JLAME
{
    class DAOVisiteur
    {
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

        public static List<string> RequestCompleteComboBoxLogin()
        {
            List<string> toReturn = new List<string>();
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "SELECT prenom FROM Visiteur";

            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.Read())
            {
                string trim = dataReader[0].ToString().Trim();
                toReturn.Add(trim);
            }
            dataReader.Close();

            return toReturn;
        }
    }
}
