using PassObjectsFromShell.ViewModels.ContactBook;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PassObjectsFromShell.Views.ContactBook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactBookHomeViewPage : ContentPage
    {
        public ContactBookHomeViewPage()
        {
            InitializeComponent();
            BindingContext = new ContactBookHomeViewModel();
        }
    }
}