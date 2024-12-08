namespace datedafool.ViewPages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}  
    private void LogInButton_Clicked(object sender, EventArgs e)
    {
        bool isUsernameEmpty = string.IsNullOrEmpty(UsernameEntry.Text);
        bool isPasswordEmpty = string.IsNullOrEmpty(PasswordEntry.Text);

        if (isUsernameEmpty)
        {
            UsernameEntry.Placeholder = "Vul Iets in!";
        }
        else if (isPasswordEmpty)
        {
            PasswordEntry.Placeholder = "Vul Iets in!";
        }
        else
        {
            Navigation.PushAsync(new ViewPages.NavigationBar());
        }


    }
}
