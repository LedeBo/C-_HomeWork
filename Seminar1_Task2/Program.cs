// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

System.Console.WriteLine("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b && a > c || a >= b && a > c || a > b && a >= c)
{
    System.Console.WriteLine("max: " + a);
}
else if (b > a && b > c || b >= a && b > c || b > a && b >= c)
{
    System.Console.WriteLine("max: " + b);
}
else if (c > a && c > b || c >= a && c > b || c > a && c >= b)
    System.Console.WriteLine("max:  " + c);

else
{
    System.Console.WriteLine("значения равны ");
}
