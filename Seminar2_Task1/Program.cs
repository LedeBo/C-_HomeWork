// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// Пример
// 456 -> 5
// 782 -> 8 
// 918 -> 1

System.Console.WriteLine($"Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number / 10;

if(number>99 && number < 1000)
{
    System.Console.WriteLine($"Вторая цифра введенного трёхзначного числа {number} равна: {result%10}");
}
// else if(number< -99 && number > -1000)
// {
//     System.Console.WriteLine($"Вторая цифра введенного трёхзначного числа {number} равна: {-result%10}");
// }
else
{
    System.Console.WriteLine($"Вы ввели не трёхзначное число");
}
