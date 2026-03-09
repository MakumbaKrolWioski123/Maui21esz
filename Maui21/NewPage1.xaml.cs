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