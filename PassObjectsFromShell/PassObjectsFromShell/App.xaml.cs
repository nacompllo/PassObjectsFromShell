using PassObjectsFromShell.Views;
using Xamarin.Forms;

namespace PassObjectsFromShell
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainShell();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
