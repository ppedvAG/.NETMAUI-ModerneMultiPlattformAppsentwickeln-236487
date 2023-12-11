namespace FlyoutSample;

public partial class DateienPage : ContentPage
{
	public DateienPage()
	{
		InitializeComponent();
	}

	private async void openFile_Clicked(object sender, EventArgs e)
	{
		List<string> fileTypes = new List<string>();
		fileTypes.Add(".txt");
		var pickoptions = new PickOptions();
		pickoptions.FileTypes = FilePickerFileType.Images;
		var fileResult = await FilePicker.PickAsync();
		if (fileResult != null)
		{
			edFile.Text = File.ReadAllText(fileResult.FullPath);
			//imgLoad.Source = fileResult.FullPath;
		}
    }
}