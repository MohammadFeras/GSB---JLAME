using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GSB___JLAME
{
    class DAOComptabilite
    {
        public static bool RequestLogin(string comptable)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "SELECT login FROM Visiteur WHERE login ='" + comptable + "'";

            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();
            bool trouve = dataReader.Read();
            dataReader.Close();
            return trouve;
        }

        public static string RequestMDP(string comptable)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();

            string requete = "SELECT mdp FROM Visiteur WHERE login ='" + comptable + "'";
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
