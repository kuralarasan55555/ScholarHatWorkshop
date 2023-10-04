class IfElseLadderProgram
{
    public static void Main(){
      int num1 = Convert.ToInt32(Console.ReadLine());
      int num2 = Convert.ToInt32(Console.ReadLine());
      int num3 = Convert.ToInt32(Console.ReadLine());

      if(num1>num2&&num1>num3){
        Console.WriteLine($"Largest number:{num1}");
      }
      else if(num2>num3){
        Console.WriteLine($"Largest number:{num2}");
      }
      else{
        Console.WriteLine($"Largest number:{num3}");
      }
  
    }
}