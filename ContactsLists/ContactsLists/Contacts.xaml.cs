using ContactsLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace ContactsLists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Contacts : ContentPage
	{
        IEnumerable<Contact> GetContacts(string searchText= null)
        {
            var Contacts =  new List<Contact>
            {
                new Contact {Name ="Mosh kjggg", ImageUrl = "http://lorempixel.com/100/100/people/1", Status = "lets Talk!" },
                new Contact {Name ="Milly", ImageUrl = "http://lorempixel.com/100/100/people/5", Status = "lets Talk!" },
                new Contact {Name ="John", ImageUrl = "http://lorempixel.com/100/100/people/3", Status = "lets Talk!" },
                new Contact {Name ="Shon", ImageUrl = "http://lorempixel.com/100/100/people/7", Status = "lets Talk!" }

            };

            if (String.IsNullOrWhiteSpace(searchText))
                return Contacts;
            return Contacts.Where(c => c.Name.ToUpper().Contains(searchText.ToUpper()));

        }

        public Contacts ()
		{
			InitializeComponent ();

            listView.ItemsSource = GetContacts();
        }

        private async void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var contact = e.SelectedItem as Contact;
            //DisplayAlert("Selected", contact.Name, "OK");
            await Navigation.PushModalAsync(new ContactDetailPage(contact));
            listView.SelectedItem = null;
        }

        private void listView_Refreshing(object sender, EventArgs e)
        {
            listView.ItemsSource = GetContacts();
            listView.EndRefresh();
            //or listView.IsRefreshing = "false"
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = GetContacts(e.NewTextValue);
        }

       
    }
}