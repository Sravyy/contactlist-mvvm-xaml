using ContactsLists.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ContactsLists
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MessagePage : ContentPage
	{
		public MessagePage (Sms sms)
		{
			InitializeComponent ();
            BindingContext = sms;
            listMessages.ItemsSource = new Sms().GetMessages();
        }
	}
}