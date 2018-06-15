﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLibrary.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Url { get; set; }
        public int CreditLimit { get; set; }
        public string Tags { get; set; }

        public Customer()
        {

        }

        public Customer(int customerId, string firstName, string lastName, string address, string city, string state, int zip, string email, string phoneNumber, string url, int creditLimit, string tags)
        {
            CustomerId = customerId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            Email = email;
            PhoneNumber = phoneNumber;
            Url = url;
            CreditLimit = creditLimit;
            Tags = tags;
        }
    }
}
