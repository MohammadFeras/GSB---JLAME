using System;
using System.Collections.Generic;
using System.Text;

namespace GSB___JLAME.MODELE
{
    class FicheFrais
    {
        public int Repas { get; set; }
        public int Nuitee { get; set; }
        public int Etape { get; set; }
        public int Km { get; set; }
        public string Situation { get; set; }

        public FicheFrais(int rep, int nuit, int eta, int km, string situa)
        {
            this.Repas = rep;
            this.Nuitee = nuit;
            this.Etape = eta;
            this.Km = km;
            this.Situation = situa;
        }
        
    }
}
