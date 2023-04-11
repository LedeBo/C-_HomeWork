// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rows = ReadInt("Введите количество строк: ");
int columns = ReadInt("Введите количество столбцов: ");
int[,] FirstArray = new int[rows, columns];
int[,] SecondArray = new int[rows, columns];
int[,] ResultArray = new int[rows, columns];

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

FillArray(FirstArray);
PrintArray(FirstArray);

Console.WriteLine();

FillArray(SecondArray);
PrintArray(SecondArray);

Console.WriteLine();

if (FirstArray.GetLength(0) != SecondArray.GetLength(1))
{
    Console.WriteLine(" Матрицы нельзя перемножить ");
    return;
}
for (int i = 0; i < FirstArray.GetLength(0); i++)
{
    for (int j = 0; j < SecondArray.GetLength(1); j++)
    {
        ResultArray[i, j] = 0;
        for (int k = 0; k < FirstArray.GetLength(1); k++)
        {
            ResultArray[i, j] += FirstArray[i, k] * SecondArray[k, j];
        }
    }
}

PrintArray(ResultArray);

