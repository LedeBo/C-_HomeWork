// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// Пример
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine($"Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

while (number < 99)
{
    System.Console.WriteLine($"В числе {number} третьей цифры нет");
    break;
}

while (number > 99)
{
    while (number > 999)
    {
        number = number / 10;
    }

    System.Console.WriteLine($"Третья цифра заданного числа равна: {number % 10}");
    break;
}


