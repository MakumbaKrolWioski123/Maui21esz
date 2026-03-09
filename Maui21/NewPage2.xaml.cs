namespace Maui21;

public partial class NewPage2 : ContentPage
{
	public NewPage2()
	{
		InitializeComponent();
	}

	void OnPickerSelected(object sender, EventArgs e)
	{
		if (PickerTemat.SelectedIndex == 0) 
		{ 
			PickerPriorytet.IsEnabled = true;
			PickerPriorytet.ItemsSource = new[] {"Niski","Œredni","Wysoki" };

        }
		else if (PickerTemat.SelectedIndex == 1)
		{	
			PickerPriorytet.IsEnabled = true;
            PickerPriorytet.ItemsSource = new[] { "Niski", "Œredni" };
        }
		else
		{
			PickerPriorytet.IsEnabled = false;
			PickerPriorytet.SelectedIndex = -1;
        }
    }

	void OnButtonClicked(object sender, EventArgs e)
	{
		var imie = ImieEntry.Text;
		var email = EmailEntry.Text;
		var temat = PickerTemat.SelectedItem;
		var priorytet = PickerPriorytet.SelectedItem;
		if (priorytet == null) priorytet = "Brak";
        var kopia = Kopia.IsChecked;
		if(!string.IsNullOrWhiteSpace(imie) && !string.IsNullOrWhiteSpace(email) && temat != null)
		{
			DisplayAlert("Dziêkujemy!", $"Twoja wiadomoœæ zosta³a wys³ana.\nImiê: {imie}\nEmail: {email}\nTemat: {temat}\nPriorytet: {priorytet}\nKopia: {(kopia ? "Tak" : "Nie")}", "OK");
        }
	}
}

/*Dokumentacja
nazwa funkcji: OnPickerSelected
opis: Funkcja obs³uguj¹ca zdarzenie zmiany wyboru w kontrolce PickerTemat.
W zale¿noœci od wybranego tematu, ustawia dostêpnoœæ i zawartoœæ kontrolki PickerPriorytet.
parametry:object sender, EventArgs e
zwracany typ: void
autor: Ja

nazwa funkcji: OnButtonClicked
opis: Funkcja obs³uguj¹ca zdarzenie klikniêcia przycisku.
Pobiera dane z ró¿nych kontrolek, sprawdza ich poprawnoœæ i 
wyœwietla alert z podsumowaniem wprowadzonych informacji.
parametry: object sender, EventArgs e
zwracany typ: void
autor: Ja
*/