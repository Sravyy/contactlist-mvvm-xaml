using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsLists.Models
{
    class ContactGroup 
    {
        public string Title { get; set; } 
        public string ShortTitle { get; set; }

        public ContactGroup(string title, string shorttitle)
        {
            Title = title;
            ShortTitle = shorttitle;
        }

        public static IList<ContactGroup> All { get; set; }
    }
}
