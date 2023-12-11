namespace MauiContentPageNavigation
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }


        private void btnNextPage_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage("Dies ist mein neuer Text"));
        }
    }

}
