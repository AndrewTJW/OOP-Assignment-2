using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2
{
    internal class UserAccount : People
    {
        private double user_account_balance { get; set; }
        private TransactionIncome user_income { get; set; }
        private TransactionExpense user_expense { get; set; }

        private List<TransactionIncome> incomes = new List<TransactionIncome>();
        private List<TransactionExpense> expenses = new List<TransactionExpense>();

        public UserAccount() { }

        public UserAccount(double a_user_account_balance, string a_name ) : base(a_name)
        {
            user_account_balance = a_user_account_balance;
        }
        public UserAccount(string a_name) : base(a_name) { }

        public void addIncome(TransactionIncome a_income)
        {
            incomes.Add(a_income);
            Console.WriteLine("Income transacion of RM{0} made on {1} has been added!", a_income.getUserIncome(), a_income.getDateOfTransaction());
        }

        public void removeIncome(TransactionIncome a_income)
        {
            incomes.Remove(a_income);
            Console.WriteLine("Income transacion of RM{0} made on {1} has been removed!", a_income.getUserIncome(), a_income.getDateOfTransaction());
        }

        public TransactionIncome findIdOfTransactionIncome(int index_of_transaction)
        {
            if (index_of_transaction <= 0)
            {
                Console.WriteLine("Please enter a valid option!");
                return null;
            }
            for (int i = 0; i < incomes.Count(); i++)
            {
                if (index_of_transaction - 1 == i)
                {
                    return incomes[i];
                }
            }
            Console.WriteLine("Transaction not found");
            return null;
        }

        public void addExpense(TransactionExpense a_expense)
        {
            expenses.Add(a_expense);
            Console.WriteLine("Expense transacion of RM{0} made on {1} has been added!", a_expense.getUserExpense(), a_expense.getDateOfTransaction());
        }

        public void removeExpense(TransactionExpense a_expense)
        {
            expenses.Remove(a_expense);
            Console.WriteLine("Expense transacion of RM{0} made on {1} has been removed!", a_expense.getUserExpense(), a_expense.getDateOfTransaction());
        }

        public TransactionExpense findIdOfTransactionExpense(int index_of_transaction)
        {
            if (index_of_transaction <= 0)
            {
                Console.WriteLine("Please enter a valid option!");
                return null;
            }
            for (int i = 0; i < expenses.Count(); i++)
            {
                if (index_of_transaction - 1 == i)
                {
                    return expenses[i];
                }
            }
            Console.WriteLine("Transaction not found");
            return null;
        }
        public void AddAccountBalance(double income)
        {
            user_account_balance = user_account_balance + income;
        }
        public void MinusAccountBalance(double expense)
        {
            user_account_balance = user_account_balance - expense;
        }

        public void DisplayAccountBalance()
        {
            Console.WriteLine("Your account balance is: RM {0}", Math.Round(user_account_balance, 2));
        }

        public void ViewTransactionHistory(int counter)
        {
            if (counter == 0)
            {
                Console.WriteLine("No history available");
            }
            else
            {
                Console.WriteLine("\n********************");
                Console.WriteLine("TRANSACTION HISTORY");
                Console.WriteLine("********************\n");
                Console.WriteLine("{0, -5} {1, -10} {2, -25} {3, -5} {4, -10} {5, -25}", "No.", "Income", "Transaction Date", "No.", "Expense", "Transaction Date");
                for (int i = 0; i < counter; i++)
                {
                    string incomeVal;
                    string incomeDate;
                    string income_index;

                    string expenseVal;
                    string expenseDate;
                    string expense_index;
                    if (i < incomes.Count)
                    {
                        incomeVal = Convert.ToString(incomes[i].getUserIncome());
                        incomeDate = Convert.ToString(incomes[i].getDateOfTransaction());
                        income_index = Convert.ToString(i + 1);
                    }
                    else
                    {
                        incomeVal = "";
                        incomeDate = "";
                        income_index = "";
                    }
                    if (i < expenses.Count)
                    {
                        expenseVal = Convert.ToString(expenses[i].getUserExpense());
                        expenseDate = Convert.ToString(expenses[i].getDateOfTransaction());
                        expense_index = Convert.ToString(i + 1);
                    }
                    else
                    {
                        expenseVal = "";
                        expenseDate = "";
                        expense_index = "";
                    }
                    Console.WriteLine("{0, -5} {1, -10} {2, -25} {3, -5} {4, -10} {5, -25}", income_index, incomeVal, incomeDate , expense_index, expenseVal, expenseDate);
                }
            }
        }
    }
}
