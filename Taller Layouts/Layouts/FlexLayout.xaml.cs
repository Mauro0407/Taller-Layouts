namespace Taller_Layouts;

public partial class FlexLayout : ContentPage
{
    public FlexLayout()
    {
        InitializeComponent();

        TapGestureRecognizer tapGesture1 = new TapGestureRecognizer();
        tapGesture1.Tapped += OnImageTapped1;
        imagen1.GestureRecognizers.Add(tapGesture1);

        TapGestureRecognizer tapGesture2 = new TapGestureRecognizer();
        tapGesture2.Tapped += OnImageTapped2;
        imagen2.GestureRecognizers.Add(tapGesture2);
    }

    private async void OnImageTapped1(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }

    private async void OnImageTapped2(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AbsoluteLayout());
    }
}