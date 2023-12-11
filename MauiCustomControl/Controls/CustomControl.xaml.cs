namespace MauiCustomControl.Controls;

public partial class CustomControl : ContentView
{
	public CustomControl()
	{
		InitializeComponent();
	}

    /** TitleText Property **/

    private static BindableProperty TitleTextProperty = BindableProperty.Create(
                                                     propertyName: "TitleText",
                                                     returnType: typeof(string),
                                                     declaringType: typeof(CustomControl),
                                                     defaultValue: "",
                                                     defaultBindingMode: BindingMode.TwoWay,
                                                     propertyChanged: TitleTextPropertyChanged);
    public string TitleText {
        get { return base.GetValue(TitleTextProperty).ToString(); }
        set { base.SetValue(TitleTextProperty, value); }
    }
    private static void TitleTextPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (CustomControl)bindable;
        control.laTitle.Text = newValue.ToString();
    }

    /** Image Property **/
    public static BindableProperty ImageProperty = BindableProperty.Create(
                                                    propertyName: "Image",
                                                    returnType: typeof(string),
                                                    declaringType: typeof(CustomControl),
                                                    defaultValue: "",
                                                    defaultBindingMode: BindingMode.TwoWay,
                                                    propertyChanged: ImageSourcePropertyChanged);

    public string Image
    {
        get { return base.GetValue(ImageProperty).ToString(); }
        set { base.SetValue(ImageProperty, value); }
    }

    private static void ImageSourcePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (CustomControl)bindable;
        control.imgImage.Source = ImageSource.FromFile(newValue.ToString());
    }

}