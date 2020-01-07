using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security;
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
using GSB___JLAME.VUEMODELE;
using MySql.Data.MySqlClient;

namespace GSB___JLAME
{

    public partial class ValiderFrais : Window
    {
        private FicheFraisVueModele FicheFraisVue;
        private string selectedName;

        public ValiderFrais()
        {
            InitializeComponent();
            RemplirComboBoxName();
            RemplirComboBoxSituation();
            FicheFraisVue = new FicheFraisVueModele();
            this.DataContext = FicheFraisVue;
        }

        public void RemplirComboBoxName()
        {
            //**** REMPLIR COMBOBOX NAME ****//
            List<string> item = DAOVisiteur.RequestCompleteComboBoxLogin();
            SelectName.ItemsSource = item;
        }

        public void RemplirComboBoxSituation()
        {
            //**** REMPLIR COMBOBOX Situation ****//
            List<string> item = DAOComptabilite.AllSituation();
            SelectSituationForfait.ItemsSource = item;
            SelectSituationHorsForfait.ItemsSource = item;
        }

        private void SelectName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedName = SelectName.SelectedItem.ToString();
            Forfait.ItemsSource = FicheFraisVue.Complete();
        }

        private void Effacer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Envoyer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Mois_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Forfait_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void HorsForfait_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NbJustificatif_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new Mainwindow();
            mainWindow.Show();
            this.Hide();
        }

        private void ConsulterFrais_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
