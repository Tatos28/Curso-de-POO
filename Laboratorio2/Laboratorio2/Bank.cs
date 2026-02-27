namespace Laboratorio2;

public class Bank
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("Santiago", 1000);

        account.ShowBalance();
        
        account.Deposit(500);
        
        account.withdraw(2000);
        
        account.withdraw(500);
        
        account.ShowBalance();
        
        
    }

}