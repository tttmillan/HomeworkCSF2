using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Customer
    {
        //Field
        //Prop

        public string CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo ContactInformation { get; set; }


        //Ctor


        public Customer(string customerID, string firstName, string lastName, ContactInfo contactInformation)
        {
            CustomerID = customerID;
            FirstName = firstName;
            LastName = lastName;
            ContactInformation = contactInformation;
        }



        //Method


        public override string ToString()
        {
            return string.Format($"{CustomerID}\t\t{FirstName} {LastName}\n" +
                //$"Phone: {ContactInformation.Phone}\n" +
                //$"Email: {ContactInformation.Email}" +
                $"{ContactInformation}"); 
            return CustomerID;
        }


                                         
    }//end class

}//end namespace
