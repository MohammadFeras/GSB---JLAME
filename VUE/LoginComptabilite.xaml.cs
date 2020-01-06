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
            string text = DAOComptabilite.RequestLogin(login); //Requête Test Login    
            invalid.Content = text;

            /**** TEST CONNEXION AVEC LOGIN ET MOT DE PASSE ****/
            if (text == " ")
            {
                var validFrais = new ValiderFrais();
                validFrais.Show();
                this.Hide();
            }           
        }

        /**** RECUPERATION DU LOGIN RENTRE DANS LE TextBox ****/
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            /**** RECUPERATION DU LOGIN RENTRE DANS LE TextBox ****/
            login = ((TextBox)sender).Text;
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

