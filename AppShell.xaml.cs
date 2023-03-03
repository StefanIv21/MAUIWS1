namespace MauiWS1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("NewPage", typeof(NewPage1));
    }
}
