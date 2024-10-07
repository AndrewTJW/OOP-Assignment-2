using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2
{
    internal class TransactionExpense
    {
        private double user_expense { get; set; }
        private DateTime date_of_transaction { get; set; }

        public TransactionExpense (double a_user_expense, DateTime a_date_of_transaction)
        {
            user_expense = a_user_expense;
            date_of_transaction = a_date_of_transaction;
        }

        public double getUserExpense()
        {
            return user_expense;
        }

        public DateTime getDateOfTransaction() 
        { 
            return date_of_transaction;
        }
    }
}
