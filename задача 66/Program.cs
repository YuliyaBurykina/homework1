// See https://aka.ms/new-console-template for more information
Console.Clear();
 Console.Write("Введите N: ");
 int n = int.Parse(Console.ReadLine());
 Console.WriteLine(SumNumbers(1, n));

 int SumNumbers(int start, int end)
 {
 if (start == end) return end;
 int answer = start + SumNumbers(start + 1, end);
 return answer;
 }
