using System;
using System.Collections.Generic;
using System.Text;

namespace GSB___JLAME.MODELE.UTILISATEURS
{
    public abstract class Utilisateurs : IUtilisateurs
    {
        protected string mdp;
        protected string login;
        protected string mail;
        protected string numeroTel;

        public string Login
        {
            get { return login; }
            set { Login = value; }
        }

        public string Mdp
        {
            get { return mdp; }
            set { mdp = value; }
        }

        public Utilisateurs(string login,string pwd)
        {
            this.login = login;
            this.mdp = pwd;
        }
    }
}
