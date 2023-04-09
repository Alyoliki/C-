//Задайте значение N. Напишите программу,
//  которая выведет все натуральные числа
//   в промежутке от N до 1. Выполнить с 
//   помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Clear();

String OutPutNumber(int Number)
{
    if(Number == 1)
        return 1.ToString();
    return Number.ToString() + ", " + OutPutNumber(Number - 1); 
}

Console.Write($" Введите натуральное число: ");
int Number = int.Parse(Console.ReadLine());
Console.Write(OutPutNumber(Number));