class Calculator
{
    public static void Main(string[] args)
    {
      
      
       do{
        Console.Clear();
        Console.WriteLine("==============CALCULATOR==============");
        Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Remainder"); 
        Console.WriteLine("Enter your choice");
        int n=Convert.ToInt32(Console.ReadLine());
          switch (n)
          {
            case 1:
                Console.WriteLine("Enter two numbers:");
                  int a=Convert.ToInt32(Console.ReadLine());
                  int b=Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Sum="+(a+b));
                  break;
             case 2:
                  Console.WriteLine("Enter two numbers:");
                  int s1=Convert.ToInt32(Console.ReadLine());
                  int s2=Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Subtraction="+(s1-s2));
                  break;
             case 3:
                  Console.WriteLine("Enter two numbers:");
                  int m1=Convert.ToInt32(Console.ReadLine());
                  int m2=Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Multiplication="+(m1*m2));
                  break;
            
              case 4:
                  Console.WriteLine("Enter two numbers:");
                  int d1=Convert.ToInt32(Console.ReadLine());
                  int d2=Convert.ToInt32(Console.ReadLine());
                  int div=(d1>d2)?d1/d2:d2/d1;
                  Console.WriteLine("Division="+div);
                  break;

              case 5:
                  Console.WriteLine("Enter two numbers:");
                  int r1=Convert.ToInt32(Console.ReadLine());
                  int r2=Convert.ToInt32(Console.ReadLine());
                  int rem=(r1>r2)?r1%r2:r2%r1;
                  Console.WriteLine("Remainder="+rem);
                  break; 
            default:
                   Console.WriteLine("Enter a choice between 1 to 5");
                   continue;
                   
            
          }
          Console.WriteLine("Do you want to continue (y/n)");
           if(Console.ReadLine()=="n"){
            break;
           }
          
       }while(true);
       Console.WriteLine("==============EXIT==============");
    }
}