namespace Banking;

class User : Bank
{
    public string? firstName { get; set; }
    public string? lastName { get; set; }
    public string? userName { get; set; }
    private string? userPassword { get; set; }

    public void Startup()
    {
        Console.WriteLine("1. Signup \n 2. Signin \n 3. Exit");
        var userInput = Console.ReadLine();

        int.TryParse(userInput, out int userOption);
        if (userOption == 1)
        {
            Registration();
        }
        if (userOption == 2)
        {
            Login();
        }
    }

    private void Registration()
    {
        Console.WriteLine("Enter Your First Name");
        var userFirstName = Console.ReadLine();
        Console.WriteLine("Enter Your Last Name");
        var userLastName = Console.ReadLine();
        Console.WriteLine("Enter Your User Name");
        var userNameInput = Console.ReadLine();
        Console.WriteLine("Enter Your Password");
        var userPasswordInput = Console.ReadLine();

        firstName = userFirstName.ToLower();
        lastName = userLastName.ToLower();
        userPassword = userPasswordInput;
        userName = userNameInput.ToLower();

        Console.WriteLine("Registration Successfull!!!!!!!!!!");

        Login();


    }

    private void Login()
    {
        Console.WriteLine("Login To Your Account");
        Console.WriteLine("Enter Your Username");
        var userNameInput = Console.ReadLine();

        Console.WriteLine("Enter Your Password");
        var userPasswordInput = Console.ReadLine();

        if (userName == userNameInput.ToLower() && userPassword == userPasswordInput)
        { Console.WriteLine("Login SuccessFulll!!!!"); BankDetails(); }

    }

    private void BankDetails()
    {
        Console.WriteLine("Welcme to your dashboard!!!!!!!!!");
        Console.WriteLine("1. Check Balance \n 2. View Details \n 3. Deposit \n 4. Withdraw  \n 5. Exit");
        var userInput = Console.ReadLine();
        int.TryParse(userInput, out int userOption);

        if (userOption == 1)
        {
            Console.WriteLine(Balance);
        }
        else if (userOption == 2)
        {
            Console.WriteLine($" \n first name: {firstName} \n last name: {lastName} \n username: {userName} \n");
        }
        else if (userOption == 3)
        {
            Console.WriteLine("How much do You want to deposit");
            int.TryParse(Console.ReadLine(), out int userDepositInput);
            DepositMoney(amount: userDepositInput);
            Console.WriteLine("Deposit Successfull");
            Console.WriteLine($"Dear {userName}: Your Current Balance is: {Balance}");
        }
        else if (userOption == 4)
        {
            Console.WriteLine("How much do You want to deposit");
            int.TryParse(Console.ReadLine(), out int userDepositInput);
            WithdrawMoney(amount: userDepositInput);
            Console.WriteLine("Withdraw Successfull");
            Console.WriteLine($"Dear {userName}: Your Current Balance is: {Balance}");
        }


        else if (userOption == 5)
        {
            return;
        }

        else
        {
            Console.WriteLine("Invalid Option");
        }

    }


}

class Bank
{
    protected int Balance { get; set; }

    protected void DepositMoney(int amount)
    {
        Balance += amount;
    }

    protected void WithdrawMoney(int amount)
    {
        Balance -= amount;
    }
}