using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GSB___JLAME
{
    class DAOComptabilite
    {
        public static string RequestLogin(string comptable)
        {
            string text = " ";
            SqlCommand command = Connexion.GetInstance().CreateCommand();
            command.CommandText = "SELECT login FROM Visiteur WHERE login ='" + comptable + "'";

            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();
            bool trouve = dataReader.Read();
            if (dataReader.Read())
            {
                bool valid = RequestMDP(comptable);
                if (valid)
                {
                    text = " ";
                }
            }
            else
            {
                text = "Login ou mot de passe invalide";
            }
            dataReader.Close();
            return text;
        }

        public static bool RequestMDP(string comptable)
        {
            SqlCommand command = Connexion.GetInstance().CreateCommand();

            string requete = "SELECT mdp FROM Visiteur WHERE login ='" + comptable + "'";
            command.CommandText = requete;

            // Lecture des résultats
            SqlDataReader dataReader = command.ExecuteReader();
            bool trouve = dataReader.Read();            
            dataReader.Close();
            return trouve;
        }
    }
}
