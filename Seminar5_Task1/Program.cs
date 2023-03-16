// Задача 34:
// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] GenerateArray(int size, int LeftRange, int RightRange)
{
    int[] array = new int[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(LeftRange, RightRange + 1);
    }
    return array;
}


int GetResult(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((array[i] % 2) == 0)
        {
            result++;
        }

    }
    return result;
}

void PrintArray(int[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}


int[] array = GenerateArray(4, -999, 999);
PrintArray(array);
System.Console.WriteLine($"количество чётных чисел в массиве: {GetResult(array)}");
