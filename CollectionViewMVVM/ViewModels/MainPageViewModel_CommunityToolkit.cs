using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace CollectionViewMVVM.ViewModels
{
    public partial class MainPageViewModel_CommunityToolkit : BaseViewModel_CommunityToolkit
    {
        public MainPageViewModel_CommunityToolkit() {

        }

        [ObservableProperty]
        int count;

        [ObservableProperty]
        string buttonText = "Click Me";


        [RelayCommand]
        private void ButtonClick() // Im View = ButtonClickCommand
        {
            Count++;
            if (Count == 1)
                ButtonText = $"Clicked {Count} time"; // counterBtn.Text = WERT
            else
                ButtonText = $"Clicked {Count} times";
        }


    }
}
