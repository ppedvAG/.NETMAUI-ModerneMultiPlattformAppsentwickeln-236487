namespace MauiApp1;

public partial class ControlPage1 : ContentPage
{
	public ControlPage1()
	{
		InitializeComponent();
	}

    private void _DisplayAlert(string message)
    {
        DisplayAlert(this.Title, message, "Ok");
    }

    private void ButtonBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void buttonClickMe_Clicked(object sender, EventArgs e)
    {
        _DisplayAlert("buttonClickMe_Clicked");
    }

    private void imageButtonLogo_Clicked(object sender, EventArgs e)
    {
        _DisplayAlert("imageButtonLogo_Clicked");
    }

    private void entryEmail_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (e.NewTextValue.Length > 9)
        {
            _DisplayAlert("entryEmail_TextChanged");
        }
    }

    private void searchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        _DisplayAlert("searchBar_SearchButtonPressed");
    }
}