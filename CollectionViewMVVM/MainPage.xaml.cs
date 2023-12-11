using CollectionViewMVVM.ViewModels;

namespace CollectionViewMVVM
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            // Binding nicht vergessen
            BindingContext = new MainPageViewModel_CommunityToolkit();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CollectionPage());
        }
    }

}
