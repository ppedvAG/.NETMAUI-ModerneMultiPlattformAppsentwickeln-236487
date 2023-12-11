namespace MauiTabbedPage;

public partial class TabPageFlashlight : ContentPage
{
	public TabPageFlashlight()
	{
		InitializeComponent();
	}

    private async void switchFlashlight_Toggled(object sender, ToggledEventArgs e)
    {
        try
        {
            if (e.Value)
            {
                await Flashlight.TurnOnAsync();
            }
            else
            {
                await Flashlight.TurnOffAsync();
            }
        }
        catch (FeatureNotSupportedException fnsEx)
        {
            await DisplayAlert("Flashlight Problem", $"Unable toggle flashlight: {fnsEx.Message}", "Ok");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Flashlight Problem", $"Unable toggle flashlight: {ex.Message}", "Ok");
        }
    }
}