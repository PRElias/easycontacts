using System;

namespace easycontacts.Models
{
    public class Contact
    {
        public int Id { get; set; }

        public string Name {get; set;}

        public string Photo {get; set;}

        public string Annotations {get; set;}

        public string Phone {get; set;}

        public string Email {get; set;}

        public string Facebook {get; set;}

        public string Youtube {get; set;}

        public string Skype {get; set;}

        public string ZoomId {get; set;}

        public DateTime InclusionDate {get; set;}

        public bool IsDeleted {get; set;}
    }
}