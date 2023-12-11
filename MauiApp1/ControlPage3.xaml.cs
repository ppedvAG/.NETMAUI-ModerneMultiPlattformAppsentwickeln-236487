namespace MauiApp1;

public partial class ControlPage3 : ContentPage
{
	public ControlPage3()
	{
		InitializeComponent();
	}

    private void ButtonBack_Clicked(object sender, EventArgs e)
    {
		Navigation.PopAsync();
    }
}