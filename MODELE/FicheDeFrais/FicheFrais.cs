using System;
using System.Collections.Generic;
using System.Text;

namespace GSB___JLAME.MODELE
{
    class FicheFrais
    {
        /**** FORFAIT ****/
        public int Repas { get; set; }
        public int Nuitee { get; set; }
        public int Etape { get; set; }
        public int Km { get; set; }
        public string SituationF { get; set; }

        /**** HORS FORFAIT ****/
        public string Date { get; set; }
        public string Libelle { get; set; }
        public int Montant { get; set; }
        public string SituationHF { get; set; }
        public string DateOperation { get; set; }


        public FicheFrais(int rep, int nuit, int eta, int km, string situaF, string dat, string libe, int mont, string situaHF, string dateOpe)
        {
            /**** FORFAIT ****/
            this.Repas = rep;
            this.Nuitee = nuit;
            this.Etape = eta;
            this.Km = km;
            this.SituationF = situaF;

            /**** HORS FORFAIT ****/
            this.Date = dat;
            this.Libelle = libe;
            this.Montant = mont;
            this.SituationHF = situaHF;
            this.DateOperation = dateOpe;
        }
        
    }
}
