using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sunny.UI.Demo.Model
{
    public class User
    {
        public User()
        {
        }

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Status { get; set; }
        public Transaction transaction { get; set; }

        public User(int userId, string userName, string emailAddress, string password, string role, string gender, string phoneNumber, string address, string status, Transaction transaction)
        {
            UserId = userId;
            UserName = userName;
            EmailAddress = emailAddress;
            Password = password;
            Role = role;
            Gender = gender;
            PhoneNumber = phoneNumber;
            Address = address;
            Status = status;
            this.transaction = transaction;
        }
    }
}
