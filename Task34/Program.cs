//Задайте массив, заполненный случайными положительными трехзначными числами.
//Напишите программу, которая покажет количество четных чисел в массиве.

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[12]; //задание массива с именем array из 12 элементов
        void FillArray(int[] rndArray) //задание метода для заполнения какого-то массива с заданным количеством случайных элементов
        {
            for (int index = 0; index < rndArray.Length; index++)
            {
                rndArray[index] = new Random().Next(100, 1000);
            }
        }

        void PrintArray(int[] prntArray) //задание метода для вывода элементов любого массива на консоль
        {
            for (int position = 0; position < prntArray.Length; position++)
            {
                Console.Write(prntArray[position] + " ");
            }
            Console.WriteLine();
        }
        FillArray(array);
        Console.WriteLine("Your random array is: ");
        PrintArray(array);
        int evenNumbers = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                evenNumbers++;
            }
        }
        Console.Write("The quantity of even numbers in array is equal: " + evenNumbers);
    }
}