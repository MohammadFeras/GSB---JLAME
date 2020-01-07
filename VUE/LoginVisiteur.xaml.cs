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

    public partial class LoginVisiteur : Window
    {
        string login = " ";

        public LoginVisiteur()
        {
            InitializeComponent();
        }


        private void Button_Click_Connect(object sender, RoutedEventArgs e)
        {
            /**** LANCEMENT REQUETE AVEC TEST CONNEXION AVEC LOGIN ET MOT DE PASSE ****/
            string text = DAOVisiteur.LoginIn(login,passwordBoxVisiteur.Password.ToString()); //Requête Test Login    
            invalid.Content = text; // SI login et mdp bon alors le texte vaut " ";

            if (text.Equals(""))
            {
                var validFrais = new SaisieFrais();
                validFrais.Show();
                this.Hide();
            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            /**** RECUPERATION DU LOGIN RENTRE DANS LE TextBox ****/
            login = ((TextBox)sender).Text;
        }


        private void Button_Click_Accueil(object sender, RoutedEventArgs e)
        {
            /**** LANCEMENT DE LA PAGE PRINCIPALE ****/
            var accueil = new Mainwindow();
            accueil.Show();
            this.Hide();
        }


        private void Button_Click_Comptabilite(object sender, RoutedEventArgs e)
        {
            /**** LANCEMENT DE LA PAGE LOGIN COMPTABILITE ****/
            var compta = new LoginComptabilite();
            compta.Show();
            this.Hide();
        }

    }
}
