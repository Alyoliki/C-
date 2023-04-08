// Напишите программу, которая на вход принимает
//  позиции элемента в двумерном массиве, 
//  и возвращает значение этого элемента или же указание,
//   что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет


Console.Clear();

Console.Write("Введите размер матрицы: ");
int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] matrix = new int[size[0], size[1]];

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}
InputMatrix(matrix);

Console.Write("ВВедите эдемент массива: ");
int[] Position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();

void FindElement(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (Position[0] < matrix.GetLength(0) && Position[1] < matrix.GetLength(1))
            {
                Console.Write($"{matrix[Position[1], Position[0]]}");
            }
            else
                Console.WriteLine("Элемент не найден");
        }
        Console.WriteLine();
    }
}
FindElement(matrix);