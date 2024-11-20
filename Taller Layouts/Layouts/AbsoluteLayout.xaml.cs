using Microsoft.Maui.Controls;

namespace Taller_Layouts
{
    public partial class AbsoluteLayout : ContentPage
    {
        public AbsoluteLayout()
        {
            InitializeComponent();

            var labels = new List<string>();

            for (int i = 0; i < 30; i++)
            {
                labels.Add("Soy Mauricio Mora");
                labels.Add("Soy Mateo Sotomayor");
            }

            LabelListView.ItemsSource = labels;
        }

        private async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new GridLayout());
        }
    }
}
