﻿using System;
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

            bool connect = false;//Reste à false si la connection à la BD est impossible et passe à true si la connection est possible
            
            if (!connect)
            {

                string nomBD = "GSB PPE";//Nom de la BD SQL

                string nomServeur = "BTSWIN7-99\\SQLEXPRESS";//Erwann,Loic,Mohammad
                                    //"BTSWIN7-99";//Jonathan
                                    //"ADMIN-PC\\SQLSERVERPERSO";//Amélie

                string connetionString = "Data Source=" + nomServeur + ";Initial Catalog=" + nomBD + "; Integrated Security=true";//Paramètre de connection à la BD
               
                SqlConnection cnn = new SqlConnection(connetionString);//Création de la connection à la BD SQL Server
                cnn.Open();//Ouverture de la connection SQL
                connect = true;//Connection possible donc passe à true

                if (connect)
                {
                    MessageBox.Show("Vous êtes bien connecté à la BD " + nomBD);

                    /**** TEST CONNEXION AVEC LOGIN ET MOT DE PASSE ****/
                    if (login != " " && passwordBoxComptabilite.Password.ToString() == "visiteur")//"passwordBoxVisiteur.Password" correspond au mdp rentré dans la passwordBox
                    {
                        invalid.Content = " ";

                        var validerFrais = new ValiderFrais();
                        validerFrais.Show();
                        this.Hide();
                    }
                    else
                    {
                        invalid.Content = "Login ou mot de passe incorrect"; //s'affiche uniquement si le test de connexion n'est pas valide
                    }
                }
                else
                {
                    MessageBox.Show("Vous n'êtes pas connecté à la BD " + nomBD);
                }                 
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

