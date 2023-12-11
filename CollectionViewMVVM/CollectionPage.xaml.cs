using CollectionViewMVVM.ViewModels;
using CommunityToolkit.Mvvm.DependencyInjection;

namespace CollectionViewMVVM;

public partial class CollectionPage : ContentPage
{
	public CollectionPage()
	{
		InitializeComponent();
		BindingContext = new CollectionPageViewModel_CommunityToolkit();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ChangeLanguage());
    }
}