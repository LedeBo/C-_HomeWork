// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76



double[] GenerateArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    var rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((rand.Next(minValue, maxValue) + rand.NextDouble()), 2);
    }
    return array;
}


double GetResult(double[] array)
{

    double max = array[0];

    double min = array[0];

    double result = 0;


    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];

        }


        else if (array[i] < min)
        {
            min = array[i];

        }


        result = max - min;

    }
    System.Console.WriteLine($"разница между максимальным {max} и минимальным {min} элементами массива равна: {Math.Round(result, 2)} ");

    return max;
    return min;
    return result;
}



void PrintArray(double[] array)
{
    System.Console.WriteLine("[" + string.Join(", ", array) + "]");
}

double[] array = GenerateArray(5, 5, 40);

PrintArray(array);

GetResult(array);

