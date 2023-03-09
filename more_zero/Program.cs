// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите количество элементов массива");
int size=int.Parse(Console.ReadLine());
int[] array = new int[size];
Console.WriteLine("Ввод элементов массива");
for(int i=0;i<size;i++)
{
Console.Write($"Введите a[{i}]=");
while (!int.TryParse(Console.ReadLine(), out array[i]))
{
Console.WriteLine("Ошибка ввода! Введите целое число");
Console.Write($"Ещё раз введите a[{i}]=");
}
Console.WriteLine(array[i]);
}
Console.WriteLine("Вывод элементов массива больше 0");
int more=0;
for(int i=0;i<size;i++)
{
if (array[i]>0)
{
Console.WriteLine($"a[{i}]={array[i]}");
more++;
}
}
Console.WriteLine($"Чисел  больше 0: {more}");
