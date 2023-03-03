namespace MauiWS1;

public partial class MainPage : ContentPage
{
	String s;

	public MainPage()
	{
		InitializeComponent();
	}
    private void TextChanged(object sender, TextChangedEventArgs e)
    {
        s = e.NewTextValue;
    }

	private void convertmoney(object sender, EventArgs e)
	{
		double sum = 0;
      
        try
		{
			sum = Convert.ToDouble(s) * 4.95;
            double sum2= Convert.ToDouble(sum.ToString("0.00"));
            display.Text = $"{sum2} Ron";
   

        }
		catch (FormatException)
		{
			display.Text = "Invalid Format";
		}
	}

        private void clicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync("NewPage");
        }
    
}

