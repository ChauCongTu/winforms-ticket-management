using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }
        public string IdNumber { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }


        public Customer(int customerId, string customerName, string phoneNumber, string emailAddress, string idNumber, string gender, DateTime? dateOfBirth)
        {
            CustomerId = customerId;
            CustomerName = customerName;
            PhoneNumber = phoneNumber;
            EmailAddress = emailAddress;
            IdNumber = idNumber;
            Gender = gender;
            DateOfBirth = dateOfBirth;
        }

        public Customer()
        {
        }
    }
}
