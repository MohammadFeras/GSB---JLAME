using System;
using System.Collections.Generic;
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

namespace GSB___JLAME
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class Mainwindow : Window
    {
        public Mainwindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Comptabilite(object sender, RoutedEventArgs e)
        {
            var compta = new LoginComptabilite();
            compta.Show();
            this.Hide();            
        }
        
        private void Button_Click_Visiteur(object sender, RoutedEventArgs e)
        {
            var visiteur = new LoginVisiteur();
            visiteur.Show();
            this.Hide();
        }

    }
}
