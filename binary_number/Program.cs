// Задача 42 (необязательно): Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
Console.WriteLine("Введите десятичное число:");
int number = int.Parse(Console.ReadLine());

var binary = Convert.ToString(number,2);
Console.WriteLine($"Число {number} в двоичной  систему счисления: {binary}");