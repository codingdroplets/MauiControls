namespace MauiControls.Pages;

public partial class ActionControls : ContentPage
{
	public ActionControls()
	{
		InitializeComponent();
	}

    private void demoButton_Clicked(object sender, EventArgs e)
    {
		DisplayAlert("Coding Droplets", "You've clicked the demo button", "OK");
    }

    private void demoImageButton_Clicked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You have clicked the Download Button", "OK");
    }

    private void demoSearchBar_SearchButtonPressed(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", $"You've searched for {demoSearchBar.Text}", "OK");
    }

    private void facebookSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You've clicked Facebook button", "OK");
    }

    private void instagramSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You've clicked Instagram button", "OK");
    }

    private void twitterSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You've clicked Twitter button", "OK");
    }

    private void linkedInSwipeItem_Invoked(object sender, EventArgs e)
    {
        DisplayAlert("Coding Droplets", "You've clicked LinkedIn button", "OK");
    }
}