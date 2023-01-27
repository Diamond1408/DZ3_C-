//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

Random rnd = new Random();
int x1 = rnd.Next(-11, 11);
int y1 = rnd.Next(-11, 11);
int z1 = rnd.Next(-11, 11);
int x2 = rnd.Next(-11, 11);
int y2 = rnd.Next(-11, 11);
int z2 = rnd.Next(-11, 11);

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
System.Console.WriteLine($"A({x1}, {y1}, {z1}); B({x2}, {y2}, {z2}) -> {result}");
