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
            List<string> situation = new List<string>(4);
            SqlCommand commandSituation = Connexion.GetInstance().CreateCommand();
            commandSituation.CommandText = "SELECT libelle FROM Etat";
            SqlDataReader dataReaderSituation = commandSituation.ExecuteReader();

            while (dataReaderSituation.Read())
            {
                situation.Add(String.Format("{0}", dataReaderSituation[0]));
            }
             return situation;
        }
    }
}
