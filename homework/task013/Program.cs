// Задача 13: Напишите метод, который выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите любое целое числа число.\nВыхода из программы команда Exit.");

while (true)
{
    string input = Console.ReadLine(); // локальная переменная / считывает введёное значение
    if(!input.Equals("exit")) 
        Console.WriteLine("{0}->{2}", input, input[1]); // прогоняет две цифры из трёх с индексом [0] и [1]
        else
            break;
        // Console.WriteLine("{1}->{2}", input[1], input[2]);
        // else
        // break;
}

