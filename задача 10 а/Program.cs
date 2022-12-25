// See https://aka.ms/new-console-template for more information
Console.WriteLine("введите трехзначное число ");
int a = int.Parse(Console.ReadLine()!);
int b = a/ 10 % 10;
Console.WriteLine(b);
Console.WriteLine("мы получили вторую цифру от нужного числа");
