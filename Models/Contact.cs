using System;

namespace easycontacts.Models
{
    public class Contact
    {
        public Guid Id { get; set; }

        public string Name {get; set;}

        public string Photo {get; set;}

        public string Annotations {get; set;}

        public string Phone {get; set;}

        public string Skype {get; set;}

        public string ZoomId {get; set;}
    }
}