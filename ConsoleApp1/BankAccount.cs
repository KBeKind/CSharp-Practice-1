public abstract class BankAccount {

    public void getMessage(){
        Console.WriteLine("Welcome to the bank");
    }

    public abstract void deposit();

    public abstract void withdraw();

    public abstract void getBalance();

}