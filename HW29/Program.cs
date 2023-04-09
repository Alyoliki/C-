//Напишите программу вычисления функции
//  Аккермана с помощью рекурсии.
//   Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Clear();

int Akkerman(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0 && m > 0)
    {
        return Akkerman(m - 1, 1);
    }
    return (Akkerman(m - 1, Akkerman(m, n - 1)));
    
}

Console.Write($" Введите числа m и n для исчисления функции Аккермана: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(Akkerman(numbers[0], numbers[1]));

