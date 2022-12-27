// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число А и число В");
int A = int.Parse(Console.ReadLine()!);
int B = int.Parse(Console.ReadLine()!);
int index = 1;
int result = 1;
while (index <= B)
{
    result = result * A;
    index = index + 1;
}
Console.WriteLine(result);
