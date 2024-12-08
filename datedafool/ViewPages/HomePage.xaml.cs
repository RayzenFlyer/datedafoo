namespace datedafool.ViewPages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

	private void FindMatchButton_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ViewPages.QuizzitPage());


	
	}
	private void SkippitButton_Clicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new ViewPages.QuizzitPage());



	}
    private void ProfileButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ViewPages.ProfilePage());



    }
}