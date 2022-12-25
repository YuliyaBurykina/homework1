// See https://aka.ms/new-console-template for more information

Console.Write("Введите пятизначное число -> ");
int num = int.Parse(Console.ReadLine()!);
string strNum = $"{num}";

if (strNum[0] == strNum[4] && strNum[1] == strNum[3])
{
    Console.Write("да");
}
else
{
    Console.Write("нет");
}