// Задача 13: Напишите метод, который выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

// Мой способ № 1:
// int number = new Random().Next(10, 999999);
// Console.WriteLine(number);
// if(number < 1000000)
// {
// int result = (number / 1000) % 10;
// Console.WriteLine(result);
// }
// else
// {
// if(number < 100000)
// {
// int result = (number / 1000) % 10;
// Console.WriteLine(result);
// }
// else
// {
// if(number < 10000)
// {
// int result = (number / 100) % 10;
// Console.WriteLine(result);
// }
// else
// {
// if(number < 100)
// {
// Console.WriteLine("Третьей цифры нет");
// } 
// }
// }
// }

// 2 Способ через цикл с методом void

// internal class Program
// {
// private static void Main(string[] args)
// {
// void thirdDigit(int num)
// {
// if (Math.Abs(num) < 100)
// {
// Console.WriteLine("Третья цифра отсутствует");
// }
// else
// {
// while (Math.Abs(num) < 999)
// {
// num /= 10;
// }
// Console.WriteLine($"Третья цифра цикла: {Math.Abs(num % 10)}");
// }
// }

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// thirdDigit(number);
// }
// }

// Метод №3! Конечный!

int value = new Random().Next(-99, 99999);
Console.WriteLine(value);
if (value < 0) value = -value;

// if (value > 100)
// {
// while (value > 1000) value /= 10;
// Console.WriteLine(value % 10);
// }

void result(int value)
{
    int b = value / 100 % 10;
    if (b < 99) Console.WriteLine(b);
    else Console.WriteLine("Третьей цифры нет");
}

result(value);