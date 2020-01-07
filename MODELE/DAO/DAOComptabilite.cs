using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace GSB___JLAME
{
    class DAOComptabilite
    {
        public static string RequestLogin(string comptable, string mdp)
        {
            string text = "Login ou mot de passe invalide";
            SqlCommand commandlogin = Connexion.GetInstance().CreateCommand();
            commandlogin.CommandText = "SELECT login FROM Visiteur WHERE login ='" + comptable + "'";
            SqlDataReader dataReaderLogin = commandlogin.ExecuteReader();
            // Lecture des résultats
            if (dataReaderLogin.Read())
            {
                dataReaderLogin.Close();

                SqlCommand commandmdp = Connexion.GetInstance().CreateCommand();
                commandmdp.CommandText = "SELECT mdp FROM Visiteur WHERE login ='" + comptable + "'";
                SqlDataReader dataReaderMdp = commandmdp.ExecuteReader();
                if (dataReaderMdp.Read())
                {                    
                    if (String.Format("{0}", dataReaderMdp[0]).Trim().Equals(mdp))
                    {
                        text = " ";
                    }                    
                }
                dataReaderMdp.Close();
            }            
            return text;
        }
    }
}
