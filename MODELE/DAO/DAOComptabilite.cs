using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GSB___JLAME
{
    class DAOComptabilite
    {
        public static string LoginIn(string comptable, string mdp)
        {
            string text = "";
            SqlCommand commandlogin = Connexion.GetInstance().CreateCommand();
            commandlogin.CommandText = "SELECT login FROM Comptable WHERE login ='" + comptable + "'";
            SqlDataReader dataReaderLogin = commandlogin.ExecuteReader();
            // Lecture des résultats
            if (dataReaderLogin.Read())
            {
                dataReaderLogin.Close();

                SqlCommand commandmdp = Connexion.GetInstance().CreateCommand();
                commandmdp.CommandText = "SELECT mdp FROM Comptable WHERE login ='" + comptable + "'";
                SqlDataReader dataReaderMdp = commandmdp.ExecuteReader();
                if (dataReaderMdp.Read())
                {                    
                    if (!String.Format("{0}", dataReaderMdp[0]).Equals(mdp))                    
                    {
                        text = "Mot de passe invalide";
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

        public static List<string> AllSituation()
        {
            List<string> situation = new List<string>();
            SqlCommand commandSituation = Connexion.GetInstance().CreateCommand();
            commandSituation.CommandText = "SELECT libelle FROM Etat";
            SqlDataReader dataReaderSituation = commandSituation.ExecuteReader();

            while (dataReaderSituation.Read())
            {
                situation.Add(String.Format("{0}", dataReaderSituation[0]));
            }
             return situation;
        }

        public static List<string> RequestCompleteComboBoxPrenoms()
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
    }
}
