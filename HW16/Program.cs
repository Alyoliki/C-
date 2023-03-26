// Задайте массив вещественных чисел. Найдите 
// разницу между максимальным и минимальным
//  элементов массива.
// [3 7 22 2 78] -> 76

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 100);
}

void ReleaseArray(int[] array)
{
    int max = array[0];
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
        if (array[i] > max)
            max = array[i];
        else if (array[i] <  min)
             min = array[i];

    Console.WriteLine ($"Разница max и  min = {max - min}");
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

Console.Clear();
Console.WriteLine ($"n = ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
PrintArray(array);
ReleaseArray(array);