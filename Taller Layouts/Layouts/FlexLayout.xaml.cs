using Microsoft.Maui.Controls;

namespace Taller_Layouts
{
    public partial class FlexLayout : ContentPage
    {
        public FlexLayout()
        {
            InitializeComponent();
        }

        private async void OnImageTapped1(object sender, EventArgs e)
        {
            // Navega a AbsoluteLayout sin duplicados
            if (Navigation.NavigationStack.LastOrDefault()?.GetType() != typeof(AbsoluteLayout))
            {
                await Navigation.PushAsync(new AbsoluteLayout());
            }
        }

        private async void OnImageTapped2(object sender, EventArgs e)
        {
            // Asegura que no haya duplicación
            if (Navigation.NavigationStack.LastOrDefault()?.GetType() != typeof(AbsoluteLayout))
            {
                await Navigation.PushAsync(new AbsoluteLayout());
            }
        }

        private async void OnLabelTapped1(object sender, EventArgs e)
        {
            if (Navigation.NavigationStack.LastOrDefault()?.GetType() != typeof(AbsoluteLayout))
            {
                await Navigation.PushAsync(new AbsoluteLayout());
            }
        }

        private async void OnLabelTapped2(object sender, EventArgs e)
        {
            if (Navigation.NavigationStack.LastOrDefault()?.GetType() != typeof(AbsoluteLayout))
            {
                await Navigation.PushAsync(new AbsoluteLayout());
            }
        }
    }
}
