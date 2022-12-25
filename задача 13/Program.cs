// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите трехзначное число ");
int a = int.Parse(Console.ReadLine()!);
int b = a/100 % 10;
if (b % 10>0 )
{
    Console.Write("Третье число");
    Console.WriteLine(b);
}
else {
Console.WriteLine("Третьего числа нет");
}

