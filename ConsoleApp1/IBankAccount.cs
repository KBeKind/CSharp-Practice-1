internal interface IBankAccount {

    void deposit();

    void withdraw();

    void balance();

}


internal interface IManageBank {

    void openAccount();

    void closeAccount();

}

public class SavingAcc: IBankAccount, IManageBank {

    public void openAccount() {
        Console.WriteLine("Open Account in Savings Account");
    }

    public void closeAccount() {
        Console.WriteLine("Close Account in Savings Account");
    }

    public void deposit()
    {
        Console.WriteLine("Deposit in Savings Account");
    }

    public void balance()
    {
       Console.WriteLine("Get Balance in Savings Account");
    }

    public void withdraw()
    {
        Console.WriteLine("Withdraw in Savings Account");
    }

}