internal partial class Program
{
    private static void Main(string[] args)
    {
        //Задача 38. Задайте массив вещественных чисел.
        //Найдите разницу между максимальным и минимальным элементом массива.
        double[] array = new double[5];
        Random random = new Random();
        Console.WriteLine();
        Console.WriteLine("Случайно сгенерированный массив вещественных чисел:");
        for (int j = 0; j < 5; j++)
        {
            array[j] = random.NextDouble() * 100; // NextDouble() дает случайное вещественное число в диапазоне от 0 до 1
            Console.Write("{0,6:F2}  ", array[j]); //F2 округляет числа до двух знаков после запятой. Можно конечно сделать F6, но у меня в голове опилки, и длинные числа меня расстраивают.
        }
        Console.WriteLine();
        double maxElement = array[0];
        double minElement = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < minElement)
            {
                minElement = array[i];
            }
            if (array[i] > maxElement)
            {
                maxElement = array[i];
            }
        }        
        Console.WriteLine("Разность между максимальным и минимальным элементом массива: ");
        Console.WriteLine("{0,6:F2}", maxElement - minElement);
        Console.WriteLine();
    }
}
//Console.WriteLine("Min {0,6:F2}", minElement);
//Console.WriteLine("Max {0,6:F2}", maxElement);