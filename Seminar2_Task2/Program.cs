// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

// Пример
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

  
System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 99)
{
    System.Console.WriteLine($"В числе {number} третьей цифры нет");
}
else
{
    while(number > 99 && number <1000)
    {
        System.Console.WriteLine($"Третья цифра заданного числа равна: {number%10}");
        break;
    }

    while(number > 999 && number <10000)
    {
        System.Console.WriteLine($"Третья цифра заданного числа равна: {(number/10)%10}");
        break;
    }
    while(number > 9999 && number <100000)
    {
        System.Console.WriteLine($"Третья цифра заданного числа равна: {(number/100)%10}");
        break;
    }

}
