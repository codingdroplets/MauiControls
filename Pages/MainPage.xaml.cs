namespace MauiControls.Pages;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    private void commonControlsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new CommonControls());
    }

    private void actionControlsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new ActionControls());
    }

    private void inputControlsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new InputControls());
    }

    private void indicatorControlsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new IndicatorControls());
    }

    private void drawingControlsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new DrawingControls());
    }
}