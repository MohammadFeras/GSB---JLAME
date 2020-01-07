using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GSB___JLAME
{
    class DAOVisiteur
    {
        public static string LoginIn(string visiteur, string mdp)
        {
            string text = "";
            SqlCommand commandlogin = Connexion.GetInstance().CreateCommand();
            commandlogin.CommandText = "SELECT login FROM Visiteur WHERE login ='" + visiteur + "'";
            SqlDataReader dataReaderLogin = commandlogin.ExecuteReader();
            // Lecture des résultats
            if (dataReaderLogin.Read())
            {
                dataReaderLogin.Close();

                SqlCommand commandmdp = Connexion.GetInstance().CreateCommand();
                commandmdp.CommandText = "SELECT mdp FROM Visiteur WHERE login ='" + visiteur + "'";
                SqlDataReader dataReaderMdp = commandmdp.ExecuteReader();
                if (dataReaderMdp.Read())
                {
                    if (!String.Format("{0}", dataReaderMdp[0]).Trim().Equals(mdp))
                    {
                        text = "mot de passe invalide";
                    }
                }
                dataReaderMdp.Close();
            }
            else
            {
                text = "Login inconnu";
            }
            return text;
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
