
namespace MauiApp1;

public partial class ControlPage2 : ContentPage
{
	public ControlPage2()
	{
		InitializeComponent();
	}

    private void ButtonBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void checkBoxNotifications_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        switch1.IsToggled = e.Value;
    }

    private void switchNotifications_Toggled(object sender, ToggledEventArgs e)
    {
        checkbox1.IsChecked = e.Value;
    }

    //btnStartActivityIndicator_Clicked
    private async void switchStartProgressBar_Toggled(object sender, EventArgs e)
    {
        if (switchStartProgressBar.IsToggled)
        {
            await progressBar1.ProgressTo(0, 10, Easing.Linear);
            for (double i = 0; i <= 100; i++)
            {
                laProgressState.Text = i.ToString() + " %";
                await progressBar1.ProgressTo(((i+1)/100), 50, Easing.Linear);
                if (!switchStartProgressBar.IsToggled) { break; }
            }
        }
        switchStartProgressBar.IsToggled = false;
    }
}