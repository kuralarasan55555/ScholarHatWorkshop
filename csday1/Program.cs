//Add a two number
/*int num1,num2;

Console.WriteLine("Enter a first number");
num1=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a second number");
num2=Convert.ToInt32(Console.ReadLine());

int sum=num1+num2;
Console.WriteLine("Sum:"+sum);*/

// Swapping a number
/*Console.WriteLine("Enter a first number");
int a=Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter a second number");
int b=Convert.ToInt32(Console.ReadLine());

//To DO:
a=a+b;
b=a-b;
a=a-b;
Console.WriteLine(a+" "+b);*/

/*Print the table of a number*/
// Console.WriteLine("Enter table of a number");
// int a=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("{0} X {1} = {2}",a,1,a*1);
// Console.WriteLine($"{a} X {2} = {a*2}");

int a=Convert.ToInt32(Console.ReadLine());
int sum=(a%10+(a/10)%10+(a/100)%10+(a/1000)%10);
Console.WriteLine($"SUM:{sum}");

