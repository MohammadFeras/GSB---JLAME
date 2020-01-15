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

    }
}
