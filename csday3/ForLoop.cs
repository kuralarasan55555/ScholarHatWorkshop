class ForLoop
{
    public static void Main(){
        Console.WriteLine("Enter a number");
        int n=Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= n; i++) //ROWS
        {
            for(int j=1;j<=i;j++)//COLUMNS
            {
                Console.Write("*");
            }
            Console.WriteLine();
            
        }
    }
}