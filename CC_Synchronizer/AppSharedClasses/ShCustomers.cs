using System;

namespace AppSharedClasses
{
    public class ShCustomers
    {
        public int? Customer_ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string StreetAdress1 { get; set; }
        public string streetAdress2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Email { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public int? CreditLimit { get; set; }
        public int? BackendID { get; set; }
        public int? FrontEndID { get; set; }
        public DateTime? Lastmodified { get; set; }

        public ShCustomers() { }

        public ShCustomers(int? customer_ID, string firstName, string lastName, string streetAdress1, string streetAdress2, string city, string state, string postalCode, string email, string phoneNumber1, string phoneNumber2, int? creditLimit, int? backendID, int? frontEndID, DateTime? lastmodified)
        {
            Customer_ID = customer_ID;
            FirstName = firstName;
            LastName = lastName;
            StreetAdress1 = streetAdress1;
            this.streetAdress2 = streetAdress2;
            City = city;
            State = state;
            PostalCode = postalCode;
            Email = email;
            PhoneNumber1 = phoneNumber1;
            PhoneNumber2 = phoneNumber2;
            CreditLimit = creditLimit;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }

        public ShCustomers(string firstName, string lastName, string streetAdress1, string streetAdress2, string city, string state, string postalCode, string email, string phoneNumber1, string phoneNumber2, int? creditLimit, int? backendID, int? frontEndID, DateTime? lastmodified)
        {
            FirstName = firstName;
            LastName = lastName;
            StreetAdress1 = streetAdress1;
            this.streetAdress2 = streetAdress2;
            City = city;
            State = state;
            PostalCode = postalCode;
            Email = email;
            PhoneNumber1 = phoneNumber1;
            PhoneNumber2 = phoneNumber2;
            CreditLimit = creditLimit;
            BackendID = backendID;
            FrontEndID = frontEndID;
            Lastmodified = lastmodified;
        }
    }
}
