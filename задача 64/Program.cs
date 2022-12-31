Console.Clear();
 Console.Write("Введите N: ");
 int n = int.Parse(Console.ReadLine());
 Console.WriteLine(PrintNumbers(n));

 string PrintNumbers(int number)
 {
 if (number == 1) return "1";
 string answer = number + " " + PrintNumbers(number - 1);
 return answer; // "3 2 1"
 }