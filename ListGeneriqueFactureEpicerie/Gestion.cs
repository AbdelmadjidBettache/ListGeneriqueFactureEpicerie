using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGeneriqueFactureEpicerie
{
    internal class Gestion
    {
        ObservableCollection<Article> panier;

        internal ObservableCollection<Article> Panier { get => panier;}

        public Gestion()
        {
            this.panier = new ObservableCollection<Article>();   
        }

        public void ajouterArticle(string designation, double prix, int quantite, double tauxTVA)
        {
            Article article = new Article(designation,  prix,  quantite,  tauxTVA);
            this.Panier.Add(article);   
        }

        public double getTotalHT()
        {
            double totaleHT = 0.0;
            foreach (Article article in Panier)
            {
                totaleHT += article.MontantHT;
            }
            return totaleHT;
        }

        public double getTotalTVA()
        {
            double totaleTVA = 0.0;
            foreach (Article article in Panier)
            {
                totaleTVA += article.MontantHT;
            }
            return totaleTVA;
        }

        public double getTotalTTC()
        {
            double totaleTTC = 0.0;
            foreach (Article article in Panier)
            {
                totaleTTC += article.MontantHT;
            }
            return totaleTTC;
        }
    }
}
