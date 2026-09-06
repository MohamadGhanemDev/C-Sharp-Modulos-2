// even and odd

Console.WriteLine(54 % 2); // even number %2 remainder is 0
Console.WriteLine(53 % 2); // odd number %2 remainder is 1

Console.WriteLine("---------------------------------------------");

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0)
{
    Console.WriteLine("Even Number");
}
else if (num %2 != 0)
{
    Console.WriteLine("Odd Number");
}
else
{
    Console.WriteLine("Make sure you entered a number");
}
