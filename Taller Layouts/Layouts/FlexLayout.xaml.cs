using Microsoft.Maui.Controls;

namespace Taller_Layouts
{
    public partial class FlexLayout : ContentPage
    {
        public FlexLayout()
        {
            InitializeComponent();
        }

        // Este m�todo maneja el evento cuando se hace clic en una imagen
        private async void OnImageTapped(object sender, EventArgs e)
        {
            var tappedImage = (sender as TapGestureRecognizer).CommandParameter.ToString();

            // Aqu� puedes hacer la l�gica para navegar a AbsoluteLayout
            if (tappedImage == "imagen1")
            {
                await Navigation.PushAsync(new AbsoluteLayout()); // Cambia AbsoluteLayoutPage por el nombre de tu p�gina
            }
            else if (tappedImage == "imagen2")
            {
                await Navigation.PushAsync(new AbsoluteLayout()); // Cambia AbsoluteLayoutPage por el nombre de tu p�gina
            }
        }
    }
}
