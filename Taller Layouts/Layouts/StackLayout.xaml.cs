namespace Taller_Layouts;

public partial class StackLayout : ContentPage
{
	public StackLayout()
	{
		InitializeComponent();
	}
    private async void OnNavigateToFlexLayout(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new FlexLayout());
    }

}