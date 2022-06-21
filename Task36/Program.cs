//Задача 36. Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечетных позициях.

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[8]; //задание массива с именем array из 8 элементов

        void FillArray(int[] rndArray) //задание метода для заполнения какого-то массива с заданным количеством случайных элементов
        {
            for (int index = 0; index < rndArray.Length; index++)
            {
                rndArray[index] = new Random().Next(-50, 51);
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

        int oddPositionSumElements = 0; //сумма элементов, стоящих на нечетных позициях
        for (int i = 1; i < array.Length; i = i + 2)
        {
            if (i % 2 != 0)
            {
                oddPositionSumElements = oddPositionSumElements + array[i];
            }
        }
        Console.WriteLine("The sum of odd position elements in array is: " + oddPositionSumElements);
    }
}