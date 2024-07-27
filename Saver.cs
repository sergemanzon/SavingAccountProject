using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAccount
{

    // מחלקה לייצוג חוסך
    public class Saver
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ID { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public Banker Banker { get; set; }
        public List<SavingAccount> SavingAccounts { get; set; }

        public Saver(string firstName, string lastName, string id, string address, string phoneNumber, Banker banker)
        {
            FirstName = firstName;
            LastName = lastName;
            ID = id;
            Address = address;
            PhoneNumber = phoneNumber;
            Banker = banker;
            SavingAccounts = new List<SavingAccount>();
        }
        public override string ToString()
        {
            string accountsInfo = "";
            foreach (var account in SavingAccounts)
            {
                accountsInfo += account.ToString() + "\n";
            }
            return $"Saver: {FirstName} {LastName}, ID: {ID}, Address: {Address}, Phone: {PhoneNumber}, Banker: {Banker.FirstName} {Banker.LastName}, Number of Accounts: {SavingAccounts.Count}, Accounts:\n{accountsInfo}";
        }
    }
}
