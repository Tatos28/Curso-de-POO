using System.ComponentModel.Design;

public class BankAccount
{
    private string holder;
    private float balance;
    
    public BankAccount(string holder, float balance)
    {
        this.holder = holder;
        this.balance = balance;
        }

    //metodo 1
    public void ShowBalance()
    {
        Console.WriteLine($"Saldo de {holder}: ${balance}");
    }      
 
 //metodo 2
 public void Deposit(float amount)
 {
         if (amount > 0)
         {
             
     balance += amount;
     Console.WriteLine($"Deposito de {amount} exitoso");
 }
         else
         {
             Console.WriteLine("Imposible de depositar la cantidad mencionada:0");
                     }
 }
 //metodo 3 
 public void withdraw(float amount)
 {
     if (amount > 0 && amount <= balance)
     {
         Console.WriteLine($"Retiro de {amount} exitoso");
     }
     else
     {
         Console.WriteLine("Imposible Retirar la cantidad mencionada");
     }
 }     
 }
 