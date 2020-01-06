using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
using MySql.Data.MySqlClient;

namespace GSB___JLAME
{
    public partial class LoginComptabilite : Window
    {       

        public LoginComptabilite()
        {
            InitializeComponent();
        }

        string login = " ";

        private void Button_Click_Connect(object sender, RoutedEventArgs e)
        {
            /**** LANCEMENT REQUETE ****/
            bool loginValid = Connexion.RequestLogin(login); //Requête Remplissage d'une tableau login
            string password = Connexion.RequestMDP(login); //Requête test mot de passe

            /**** TEST CONNEXION AVEC LOGIN ET MOT DE PASSE ****/
            if (loginValid && passwordBoxComptabilite.Password.ToString() == password) //"passwordBoxVisiteur.Password" correspond au mdp rentré dans la passwordBox
            {
                invalid.Content = " ";

                /**** LANCEMENT DE LA PAGE ValiderFrais ****/
                var consulterFrais= new ConsulterFraisVisiteur();
                consulterFrais.Show();
                this.Hide();
            }
            else
            {
                invalid.Content = "Login ou mot de passe incorrect"; //S'affiche uniquement si le test de connexion n'est pas valide                       
            }

        }

        /**** RECUPERATION DU LOGIN RENTRE DANS LE TextBox ****/
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            login = sender.ToString();
        }

        /**** CHANGEMENT DE PAGE GRACE A UN BOUTON ****/
        private void Button_Click_Visiteur(object sender, RoutedEventArgs e)
        {
            var visiteur = new LoginVisiteur();
            visiteur.Show();
            this.Hide();
        }

        /**** CHANGEMENT DE PAGE GRACE A UN BOUTON ****/
        private void Button_Click_Accueil(object sender, RoutedEventArgs e)
        {
            var accueil = new Mainwindow();
            accueil.Show();
            this.Hide();
        }

    }
}

