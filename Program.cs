namespace OOP_Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a_name;
            char user_option;
            double a_user_income;
            double a_user_expense;
            int counter = default;
            int a_income_index;
            int a_expense_index;

            Welcome WelcomeMessage = new Welcome();
            Option OptionMessage = new Option();


            WelcomeMessage.DisplayWelcomeMessage();
            Console.WriteLine("Please enter your name: ");
            a_name = Console.ReadLine();
            UserAccount userAccount = new UserAccount(0,a_name);
            
            while (true)
            {
                OptionMessage.DisplayOptionMenu();
                Console.WriteLine("\nHello, {0} please choose your operation: ", userAccount.getPersonName());
                user_option = Convert.ToChar(Console.ReadLine());
                Option UserOption = new Option(user_option);

                switch (UserOption.getUserOption())
                {
                    case '1':
                        Console.WriteLine("Please enter your income: ");
                        a_user_income = Convert.ToDouble(Console.ReadLine());
                        TransactionIncome userIncome = new TransactionIncome(a_user_income, DateTime.Now);
                        userAccount.addIncome(userIncome);
                        userAccount.AddAccountBalance(a_user_income);
                        counter += 1;
                        break;
                    case '2':
                        Console.WriteLine("Please enter your expense: ");
                        a_user_expense = Convert.ToDouble(Console.ReadLine());
                        TransactionExpense userExpense = new TransactionExpense(a_user_expense, DateTime.Now);
                        userAccount.addExpense(userExpense);
                        userAccount.MinusAccountBalance(a_user_expense);
                        counter += 1;
                        break;
                    case '3':
                        userAccount.DisplayAccountBalance();
                        break;
                    case '4':
                        userAccount.ViewTransactionHistory(counter);
                        break;
                    case '5':
                        double tmp_income;
                        Console.WriteLine("Please enter the index of the INCOME transaction you want to remove: ");
                        a_income_index = Convert.ToInt16(Console.ReadLine());
                        TransactionIncome IncomeToBeRemoved = userAccount.findIdOfTransactionIncome(a_income_index);
                        tmp_income = IncomeToBeRemoved.getUserIncome();
                        userAccount.removeIncome(IncomeToBeRemoved);
                        userAccount.MinusAccountBalance(tmp_income);
                        break;
                    case '6':
                        double tmp_expense;
                        Console.WriteLine("Please enter the index of the EXPENSE transaction you want to remove: ");
                        a_expense_index = Convert.ToInt16(Console.ReadLine());
                        TransactionExpense ExpenseToBeRemoved = userAccount.findIdOfTransactionExpense(a_expense_index);
                        tmp_expense = ExpenseToBeRemoved.getUserExpense();
                        userAccount.removeExpense(ExpenseToBeRemoved);
                        userAccount.AddAccountBalance(tmp_expense);
                        break;
                    case '7':
                        Console.WriteLine("\nQuitting Application...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        break;
                }

            }
        }
    }
}
