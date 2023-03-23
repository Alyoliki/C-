// Задача 28: Напишите программу,
//  которая принимает на вход число N
// и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int f(int n)
// {
//    if (n == 0) 
//     return 1;
//    int count = 0;
//    while (n > 0)
//    {
//     n /= 10;
//     count ++;
//    }
//    return count;
// }
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));


// Задача 28: Напишите программу, 
// которая принимает на вход число N и выдаёт
//  произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// int f(int n)
// {
//     int i = 2;
//     return ( n = i * (i -1));
//     i ++;
// }
// Console.Clear();
// int n = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(f(n));

// Задача 30: Напишите программу, которая
// выводит массив из 8 элементов,
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 2); 

}

Console.Clear();
int[] array = new int[8];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]");

