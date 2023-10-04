using System.Security.Cryptography.X509Certificates;

public class BankAccount{
    protected int AccountNo;
    public string Name;
    protected decimal Balance=0;
    protected decimal InterestRate=0;
    public void Add(int accountno,string name){
        this.AccountNo=accountno;
        this.Name=name;
    }
    public void Deposit(int amount){
        this.Balance=this.Balance+amount;
    }
     public void Withdrawl(int amount)
     {
        if(this.Balance>=amount)
          this.Balance=this.Balance+amount;
        else
           Console.WriteLine("BALANCE LESS THAN 1000");
    }
    public virtual decimal CalculateInterest(){
        return 0;
    }
}
class SavingAccount: BankAccount{
    //Method Overriding
      public decimal CalculateInterest(){
        this.InterestRate=5.5M;
        decimal interest=(Balance*InterestRate)/100;
        return interest;
      }
}
public class CurrentAccount:BankAccount{

}
public class Inheritance{
    public static void Main(){
        SavingAccount savingAccount=new SavingAccount();
        savingAccount.Add(101,"Kural");
        savingAccount.Deposit(100);

        decimal interest=savingAccount.CalculateInterest();
        Console.WriteLine($"Interest:{interest}");
    }
}
