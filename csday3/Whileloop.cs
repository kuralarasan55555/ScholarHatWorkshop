class Whileloop{
    public static void Main(){
        Console.WriteLine("Please Enter a number");
        int num=Convert.ToInt32(Console.ReadLine());
        int sum=0;
        while(num>0){
            sum+=(num%10);
            num/=10;
        }
        Console.WriteLine("SUM OF THE NUMBER:"+sum);
    }
}