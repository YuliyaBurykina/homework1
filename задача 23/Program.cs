// See https://aka.ms/new-console-template for more information
Console.Write("-> ");
int N = int.Parse(Console.ReadLine()!);

for (double i = 1; i <= N; i++) Console.WriteLine($"{i * i * i}");
