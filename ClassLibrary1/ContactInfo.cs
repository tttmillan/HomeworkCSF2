using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ContactInfo
    {
        //Feilds

        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zip;
        private string _phone;
        private string _email;


        //Properties

        public string StreetAddress
        {
            get { return _streetAddress; }
            set { _streetAddress = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string State
        {
            get { return _state; }
            set { _state = value; }
        }

        public string Zip
        {
            get { return _zip; }
            set { _zip = value; }
        }

        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }


        //ctor
        //default ctor

        public ContactInfo() { }

        //fullyfunctional ctor

        public ContactInfo(string streetAddress, string city, string state, string zip, string phone, string email)
        {
            StreetAddress = streetAddress;
            City = city;
            State = state;
            Zip = zip;
            Phone = phone;
            Email = email;
        }


        //method

        public override string ToString()
        {
            return string.Format("Address is \n" +
                "{0}\n" +
                "{1}, {2} - {3}\n" +
                "Phone Number: {4}\n" +
                "Email: {5}",
                StreetAddress,
                City,
                State,
                Zip,
                Phone,
                Email);
        }

    }//end class

}//end namespace
