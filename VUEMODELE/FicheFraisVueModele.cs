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

            fiches.Add(new FicheFrais(10, 10, 1, 42, "situation1"));
            fiches.Add(new FicheFrais(10, 10, 1, 42, "situation2"));
            fiches.Add(new FicheFrais(10, 10, 1, 42, "situation3"));
            fiches.Add(new FicheFrais(10, 10, 1, 42, "situation4"));

            return fiches;
        }
        
    }
}
