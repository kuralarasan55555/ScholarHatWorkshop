class If
{
    public static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num > 0)
        {
            Console.WriteLine("Number greater than zero");
        }
        Console.WriteLine("EXIT!");
    }
}


