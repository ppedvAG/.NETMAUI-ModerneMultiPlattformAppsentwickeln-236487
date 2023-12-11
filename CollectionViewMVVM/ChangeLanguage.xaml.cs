using Microsoft.Maui.Platform;
using System.Globalization;

namespace CollectionViewMVVM;

public partial class ChangeLanguage : ContentPage
{
    int oldPickerIdx;
    string actLang;
	public ChangeLanguage()
	{
		InitializeComponent();
        actLang = Thread.CurrentThread.CurrentCulture.Name;
        oldPickerIdx = pickerLanguage.SelectedIndex;
        int idx = pickerLanguage.Items.IndexOf(actLang);
        if (idx != -1) { pickerLanguage.SelectedIndex = idx; }
        oldPickerIdx = pickerLanguage.SelectedIndex;
    }

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (oldPickerIdx != -1)
        {
            string selItem = pickerLanguage.SelectedItem as string;
            ButtonOkay.IsEnabled = selItem != actLang;
        }
    }

    private void ChangeLang()
    {
        string lang = pickerLanguage.SelectedItem as string;
        if (lang != null)
        {
            var culture = new CultureInfo(lang);
            Thread.CurrentThread.CurrentCulture = culture;
            Thread.CurrentThread.CurrentUICulture = culture;
            CollectionViewMVVM.Resources.Strings.CollectionPage.Culture = culture;
        }
        Application.Current.MainPage = new AppShell();
    }

    private void ButtonOkay_Clicked(object sender, EventArgs e)
    {
        string selItem = pickerLanguage.SelectedItem as string;
        Navigation.PopAsync();
        if (selItem != actLang) { ChangeLang(); }
    }

    private void ButtonCancel_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }
}