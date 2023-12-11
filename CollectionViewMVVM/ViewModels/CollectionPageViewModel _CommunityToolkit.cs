using CollectionViewMVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace CollectionViewMVVM.ViewModels
{
    public partial class CollectionPageViewModel_CommunityToolkit : BaseViewModel_CommunityToolkit
    {
        public CollectionPageViewModel_CommunityToolkit()
        {

        }

        [ObservableProperty]
        string language = "de-DE";

        [ObservableProperty]
        bool isLoading = false;

        [ObservableProperty]
        ObservableCollection<Monkey> monkeys = new();


        [RelayCommand]
        private void ButtonClickLoad() // = ButtonClickLoadCommand im View
        {
            LoadMonkeys();
        }

        [RelayCommand]
        private void ButtonClickClear() // = ButtonClickClearCommand im View
        {
            Monkeys.Clear();
        }

        [RelayCommand]
        private void ButtonClickRemove(string pos) // = ButtonClickRemoveCommand im View
        {
            if (Monkeys.Count > 0)
            {
                Monkeys.RemoveAt(Convert.ToInt32(pos));
            }
        }

        private void LoadMonkeys()
        {
            Monkeys.Clear();
            /*
            Monkeys.Add(new Monkey() { Name = "Baboon", Image = "baboon.jpg", Location = "Africa and Asia" });
            Monkeys.Add(new Monkey() { Name = "Capuchin Monkey", Image = "capuchin.jpg", Location = "Central and South America" });
            Monkeys.Add(new Monkey() { Name = "Red-shanked douc", Image = "douc.jpg", Location = "Vietnam" });
            */
            _ = LoadMonkeysFromInternetAsync();
        }

        private async Task LoadMonkeysFromInternetAsync()
        {
            IsLoading = true;
            string srcBaseUrl = "https://www.montemagno.com/monkeys.json";

            try {
                using (var _client = new HttpClient())
                {
                    _client.BaseAddress = new Uri(srcBaseUrl);
                    var result = _client.GetAsync(_client.BaseAddress).Result;


                    if (result != null)
                    {
                        string text = await result.Content.ReadAsStringAsync();
                        var jsonResult = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Monkey>>(text);
                        if (jsonResult != null)
                        {
                            string mainDir = FileSystem.Current.AppDataDirectory + Path.DirectorySeparatorChar;
                            File.WriteAllText($"{mainDir}TempMonkeys.txt", text);
                            foreach (var monkey in jsonResult) { Monkeys.Add(monkey); }
                            File.WriteAllText($"{mainDir}TempMonkeys.json", Newtonsoft.Json.JsonConvert.SerializeObject(Monkeys, Newtonsoft.Json.Formatting.Indented));
                        }
                    }
                }
            } finally {
                IsLoading = false;
            }
        }
    }
}
