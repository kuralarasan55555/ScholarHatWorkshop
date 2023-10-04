public class Contact{
    public long  number{get; set;}
    public string name {get; set;}
    public Contact(string name,long number){
        this.name=name;
        this.number=number;       
    }
}
public class Implementation{
    List<Contact> contacts=new();
    public void Add(Contact c){
        if(checknum(c.number)){
            Console.WriteLine("NUMBER ALREADY EXIST");
        }
        else if(checkname(c.name)){
             Console.WriteLine("NAME ALREADY EXIST");
        }
        else{
            contacts.Add(c);
            Console.WriteLine("CONTACT ADDED");
        }
    
    }
    public bool checknum(long n){
        for(int i=0;i<contacts.Count();i++){
            if(contacts[i].number==n){
                return true;
            }
        }
        return false;
    }
    public bool checkname(string n){
        for(int i=0;i<contacts.Count();i++){
            if(contacts[i].name==n){
                return true;
            }
        }
        return false;
    }
    public void getAll(){
        for (int i = 0; i < contacts.Count(); i++)
        {
            Console.WriteLine($"Name : {contacts[i].name}, Phone Number : {contacts[i].number}");
        }
    }
}
public class Phonebook
{

   public static void Main(string[] ar){
    do{
       Console.WriteLine("What you want to do ?(add/exit)");
       if(Console.ReadLine()=="exit")
            break;
        Console.WriteLine("Enter the name");
        string? s=Console.ReadLine();
        Console.WriteLine("Enter the phone number:");
        long num=Convert.ToInt64(Console.ReadLine());
        Contact s1=new Contact(s,num);
        Implementation i=new Implementation();
        i.Add(s1);

    }while(true);
   }
   

}