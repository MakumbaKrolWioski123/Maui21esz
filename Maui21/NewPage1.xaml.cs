namespace Maui21;

public partial class NewPage1 : ContentPage
{
    public NewPage1()
    {
        InitializeComponent();
    }

    void OnCheckboxCheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (AcceptCheckBox.IsChecked)
        {
            ZajerestrujButton.IsVisible = true;
        }
        else
        {
            ZajerestrujButton.IsVisible = false;
        }
    }

    private void ZajerestrujButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Gratulacje!", "Zosta³eœ zarejestrowany!", "OK");
    }
}

/*Dokumentacja
nazwa funkcji: OnCheckboxCheckedChanged
opis: Funkcja obs³uguj¹ca zdarzenie zmiany stanu kontrolki CheckBox o nazwie AcceptCheckBox.
parametry: object sender, CheckedChangedEventArgs e
zwracany typ: void
autor: Ja

nazwa funkcji: ZajerestrujButton_Clicked
opis: Funkcja obs³uguj¹ca zdarzenie klikniêcia przycisku ZajerestrujButton.
Wyœwietla alert z gratulacjami po klikniêciu przycisku.
parametry: object sender, EventArgs e
zwracany typ: void
autor: Ja
*/