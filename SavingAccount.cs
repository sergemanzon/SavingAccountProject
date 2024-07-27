using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SavingAccount
{
public  class SavingAccount
{

        // שדה נתונים סטטי לריבית השנתית
        private static double AnnualInterestRate;
        // שדה פרטי ליתרת החיסכון
        private double SavingBalance;
        public int AccountNumber { get; private set; }
        public double Balance
        {
            get { return SavingBalance; }
            // תכונות פרטיות
            private set { SavingBalance = value; }
        }

        // בנאי סטטי
        static SavingAccount()
        {
            AnnualInterestRate = 0.06; // 6% ריבית שנתית
        }
        public void CalculateMonthlyInterest()
        {
            double monthlyInterest = (SavingBalance * AnnualInterestRate) / 12;
            SavingBalance += monthlyInterest;
           
        }

        // שיטה להחזרת מאזן החשבון הנוכחי
        public double GetSavingsBalance()
        {
            return SavingBalance;
        }


        public static void ModifyInterestRate(double annualInterestRate) {
            AnnualInterestRate= annualInterestRate;
        }


        // בנאי ליצירת חשבון
        public SavingAccount(int accountNumber, double initialBalance)
    {
        AccountNumber = accountNumber;
        Balance = initialBalance;
    }

    // פעולה לחישוב ריבית שנתית
    

    // פעולה להוספת פיקדון לחשבון
    public void Deposit(double amount)
    {
        Balance += amount;
    }

    // פעולה למשיכת כסף מהחשבון
    public bool Withdraw(double amount)
    {
        if (Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        else
        {
            return false; // אי אפשר למשוך יותר מהיתרה הקיימת
        }
    }

        public override string ToString()
        {
            return  "\nAccount Number: " + AccountNumber + ";\n" + "Balance: " + Balance + ";";

        }
    }

}
