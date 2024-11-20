using Microsoft.Maui.Controls;

namespace Taller_Layouts
{
    public partial class FlexLayout : ContentPage
    {
        public FlexLayout()
        {
            InitializeComponent();
        }

        // Este método maneja el evento cuando se hace clic en una imagen
        private async void OnImageTapped(object sender, EventArgs e)
        {
            var tappedImage = (sender as TapGestureRecognizer).CommandParameter.ToString();

            // Aquí puedes hacer la lógica para navegar a AbsoluteLayout
            if (tappedImage == "imagen1")
            {
                await Navigation.PushAsync(new AbsoluteLayout()); // Cambia AbsoluteLayoutPage por el nombre de tu página
            }
            else if (tappedImage == "imagen2")
            {
                await Navigation.PushAsync(new AbsoluteLayout()); // Cambia AbsoluteLayoutPage por el nombre de tu página
            }
        }
    }
}
