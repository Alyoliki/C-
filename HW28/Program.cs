// Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Clear();

int SumNum(int Num1, int Num2)
{
    if(Num1 == Num2)
        return Num1;
    return Num1 + SumNum(Num1 + 1, Num2); 
}

Console.Write($" Сумма натуральных чисел Num1 и Num2: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(SumNum(numbers[0], numbers[1]));