// See https://aka.ms/new-console-template for more information
string[]Days = {"Понедельник","Вторник","Среда","Четверг","Пятница","Суббота","Воскресенье" };
Console.Write("Задайте дни недели ->");
int numberDays = int.Parse(Console.ReadLine()!);
Console.WriteLine(Days[numberDays-1]);