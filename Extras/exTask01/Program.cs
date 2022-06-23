//Задача 1. Задан массив из случайных цифр на 15 элементов. На вход подается трехзначное натуральное число.
//Напишите программу, которая определяет, есть ли в массиве последовательность из трех элементов, совпадающая с введенным числом.        

internal class Program
{
    private static void Main(string[] args)
    {
        while (true) //бесконечный цикл :)
        {
            Console.Write("Enter three-digit number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 100 || number > 999)
            {
                Console.WriteLine("Wrong format! You must enter THREE!!!-digit number. Try again.");
            }
            else
            {
                int[] array = new int[15];
                void FillArray(int[] rndArray) //задание метода для заполнения какого-то массива с заданным количеством случайных элементов
                {
                    for (int index = 0; index < rndArray.Length; index++)
                    {
                        rndArray[index] = new Random().Next(0, 10);
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
                Console.WriteLine("Nice choice! Start generating array...");
                FillArray(array);
                Console.WriteLine("Done!");
                PrintArray(array);
                int joy = 0; //здесь можно было бы объявить переменную типа bool, но я хочу int )) 
                for (int i = 0; i < 13; i++) //длина задана так, чтобы цикл заканчивал свою работу на последней тройке элементов массива
                {
                    int hundreds = array[i] * 100;
                    int tens = array[i + 1] * 10;
                    int digits = array[i + 2];
                    int compareNumber = hundreds + tens + digits;
                    if (compareNumber == number)
                    {
                        joy++;
                    }
                }
                if (joy == 1) Console.WriteLine("Yes! We have a match!");
                else Console.WriteLine("Sorry, pal. There aren't any matches.");
                break;
            }
        }
    }
}
//Надо сказать, что я ни разу не угадал число ). Работоспособность кода смог проверить только для массива с заранее заданными элементами.