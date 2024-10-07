using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2
{
    internal class TransactionIncome
    {
        private double user_income { get; set; }
        private DateTime date_of_transaction { get; set; }

        public TransactionIncome(double a_user_income, DateTime a_date_of_transaction)
        {
            user_income = a_user_income;
            date_of_transaction = a_date_of_transaction;
        }

        public double getUserIncome()
        {
            return user_income;
        }

        public DateTime getDateOfTransaction()
        {
            return date_of_transaction;
        }
    }
}
