//Напишите программу, которая будет создавать массив из 8
// символов и заполнять значениями от пользователя

//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

//6, 1, 33 -> [6, 1, 33]

void printArray(int[] array)
{
   System.Console.WriteLine($"[{string.Join(", ", array)}]"); 
}

System.Console.Clear();
int[] array = new int[8];
int index = 0;
int n = 8;

for (int i = 0; i < 8; i++)
{
    Console.WriteLine("number: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
