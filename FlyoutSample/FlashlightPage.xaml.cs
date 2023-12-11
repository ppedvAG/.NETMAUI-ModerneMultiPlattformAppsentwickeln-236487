namespace FlyoutSample;

public partial class FlashlightPage : ContentPage
{
	public FlashlightPage()
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
            await DisplayAlert("Flashlight Problem", $"Taschenlampen-Problem: {fnsEx.Message}", "Ok");
        }
        catch (Exception ex)
        {
            await DisplayAlert("Flashlight Problem", $"Taschenlampen-Problem: {ex.Message}", "Ok");
        }
    }
}