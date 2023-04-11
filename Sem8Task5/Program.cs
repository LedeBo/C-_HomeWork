// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int size = 4;
int[,] matrix = new int[size, size];

void FillArraySpiral(int[,] array, int a)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < a * a; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < a - 1);
        for (k = 0; k < a - 1; k++) array[i++, j] = value++;
        for (k = 0; k < a - 1; k++) array[i, j--] = value++;
        for (k = 0; k < a - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        a = a < 2 ? 0 : a - 2;
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

FillArraySpiral(matrix, size);
PrintArray(matrix);
