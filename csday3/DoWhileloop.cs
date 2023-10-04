class DoWhileloop
{
    public static void Main(){
       
        char ch;
        do{
            Console.WriteLine("Please enter your name:");
          
            string? name=Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Welcome, {name}");

            Console.WriteLine("Do you want to continue:(y/n)");
            ch=Convert.ToChar(Console.ReadLine());

        }while(ch=='y');
        Console.WriteLine("Exit");
    }
}