using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ListGeneriqueFactureEpicerie
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Gestion gestion = new Gestion();    
        public MainWindow()
        {
            InitializeComponent();
            dtArticle.ItemsSource = gestion.Panier;    
        }

        private void Window_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void btn_valider_Click(object sender, RoutedEventArgs e)
        {
            double tva = 0.0;
            if(rbt_7.IsChecked==false && rbtn_20.IsChecked==false)
            {
                MessageBox.Show("Veillez choisir un taux de TVA.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (rbt_7.IsChecked == true)
            {
                tva = 0.07;
            }
            else 
            {
                tva = 0.2;
            }
            if(txt_designation.Text!=string.Empty && txt_prixUnitaire.Text!=string.Empty && txt_quantite.Text!=string.Empty)
            {
                gestion.ajouterArticle(txt_designation.Text, ConvertPoint(txt_prixUnitaire.Text), int.Parse(txt_quantite.Text),tva);
                
                txt_HT.Text=gestion.getTotalHT().ToString();
                txt_TVA.Text=gestion.getTotalTVA().ToString();
                txt_netapayer.Text=gestion.getTotalTTC().ToString();
            
            }
            else
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Gestion de la de conversion des points décimaux
        double ConvertPoint(string sNumber)
        {
            string separator = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            sNumber = sNumber.Replace(",", separator).Replace(".", separator);

            return double.Parse(sNumber);
        }
    }
}
