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
            /**** LANCEMENT REQUETE ****/
            bool loginValid = Connexion.RequestLogin(login); //Requête Test Login            

            /**** TEST CONNEXION AVEC LOGIN ET MOT DE PASSE ****/
            if (loginValid)
            {
                string password = Connexion.RequestMDP(login); //Requête test mot de passe

                if (passwordBoxVisiteur.Password.ToString().Equals(password))
                {
                    invalid.Content = " ";

                    /**** LANCEMENT DE LA PAGE ValiderFrais ****/
                    var validFrais = new ValiderFrais();
                    validFrais.Show();
                    this.Hide();
                }
                else
                {
                    invalid.Content = "Mot de passe incorrect"; //S'affiche uniquement si le test de connexion n'est pas valide
                }
            }
            else
            {
                invalid.Content = "Login incorrect"; //S'affiche uniquement si le test de connexion n'est pas valide                       
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
