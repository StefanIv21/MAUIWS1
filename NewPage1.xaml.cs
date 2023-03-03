namespace MauiWS1;

public partial class NewPage1 : ContentPage
{
    String s;
    int guess = 44;

    public NewPage1()
    {
        InitializeComponent();
    }

    private void number_entry_TextChanged(object sender, TextChangedEventArgs e)
    {
        s = e.NewTextValue;
    }

    private void guess_number(object sender, EventArgs e)
    {
        int n = 0;
        try
        {
            n = Convert.ToInt32(s);
            Tried.Text = $"You tried {n}";
            if (n > guess)
                Result.Text = "Try lower!";
            else if (n < guess)
                Result.Text = "Try higher!";
            else Result.Text = "Correct!";
        }
        catch (FormatException)
        {
            Tried.Text = "I said number";
            Result.Text = "Invalid format!";
        }
    }
}