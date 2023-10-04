class ForLoopEach
{
    public static void Main(){
        int[] numbers=new int[]{10,20,30,40,50};
        Console.WriteLine("FOR LOOP:");
        for (int i = 0; i < numbers.Length; i++)
        {
           numbers[i]=numbers[i]+1;
           Console.WriteLine(numbers[i]);   
        }
        Console.WriteLine("FOREACH LOOP:");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
    }
}