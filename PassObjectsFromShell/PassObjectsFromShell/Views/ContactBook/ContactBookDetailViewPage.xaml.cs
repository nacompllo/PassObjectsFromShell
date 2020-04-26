using PassObjectsFromShell.ViewModels.ContactBook;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PassObjectsFromShell.Views.ContactBook
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactBookDetailViewPage : ContentPage
    {
        public ContactBookDetailViewPage()
        {
            InitializeComponent();
            BindingContext = new ContactBookDetailViewModel();
        }
    }
}