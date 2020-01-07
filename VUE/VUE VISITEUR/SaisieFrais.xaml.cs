using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GSB___JLAME
{

    public partial class SaisieFrais : Window
    {
        public SaisieFrais()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
    
        }

        private void Button_Click_Comptabilite(object sender, RoutedEventArgs e)
        {
            var consulter = new ConsulterFraisVisiteur();
            consulter.Show();
            this.Hide();
        }

        private void Button_Click_Visiteur(object sender, RoutedEventArgs e)
        {
            var saisie = new SaisieFrais();
            saisie.Show();
            this.Hide();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = new Mainwindow();
            mainWindow.Show();
            this.Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var consulterFraisVisiteur = new ConsulterFraisVisiteur();
            consulterFraisVisiteur.Show();
            this.Hide();
        }
    }
}
