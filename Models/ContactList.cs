using System;
using System.Collections.Generic;

namespace easycontacts.Models
{
    public class ContactList
    {
        public List<Contact> Contacts {get; set;}

        public Guid Id { get; set; }

        public ContactList()
        {
            Contacts = new List<Contact>();
        }
    }
}