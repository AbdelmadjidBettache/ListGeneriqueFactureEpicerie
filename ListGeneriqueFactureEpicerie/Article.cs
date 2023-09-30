using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneriqueFactureEpicerie
{
    internal class Article //DAO
    {
        private string designation;
        private double prix;
        private int quantite;
        private double montantHT;
        private double montantTVA;
        private double montantTTC;
        private double tauxTVA;

        public string Designation { get => designation; set => designation = value; }
        public double Prix { get => prix; set => prix = value; }
        public int Quantite { get => quantite; set => quantite = value; }
        public double MontantHT { get => montantHT; set => montantHT = value; }
        public double MontantTVA { get => montantTVA; set => montantTVA = value; }
        public double MontantTTC { get => montantTTC; set => montantTTC = value; }
        public double TauxTVA { get => tauxTVA; set => tauxTVA = value; }

        public Article(string designation, double prix, int quantite, double tauxTVA)
        {
            this.designation = designation;
            this.prix = prix;
            this.quantite = quantite;
            this.tauxTVA = tauxTVA;
            montantHT = prix * quantite;
            montantTVA=montantHT*tauxTVA;
            montantTTC = montantHT + montantTVA;
        }

       
    }
}
