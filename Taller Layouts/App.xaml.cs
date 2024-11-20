namespace Taller_Layouts
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new GridLayout());
        }
    }
}
