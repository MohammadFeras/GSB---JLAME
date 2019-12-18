using System;
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

        public LoginVisiteur()
        {
            InitializeComponent();
        }

        string login = " ";

        private void Button_Click_Connect(object sender, RoutedEventArgs e)
        {
            bool connect = false;//Reste à false si la connection à la BD est impossible et passe à true si la connection est possible

            if (!connect)
            {
                string nomBD = "GSB PPE"; //Nom de la BD SQL
                string dataSource = "BTSWIN7-99\\SQLEXPRESS"; //à changer en fonction de l'ordinateur
                string connetionString = "Data Source="+dataSource+";Initial Catalog="+nomBD+"; Integrated Security=true"; //Paramètre de connection à la BD
                
                SqlConnection cnn = new SqlConnection(connetionString); //Création de la connection à la BD SQL Server
                cnn.Open(); //Ouverture de la connection SQL
                connect = true; //Connection possible donc passe à true

                if (connect)
                {
                    MessageBox.Show("Vous êtes bien connecté à la BD " + nomBD );

                    /**** TEST CONNEXION AVEC LOGIN ET MOT DE PASSE ****/
                    if (login != " " && passwordBoxVisiteur.Password.ToString() == "visiteur") //"passwordBoxVisiteur.Password" correspond au mdp rentré dans la passwordBox
                    {
                        invalid.Content = " ";

                        /**** LANCER UNE REQUETE SQL ****/
                        string queryString = "SELECT * FROM Etat";
                        SqlCommand command = new SqlCommand(queryString, cnn);

                        /**** AFFICHAGE LE RESULTAT D'UNE REQUETE SQL ****/
                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            MessageBox.Show(String.Format("{0}, {1}",
                                            reader[0], reader[1]));
                        }
                    }
                    else
                    {
                        invalid.Content = "Login ou mot de passe incorrect";//s'affiche uniquement si le test de connexion n'est pas valide                       
                    }               
                }
                else
                {
                    MessageBox.Show("Vous n'êtes pas connecté à la BD " + nomBD);
                    connect = false;
                }
            }
        }

        /**** RECUPERATION DU LOGIN RENTRE DANS LE TextBox ****/
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            login = sender.ToString();
        }

        /**** CHANGEMENT DE PAGE GRACE A UN BOUTON ****/
        private void Button_Click_Accueil(object sender, RoutedEventArgs e)
        {
            var accueil = new Mainwindow();
            accueil.Show();
            this.Hide();
        }

        /**** CHANGEMENT DE PAGE GRACE A UN BOUTON ****/
        private void Button_Click_Comptabilite(object sender, RoutedEventArgs e)
        {
            var compta = new LoginComptabilite();
            compta.Show();
            this.Hide();
        }
    }
}
