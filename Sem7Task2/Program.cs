// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет


int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int[rows, cols];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}

int CheckIndex(int[,] matrix)
{
metka:
    int n = ReadInt("Введите номер строки матрицы: ");
    int m = ReadInt("Введите номер столбца матрицы: ");

    if (n > matrix.GetLength(0) || m > matrix.GetLength(1))
    {

        System.Console.WriteLine("Элемента матрицы с такими индексами не существует");
        goto metka;

    }

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {

            if (n <= matrix.GetLength(0) || m <= matrix.GetLength(1))
            {

                System.Console.WriteLine($"Значение элемента с индексами: {n} , {m} равно: {matrix[n, m]} ");

            }
            break;
        }
        break;
        Console.WriteLine();

    }
    return matrix[n, m];
}

int rows = ReadInt("Введите количество строк матрицы: ");
int cols = ReadInt("Введите количество столбцов матрицы: ");


System.Console.WriteLine();

var myMatrix = GenerateMatrix(rows, cols);

PrintMatrix(myMatrix);

CheckIndex(myMatrix);

