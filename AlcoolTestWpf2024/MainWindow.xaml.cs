using System;
using System.Windows;
using Wpf_AlcoTest;

namespace AlcoolTestWpf2024
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // Charger le thème par défaut
            ChargerThemeParDefaut();
        }

        private void ChargerThemeParDefaut()
        {
            // Supprimer les dictionnaires actuels
            Application.Current.Resources.MergedDictionaries.Clear();
        }

        private void ChargerThemeNoir()
        {
            // Charger le thème noir
            ResourceDictionary darkTheme = new ResourceDictionary
            {
                Source = new Uri("DarkTheme.xaml", UriKind.Relative)
            };
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(darkTheme);
        }

        private void ThemeSwitchButton_Click(object sender, RoutedEventArgs e)
        {
            // Basculer entre les thèmes
            if (Application.Current.Resources.MergedDictionaries.Count == 0)
            {
                ChargerThemeNoir();
            }
            else
            {
                ChargerThemeParDefaut();
            }
        }

        private void UserProfileButton_Click(object sender, RoutedEventArgs e)
        {
            UserProfileWindow userProfileWindow = new UserProfileWindow();
            userProfileWindow.ShowDialog();
        }

        private void Calculer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Récupérer les valeurs des champs
                int quantite = int.Parse(QuantiteTextBox.Text);
                double tauxAlcool = double.Parse(TauxTextBox.Text);

                // Utiliser le profil utilisateur
                CBuveur buveur = new CBuveur(UserProfile.EstHomme, UserProfile.Poids);

                // Calculer l'alcoolémie
                buveur.MAJ_alcoolemie(quantite, tauxAlcool);

                // Afficher le résultat
                ResultatTextBox.Text = buveur.get_alcoolemie().ToString("F2") + " g/L";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du calcul : " + ex.Message, "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
