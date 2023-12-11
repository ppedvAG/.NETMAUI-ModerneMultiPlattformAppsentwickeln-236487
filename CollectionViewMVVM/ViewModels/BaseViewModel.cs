using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit;

namespace CollectionViewMVVM.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        // Binding im View-Codebehind nicht vergessen
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
