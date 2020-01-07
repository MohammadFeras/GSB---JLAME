using System;
using System.Collections.Generic;
using System.Text;

namespace GSB___JLAME.MODELE.UTILISATEURS
{
   public interface IUtilisateurs
    {
        string Login
        {
            get;
            set;
        }

        string Mdp
        {
            get;
            set;
        }
    }
}
