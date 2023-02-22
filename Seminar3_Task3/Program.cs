// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

void PrintCube(int N)
{
    for ( int count = 1; count <= N; count ++ )
{
    System.Console.Write (Math.Pow(count,3) + " ");
}
}
PrintCube(N);
