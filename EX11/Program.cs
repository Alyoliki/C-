// // второй максимум

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int maxFirst = n, maxSecond = -1;

// while(n != 0)
// {
//     n = Convert.ToInt32(Console.ReadLine());

//     if (n > maxFirst)
//     {
//         maxSecond = maxFirst;
//         maxFirst = n;
//     }
//     else if (n > maxSecond)
//         maxSecond = n;
// }

// Console.WriteLine(maxSecond);



// int[] array = Console.ReadLine().Split(" 5 ").Select(x => int.Parse(x)).ToArray();
// // "5 4 3 2"
// // "5", "4", "3", "2"
// // 5, 4, 3, 2
// // [5, 4, 3, 2]
// Console.WriteLine($"[{string.Join(", ", array)}]");

// foreach (int elem in array)
//     Console.WriteLine(elem * 100);


//     Задача 39: Напишите программу, которая перевернёт одномерный массив
//      (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]


// void InputArray(int[] array)
// {
// 	for (int i = 0; i < array.Length; i++)
// 		array[i] = new Random().Next(-9, 10); // [-9, 9]
// }


// void ReleaseArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
// }

// Console.Clear();
// Console.Write("Введите кол-во элементов: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// InputArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");
// ReleaseArray(array);
// Console.WriteLine($"[{string.Join(", ", array)}]");


// Задача 40: Напишите программу, которая принимает на вход три числа
//  и проверяет, может ли существовать треугольник с сторонами такой длины.

// void ReleaseArray(int[] array)
// {
//     if (array[0] < array[1] + array[2] 
//         && array[1] < array[0] + array[2] 
//         && array[2] < array[0] + array[1])
//         Console.Write("Yes");
//     else
//         Console.Write("No");
// }

// Console.Clear();
// int[] array = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// ReleaseArray(array);




// // Задача 42: Напишите программу, которая будет преобразовывать 
// // десятичное число в двоичное.


// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());

// string res = String.Empty;
// while(n > 0)
// {
//     res = Convert.ToString(n % 2) + res;
//     n /= 2;
// }
// Console.WriteLine(res);


// // Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// // Первые два числа Фибоначчи: 0 и 1.
// // Если N = 5 -> 0 1 1 2 3
// // Если N = 3 -> 0 1 1
// // Если N = 7 -> 0 1 1 2 3 5 8

// // 0 1 1 2 3 5 8 13 

// Console.Clear();
// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a0 = 0, a1 = 1, x;

// for (int i = 0; i < n; i ++)
// {
//     Console.Write($"{a0} ");
//     x = a0 + a1;
//     a0 = a1;
//     a1 = x;
// }




// // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в 
// // массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// // m = 3, n = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5



// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = i + j; //new Random().Next(-10, 10);
//             Console.Write($"{matrix[i,j]} \t");
//         }
//         Console.WriteLine();
//     }

// }


// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);



// Задача 49: Задайте двумерный массив. Найдите элементы, у которых 
// оба индекса чётные, и замените эти элементы на их квадраты.


// void InputMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i,j] = new Random().Next(-10, 10);
//             Console.Write($"{matrix[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }


// void ReleaseMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             if (i % 2 == 0 && j % 2 == 0)
//             matrix[i,j] = matrix[i,j] * matrix[i,j];
//             Console.Write($"{matrix[i,j]} \t");
//         }
//         Console.WriteLine();
//     }
// }
// Console.Clear();
// Console.Write("Введите размер матрицы: ");
// int[] size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
// int[,] matrix = new int[size[0], size[1]];
// InputMatrix(matrix);
// Console.WriteLine();
// Console.WriteLine();
// ReleaseMatrix(matrix);