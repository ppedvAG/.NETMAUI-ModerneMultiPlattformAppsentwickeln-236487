namespace MauiCustomControl.Controls;

public partial class NumericCart : ContentView
{
    private int _value=0, _min=0, _max=100;

    /** MinValue Property **/

    private static BindableProperty MinValueProperty = BindableProperty.Create(
                                                     propertyName: "Min",
                                                     returnType: typeof(int),
                                                     declaringType: typeof(NumericCart),
                                                     defaultValue: 0,
                                                     defaultBindingMode: BindingMode.TwoWay,
                                                     propertyChanged: MinValuePropertyChanged);
    public int Min
    {
        get { return (int)base.GetValue(MinValueProperty); }
        set { base.SetValue(MinValueProperty, value); _min = value; }
    }

    private static void MinValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        //var control = (CustomControl)bindable;
        //?? = newValue.ToString();
    }

    /** MaxValue Property **/

    private static BindableProperty MaxValueProperty = BindableProperty.Create(
                                                     propertyName: "Max",
                                                     returnType: typeof(int),
                                                     declaringType: typeof(NumericCart),
                                                     defaultValue: 100,
                                                     defaultBindingMode: BindingMode.TwoWay,
                                                     propertyChanged: MaxValuePropertyChanged);
    public int Max
    {
        get { return (int)base.GetValue(MinValueProperty); }
        set { base.SetValue(MinValueProperty, value); _max = value; }
    }

    private static void MaxValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        //var control = (CustomControl)bindable;
        //?? = newValue.ToString();
    }

    /** Value Property **/

    private static BindableProperty ValueProperty = BindableProperty.Create(
                                                     propertyName: "Value",
                                                     returnType: typeof(int),
                                                     declaringType: typeof(NumericCart),
                                                     defaultValue: 0,
                                                     defaultBindingMode: BindingMode.TwoWay,
                                                     propertyChanged: ValuePropertyChanged);
    public int Value
    {
        get { return (int)base.GetValue(MinValueProperty); }
        set { 
            base.SetValue(MinValueProperty, value); 
            _value = value;
            refreshControls();
        }
    }

    private static void ValuePropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        //var control = (CustomControl)bindable;
        //?? = newValue.ToString();
    }


    public NumericCart()
	{
		InitializeComponent();
	}

    private void imgBtnMinus_Clicked(object sender, EventArgs e)
    {
        _value--;
        refreshControls();
    }

    private void imgBtnPlus_Clicked(object sender, EventArgs e)
    {
        _value++;
        refreshControls();
    }

    private void imgBtnCart_Clicked(object sender, EventArgs e)
    {

    }

    private void txValue_TextChanged(object sender, TextChangedEventArgs e)
    {
        if (txValue != null)
        {
            _value = Convert.ToInt16(txValue.Text);
            refreshControls();
        }
    }

    private void refreshControls()
    {
        if(_value > _max) { _value = _max; }
        if(_value < _min) { _value = _min; }
        imgBtnCart.IsEnabled = _value != 0;
        imgBtnMinus.IsEnabled = _value > _min;
        imgBtnPlus.IsEnabled = _value < _max;
        txValue.Text = _value.ToString();
    }
}