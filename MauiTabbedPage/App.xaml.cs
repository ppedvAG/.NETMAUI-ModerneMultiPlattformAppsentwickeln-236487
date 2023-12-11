namespace MauiTabbedPage
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            
            // MainPage = new AppShell();
            // Hier die MainPage auf eine StartSeite verweisen anstatt auf die AppShell
            MainPage = new MainPage();
        }
    }
}
