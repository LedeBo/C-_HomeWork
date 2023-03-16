// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт 
// сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30



int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}

int sum = 0;

void GetSumNaturalNumbers(int numberM, int numberN, int sum)
{

    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GetSumNaturalNumbers(numberM, numberN, sum);
}


int numberM = ReadInt("Введите натуральное число M: ");
int numberN = ReadInt("Введите натуральное число N: ");
GetSumNaturalNumbers(numberM, numberN, sum);

