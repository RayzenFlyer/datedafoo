namespace datedafool.ViewPages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private void FindMatchButton_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ViewPages.SettingsPage());



	}
}