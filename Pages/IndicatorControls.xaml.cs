namespace MauiControls.Pages;

public partial class IndicatorControls : ContentPage
{
	public IndicatorControls()
	{
		InitializeComponent();
	}

    private void activityIndicatorButton_Clicked(object sender, EventArgs e)
    {
        activityIndicator.IsRunning = !activityIndicator.IsRunning;
    }
}