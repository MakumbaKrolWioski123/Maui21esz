namespace Maui21
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Zmiana(object sender, TextChangedEventArgs e)
        {
            var email = EmailEntry?.Text;
            var password = PasswordEntry?.Text;

            if (!string.IsNullOrWhiteSpace(email) && !string.IsNullOrWhiteSpace(password))
            {
                ZalogujButton.IsVisible = true;
            }
            else
            {
                ZalogujButton.IsVisible = false;
            }
        }

        private void Login(object sender, EventArgs e)
        {
            DisplayAlert("Zalogowano", "Witaj!", "OK");
        }
    }
}
