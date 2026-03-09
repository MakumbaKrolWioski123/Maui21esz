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

/*Dokumentacja
nazwa funkcji: Zmiana
opis: Funkcja obsługująca zdarzenie zmiany tekstu w kontrolkach EmailEntry i PasswordEntry.
Sprawdza, czy oba pola są wypełnione, i na tej podstawie ustawia widoczność przycisku ZalogujButton.
parametry: object sender, TextChangedEventArgs e
zwracany typ: void
autor: Ja

nazwa funkcji: Login
opis: Funkcja obsługująca zdarzenie kliknięcia przycisku ZalogujButton.
Wyświetla alert z informacją o pomyślnym zalogowaniu.
parametry: object sender, EventArgs e
zwracany typ: void
autor: Ja
*/
