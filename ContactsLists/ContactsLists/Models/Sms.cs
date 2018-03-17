using System;
using System.Collections.Generic;
using System.Text;

namespace ContactsLists.Models
{
    public class Sms
    {
        public string FromUser { get; set; }
        public string ToUser { get; set; }
        public string Message { get; set; }
        public string ImageUrl { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Status { get; set; }

        private bool _isIncoming;
        public bool IsIncoming
        {
            get { return _isIncoming; }
            set
            {
                _isIncoming = value;  
            }
        }

        public List<Sms> GetMessages()
        {
            List<Sms> Messages = new List<Sms>()
            {
                new Sms{ FromUser ="Mosh", ToUser= "Dan", Message="Hi", TimeStamp= DateTime.Now, Status="Received", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Sms{ FromUser ="Dan", ToUser= "Mosh", Message="Hi", TimeStamp= DateTime.Now, Status="Sent", ImageUrl = "http://lorempixel.com/100/100/people/5"},
                new Sms{ FromUser ="Mosh", ToUser= "Dan", Message="Hi", TimeStamp= DateTime.Now, Status="Received", ImageUrl = "http://lorempixel.com/100/100/people/1"},
                new Sms{ FromUser ="Dan", ToUser= "Mosh", Message="Hi", TimeStamp= DateTime.Now, Status="Sent", ImageUrl = "http://lorempixel.com/100/100/people/5"},
                new Sms{ FromUser ="Mosh", ToUser= "Dan", Message="Hi", TimeStamp= DateTime.Now, Status="Received", ImageUrl = "http://lorempixel.com/100/100/people/1"}
            };
            return Messages;
        }
    }
}
