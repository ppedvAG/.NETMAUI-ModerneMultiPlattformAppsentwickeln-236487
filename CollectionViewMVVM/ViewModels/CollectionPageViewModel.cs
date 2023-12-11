using CollectionViewMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CollectionViewMVVM.ViewModels
{
    public class CollectionPageViewModel: BaseViewModel
    {
        public CollectionPageViewModel() {
            ButtonClickLoadCommand = new Command(ExecuteButtonClickLoadCommand);
            ButtonClickClearCommand = new Command(ExecuteButtonClickClearCommand);

        }

        private ObservableCollection<Monkey> _monkeys = new ();
        public ObservableCollection<Monkey> Monkeys { get { return _monkeys; } }

        public ICommand ButtonClickLoadCommand { get; private set; }
        public ICommand ButtonClickClearCommand { get; private set; }

        private void ExecuteButtonClickLoadCommand()
        {
            LoadMonkeys();
        }
        private void ExecuteButtonClickClearCommand()
        {
            Monkeys.Clear();
        }

        private void LoadMonkeys()
        {
            _monkeys.Clear();
            _monkeys.Add(new Monkey() { Name = "Baboon", Image = "baboon.jpg", Location = "Africa and Asia" });
            _monkeys.Add(new Monkey() { Name = "Capuchin Monkey", Image = "capuchin.jpg", Location = "Central and South America" });
            _monkeys.Add(new Monkey() { Name = "Red-shanked douc", Image = "douc.jpg", Location = "Vietnam" });
        }
    }
}
