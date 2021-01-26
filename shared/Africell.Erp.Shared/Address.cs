using System;
using System.Collections.Generic;
using System.Text;

namespace Africell.Erp.Shared
{
    public class Address
    {
        public string Street { get; protected set; }
        public string Twonship { get;protected set; }
        public string City { get; protected set; }
        public string Region { get; protected set; }

        public Address(string street,string twonship,string city,string region)
        {
            Street = street;
            Twonship = twonship;
            City = city;
            Region=region;
        }
    }
}
