namespace MauiContentPageNavigation;

public partial class SecondPage : ContentPage
{
    int btnCount = 0;
    public SecondPage(string meinText)
	{
		InitializeComponent();
        laUeberschrift.Text = meinText;
    }

    private void goBack_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void dynButton_Clicked(object sender, EventArgs e)
    {
        string myText = (sender as Button).Text;
        DisplayAlert("Button Event", $"Hallo Button-Event : {myText}","Ok");
    }

    private void newButton_Clicked(object sender, EventArgs e)
    {
        btnCount++;
        var myHorizStyle = new HorizontalStackLayout();
        myHorizStyle.HorizontalOptions = LayoutOptions.Center;
        var myLabel = new Label() { Text=$"Dynlabel {btnCount} -->" };
        var myButton = new Button() { Text = $"Mein Codebehind Button {btnCount}", WidthRequest=250 };
        myButton.Clicked += dynButton_Clicked;

        myHorizStyle.Children.Add(myLabel);
        myHorizStyle.Children.Add(myButton);
        myContent.Children.Add(myHorizStyle);
    }
}