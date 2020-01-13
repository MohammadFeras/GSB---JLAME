using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Globalization;
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
using MySql.Data.MySqlClient;

namespace GSB___JLAME
{

    public partial class ValiderFrais : Window
    {
        private FicheFraisVueModele FicheFraisVueModele;
        

        public ValiderFrais()
        {
            InitializeComponent();

            RemplirComboBoxName();
            RemplirComboBoxSituation();

            /**** Liaison avec la Vue Modèle ****/
            FicheFraisVueModele = new FicheFraisVueModele();
            this.DataContext = FicheFraisVueModele;

            DatePicker1.DisplayDateStart = DateTime.Today.AddYears(-1); // Permet d'éviter de rentrer une date qui dépasse les 1 an avant la date d'aujourd'hui
            DatePicker1.DisplayDateEnd = DateTime.Today; // Permet d'éviter de rentrer une date après la date d'aujourd'hui
            DatePicker1.SelectedDate = DateTime.Today; //Affecter la date d'aujourd'hui en texte par défault dans le datePicker
            MessageBox.Show(DateTime.Today.ToString());
        }

        public void RemplirComboBoxName()
        {
            //**** REMPLIR COMBOBOX NAME ****//
            List<string> item = DAOComptabilite.RequestCompleteComboBoxPrenoms(); //REQUETE POUR COMPLETER COMBOBOX PRENOMS
            SelectName.ItemsSource = item;
        }

        public void RemplirComboBoxSituation()
        {
            //**** REMPLIR COMBOBOX Situation ****//
            List<string> item = DAOComptabilite.AllSituation(); //REQUETE POUR COMPLETER COMBOBOX SITUATIONS
            SelectSituationForfait.ItemsSource = item;
            SelectSituationHorsForfait.ItemsSource = item;
        }

        private void SelectName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string selectedName = SelectName.SelectedItem.ToString();
            Forfait.ItemsSource = FicheFraisVueModele.Complete(selectedName);
            horsForfait.ItemsSource = FicheFraisVueModele.Complete(selectedName);
        }

        private void SelectDate_SelectionChanged(object sender,SelectionChangedEventArgs e)
        {
            DateTime date = DateTime.ParseExact(DatePicker1.SelectedDate.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            string dateStr = date.ToString("y", CultureInfo.CreateSpecificCulture("fr-FR")); // PASSAGE AU FORMAT MOIS/ANNEE  
            MessageBox.Show(date.ToString());
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
