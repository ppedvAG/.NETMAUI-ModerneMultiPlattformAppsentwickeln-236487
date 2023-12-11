namespace FlyoutSample;

public partial class MapPage : ContentPage
{
    string name = "ALDI International Services SE & Co. oHG";
    string latitude = 51.410764140383705.ToString();
    string longitude = 6.871278390386222.ToString();
    string locality = "Mülheim an der Ruhr";
    string adminArea = "";
    string thoroughfare = "Mintarder Straße 36-40";
    string country = "Deutschland";
    string zipCode = "45481";
    int navigationMode = 0;

    public MapPage()
	{
		InitializeComponent();
        txNamePin.Text = name;

        txAdminArea.Text = adminArea;
        txCountry.Text = country;
        txLocality.Text = locality;
        txThoroughfare.Text = thoroughfare;
        txZipCode.Text = zipCode;

        txLatitude.Text = latitude;
        txLongitude.Text = longitude;
	}

    private void launchPlacemark_Clicked(object sender, EventArgs e)
    {
        OpenPlacemark();
    }

    async void OpenLocation()
    {
        var canOpen = await Map.TryOpenAsync(
            double.Parse(txLatitude.Text),
            double.Parse(txLongitude.Text),
            new MapLaunchOptions
            {
                Name = txNamePin.Text,
                NavigationMode = (NavigationMode)navigationMode
            });

        if (!canOpen)
        {
            await DisplayAlert("Problem Karte", "Die Karte kann nicht geöffnet werden, was möglicherweise daran liegt, dass keine Standard-Karten-App installiert ist.", "OK");
        }
    }

    async void OpenPlacemark()
    {
        var placemark = new Placemark
        {
            Locality = txLocality.Text,
            AdminArea = txAdminArea.Text,
            CountryName = txCountry.Text,
            Thoroughfare = txThoroughfare.Text,
            PostalCode = txZipCode.Text
        };
        
        var canOpen = await Map.TryOpenAsync(placemark, new MapLaunchOptions
        {
            Name = txNamePin.Text,
            NavigationMode = (NavigationMode)navigationMode
        });

        if (!canOpen)
        {
            await DisplayAlert("Problem Karte", "Die Karte kann nicht geöffnet werden, was möglicherweise daran liegt, dass keine Standard-Karten-App installiert ist.", "OK");
        }
    }

    private void launchLocation_Clicked(object sender, EventArgs e)
    {
        OpenLocation();
    }
}