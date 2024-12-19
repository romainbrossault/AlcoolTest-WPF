using System.Windows;

namespace AlcoolTestWpf2024
{
    public partial class UserProfileWindow : Window
    {
        public UserProfileWindow()
        {
            InitializeComponent();
            ChargerProfil();
        }

        private void ChargerProfil()
        {

            PoidsTextBox.Text = UserProfile.Poids.ToString();
            if (UserProfile.EstHomme)
                HommeRadioButton.IsChecked = true;
            else
                FemmeRadioButton.IsChecked = true;
        }

        private void Enregistrer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Sauvegarder les informations dans le profil utilisateur
                UserProfile.Poids = int.Parse(PoidsTextBox.Text);
                UserProfile.EstHomme = HommeRadioButton.IsChecked == true;

                MessageBox.Show("Profil sauvegardé avec succès.", "Information", MessageBoxButton.OK, MessageBoxImage.Information);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Erreur lors de l'enregistrement du profil. Vérifiez les valeurs saisies.", "Erreur", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
