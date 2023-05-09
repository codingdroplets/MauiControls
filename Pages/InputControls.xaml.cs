namespace MauiControls.Pages;

public partial class InputControls : ContentPage
{
	public InputControls()
	{
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        sliderValueLabel.Text = ((int)e.NewValue).ToString();
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        DisplayAlert("Stepper Value", $"Value: {e.NewValue}", "OK");
    }
}