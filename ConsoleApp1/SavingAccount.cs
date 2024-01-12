public class SavingAccount : BankAccount
{
    public override void deposit()
    {
        Console.WriteLine("Deposit in Savings Account");
    }

    public override void getBalance()
    {
       Console.WriteLine("Get Balance in Savings Account");
    }

    public override void withdraw()
    {
        Console.WriteLine("Withdraw in Savings Account");
    }
}