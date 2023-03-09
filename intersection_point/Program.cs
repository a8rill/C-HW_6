// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.WriteLine("Введите параметры первого уравнения:");
Console.Write("k1=");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine(k1);
Console.Write("b1=");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine(b1);

Console.WriteLine("Введите параметры второго уравнения:");
Console.Write("k2=");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine(k2);
Console.Write("b2=");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine(b2);

double[] tochki_per(double k11, double b11, double k22, double b22)
{
double[] t = new double[2];
t[0]=(b22-b11)/(k11-k22);
t[1]=k11*t[0]+b11;
return t;
}

if (k1==k2) Console.WriteLine("Прямые параллельны друг другу и не имеют точки пересечения");
else
{
double[] t1 = new double[2];
t1=tochki_per(k1,b1,k2,b2);
Console.WriteLine($"Точка пересечения: ({String.Join("; ", t1)})");
}