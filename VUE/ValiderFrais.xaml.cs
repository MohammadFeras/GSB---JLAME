using System;
using System.Collections;
using System.Collections.Generic;
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

using MySql.Data.MySqlClient;

namespace GSB___JLAME
{

    public partial class ValiderFrais : Window
    {

        public ValiderFrais()
        {
            InitializeComponent();
            RemplirComboBoxName();
        }

        public void RemplirComboBoxName()
        {
            //**** REMPLIR COMBOBOX NAME ****//
            List<string> item = DAOVisiteur.RequestCompleteComboBoxLogin();

            foreach (var name in item)
            {
                SelectName.Items.Add(name);
            }
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

        private void SelectName_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void NbJustificatif_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void dataGrid1_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
