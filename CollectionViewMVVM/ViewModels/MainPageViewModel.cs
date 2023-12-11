using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollectionViewMVVM.ViewModels
{
    internal class MainPageViewModel : BaseViewModel
    {
        public MainPageViewModel() {
            ButtonClickCommand = new Command(ExecuteButtonClickCommand);
        }


        private int _count {  get; set; }
        public int Count
        {
            get { return _count; }
            set
            {
                _count = value;
                OnPropertyChanged(nameof(Count));
            }
        }

        private string _ButtonText { get; set; } = "Click Me";
        public string ButtonText
        {
            get { return _ButtonText; }
            set
            {
                _ButtonText = value;
                OnPropertyChanged(nameof(ButtonText));
            }
        }

        public ICommand ButtonClickCommand { get; private set; }

        private void ExecuteButtonClickCommand()
        {
            Count++;
            if (Count == 1)
                ButtonText = $"Clicked {Count} time"; // counterBtn.Text = WERT
            else
                ButtonText = $"Clicked {Count} times";
        }


    }
}
