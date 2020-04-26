using Newtonsoft.Json;
using PassObjectsFromShell.Models;
using PassObjectsFromShell.ViewModels.Base;
using System;
using Xamarin.Forms;

namespace PassObjectsFromShell.ViewModels.ContactBook
{
    [QueryProperty("Contact", "contact")]
    public class ContactBookDetailViewModel : BaseViewModel
    {
        private Contact _contactReceived = new Contact();

        public string Contact
        {
            set => ContactReceived = JsonConvert.DeserializeObject<Contact>(Uri.UnescapeDataString(value));
        }

        public Contact ContactReceived
        {
            get => _contactReceived;
            set
            {
                _contactReceived = value;
                RaiseOnPropertyChanged();
            }
        }
    }
}