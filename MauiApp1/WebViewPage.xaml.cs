namespace MauiApp1;

public partial class WebViewPage : ContentPage
{
	public WebViewPage()
	{
		InitializeComponent();
	}

    private void ButtonBack_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}