using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using GSB___JLAME.MODELE;

namespace GSB___JLAME
{
    internal class FicheFraisVueModele
    {
        public List<FicheFrais> Complete(string visiteur)
        {
            List<FicheFrais> fiches = new List<FicheFrais>();

            fiches.Add(new FicheFrais(10, 10, 10, 10, "Situation1", "10/10", "bonjour", 10, "Situation1", "10/10"));

            return fiches;
        }
                              
        public void AddToBD(int rep, int nuit, int eta, int km, string situaF, string dat, string libe, int mont, string situaHF, string dateOpe)
        {
            FicheFrais fiche = new FicheFrais(rep, nuit, eta, km, situaF, dat, libe, mont, situaHF, dateOpe);
            bool exist = true;
            if (exist)
            {
                // TO DO (MODIFIER DANS LA BD)
            }
            else
            {
                // TO DO (AJOUTER A LA BD)
            }
        }

      
    }
}
