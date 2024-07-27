using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            SavingAccount saver1 = new SavingAccount(123456,5000);
          
            SavingAccount saver2 = new SavingAccount(654321, 6000);
            


            // הדפסת מצב היתרות ההתחלתי של כל אחד מהחוסכים
            Console.WriteLine("Initial balance of saver1: " + saver1.GetSavingsBalance() + " ₪");
            Console.WriteLine("Initial balance of saver2: " + saver2.GetSavingsBalance() + " ₪");
            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();
            Console.WriteLine("Initial balance of saver1: " + saver1.GetSavingsBalance() + " ₪");
            Console.WriteLine("Initial balance of saver2: " + saver2.GetSavingsBalance() + " ₪");


            // העלאת הריבית השנתית ל- 10%
            SavingAccount.ModifyInterestRate(0.10); // 10% ריבית שנתית

          

            // חישוב הריבית החודשית והדפסת המאזן החדש
            saver1.CalculateMonthlyInterest();
            saver2.CalculateMonthlyInterest();

            Console.WriteLine("New balance of saver1 after monthly interest at 10%: " + saver1.GetSavingsBalance() + " ₪");
            Console.WriteLine("New balance of saver2 after monthly interest at 10%: " + saver2.GetSavingsBalance() + " ₪");
        }
    }
}

