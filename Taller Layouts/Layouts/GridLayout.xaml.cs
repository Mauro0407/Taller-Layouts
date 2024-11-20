namespace Taller_Layouts;

public partial class GridLayout : ContentPage
{
    public GridLayout()
    {
        InitializeComponent();
    }

    private async void OnNavigateToStackPage(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new StackLayout());
    }
}
