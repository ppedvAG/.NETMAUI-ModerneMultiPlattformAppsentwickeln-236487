using System.Collections.ObjectModel;

namespace FlyoutSample;

public partial class MainPageFlyout : ContentPage
{
    public ObservableCollection<MainPageFlyoutMenuItem> MenuItems { get; }
    public MainPageFlyout()
	{
		InitializeComponent();
        MenuItems = new ObservableCollection<MainPageFlyoutMenuItem>(new[]
        {
            new MainPageFlyoutMenuItem
            {
                Title = "Startseite",
                TargetType = typeof(HomePage),
                Image = "home.png"
            },
            new MainPageFlyoutMenuItem
            {
                Title = "Einstellungen",
                TargetType = typeof(SettingsPage),
                Image = "settings.png"
            },
            new MainPageFlyoutMenuItem
            {
                Title = "Flashlight",
                TargetType = typeof(FlashlightPage),
                Image = "taschenlampe.png"
            },
            new MainPageFlyoutMenuItem
            {
                Title = "Map",
                TargetType = typeof(MapPage),
                Image = "kartepin.png"
            }
            ,
            new MainPageFlyoutMenuItem
            {
                Title = "Dateien",
                TargetType = typeof(DateienPage),
                Image = "home.png"
            }
        });
        BindingContext = this;
	}
}
