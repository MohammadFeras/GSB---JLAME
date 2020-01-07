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
using System.Windows.Shapes;

namespace GSB___JLAME
{
    /// <summary>
    /// Logique d'interaction pour ConsulterFraisVisiteur.xaml
    /// </summary>
    public partial class ConsulterFraisVisiteur : Window
    {
        public ConsulterFraisVisiteur()
        {
            InitializeComponent();
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
    }
}
