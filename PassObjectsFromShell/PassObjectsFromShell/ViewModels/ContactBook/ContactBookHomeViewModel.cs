using Newtonsoft.Json;
using PassObjectsFromShell.Models;
using PassObjectsFromShell.ViewModels.Base;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace PassObjectsFromShell.ViewModels.ContactBook
{
    public class ContactBookHomeViewModel : BaseViewModel
    {
        private Contact _sendContact = new Contact
        {
            Name = "Peter",
            LastName = "Parker",
            Phone = "+1-541-754-3010"
        };

        public Contact SendContact
        {
            get => _sendContact;
            set
            {
                _sendContact = value;
                RaiseOnPropertyChanged();
            }
        }

        public ICommand PassObjectCommand => new Command(async () => await NavigateToContactBookDetail());

        private async Task NavigateToContactBookDetail()
        {
            var jsonContact = JsonConvert.SerializeObject(SendContact);
            ShellNavigationState state = Shell.Current.CurrentState;

            await Shell.Current.GoToAsync($"{state.Location}/contactBookDetail?contact={jsonContact}");
        }
    }
}