using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace GSB___JLAME
{
    public partial class ConsulterFraisVisiteur : Window
    {
        public ConsulterFraisVisiteur()
        {
            InitializeComponent();

            DatePicker1.DisplayDateStart = DateTime.Today.AddYears(-1); // Permet d'éviter de rentrer une date qui dépasse les 1 an avant la date d'aujourd'hui
            DatePicker1.DisplayDateEnd = DateTime.Today; // Permet d'éviter de rentrer une date après la date d'aujourd'hui
            DatePicker1.SelectedDate = DateTime.Today; //Affecter la date d'aujourd'hui en texte par défault dans le datePicker
        }

        private void ValidFrais_Click_1(object sender, RoutedEventArgs e)
        {
            var saisieFrais = new SaisieFrais();
            saisieFrais.Show();
            this.Hide();
        }

        private void LogOut_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new Mainwindow();
            mainWindow.Show();
            this.Hide();
        }

        private void SelectDate_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime date = DateTime.ParseExact(DatePicker1.SelectedDate.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
            string dateStr = date.ToString("y", CultureInfo.CreateSpecificCulture("fr-FR")); // PASSAGE AU FORMAT MOIS/ANNEE
            MessageBox.Show(dateStr);
        }

        private void Forfait_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void HorsForfait_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
