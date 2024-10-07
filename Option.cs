using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_2
{
    internal class Option
    {
        private char user_option { get; set; }

        //empty constructor
        public Option() { }
        //initialization
        public Option (char a_user_option)
        {
            user_option = a_user_option;
        }

        public char getUserOption()
        {
            return user_option;
        }

        public void DisplayOptionMenu ()
        {
            Console.WriteLine("\n1. Add Income");
            Console.WriteLine("2. Add Expenses");
            Console.WriteLine("3. View Account Balance");
            Console.WriteLine("4. View Transaction History");
            Console.WriteLine("5. Remove Income");
            Console.WriteLine("6. Remove Expense");
            Console.WriteLine("7. Quit\n");
        }
    }
}
