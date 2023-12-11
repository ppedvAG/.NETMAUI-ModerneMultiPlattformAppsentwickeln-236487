using System.Globalization;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SecondPage());
        }

        private void ToolbarItem1_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ControlPage1());
        }

        private void ToolbarItem2_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ControlPage2());
        }

        private void ToolbarItem3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ControlPage3());
        }

        private void ToolbarItem4_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new WebViewPage());
        }
    }
}
