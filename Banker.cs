using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAccount
{


    // מחלקה לייצוג בנקאי
    public class Banker
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public List<Saver> Customers { get; set; }

        public Banker(string firstName, string lastName, string id, string address, string phoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            Address = address;
            PhoneNumber = phoneNumber;
            Customers = new List<Saver>();
        }
        public override string ToString()
        {
            return $"Banker: {FirstName} {LastName}, ID: {ID}, Address: {Address}, Phone: {PhoneNumber}, Number of Customers: {Customers.Count}";
        }
    }
}