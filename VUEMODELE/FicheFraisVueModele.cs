using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using GSB___JLAME.MODELE;

namespace GSB___JLAME.VUEMODELE
{
    internal class FicheFraisVueModele
    {
        public List<FicheFrais> Complete()
        {
            List<FicheFrais> fiches = new List<FicheFrais>();

            fiches.Add(new FicheFrais(10, 10, 10, 10, "Situation1", "10/10", "bonjour", 10,"Situation1"));
            fiches.Add(new FicheFrais(10, 10, 10, 10, "Situation2", "10/10", "bonjour", 10, "Situation2"));
            fiches.Add(new FicheFrais(10, 10, 10, 10, "Situation3", "10/10", "bonjour", 10, "Situation3"));
            fiches.Add(new FicheFrais(10, 10, 10, 10, "Situation4", "10/10", "bonjour", 10, "Situation4"));

            return fiches;
        }
        
    }
}
