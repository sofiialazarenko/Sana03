using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

    

        int n;
        bool f;
        do
        {
            Console.Write("Введіть кількість елементів (N): ");
            f = int.TryParse(Console.ReadLine(), out n);
            if (!f || n <= 0)
                Console.WriteLine("Помилка! N має бути цілим числом > 0.");
        } while (!f || n <= 0);

        double[] arr = new double[n];

        Console.WriteLine("\nВведення дійсних елементів масиву:");
        for (int i = 0; i < arr.Length; i++)
        {
            do
            {
                Console.Write("arr[{0}] = ", i);
                f = double.TryParse(Console.ReadLine(), out arr[i]);
                if (f == false)
                    Console.WriteLine("Помилка! Введено некоректне дійсне число.");
            } while (!f);
        }

        
        MyArray myArray = new MyArray(arr);

        Console.WriteLine($"Початковий масив: [{string.Join(", ", arr)}]");

        double sumNeg = myArray.SumNegative();
        Console.WriteLine($"1. Сума від'ємних елементів: {sumNeg}");

        double minElement = myArray.FindMinElement();
        Console.WriteLine($"2. Мінімальний елемент: {minElement}");

        int maxIndex = myArray.Index();
        Console.WriteLine($"3. Індекс максимального елемента: {maxIndex} (Значення: {arr[maxIndex]})");

        double maxAbs = myArray.Max();
        Console.WriteLine($"4. Максимальний за модулем елемент: {maxAbs} (Модуль: {Math.Abs(maxAbs)})");

        long sumIndices = myArray.SumPositive();
        Console.WriteLine($"5. Сума індексів додатних елементів: {sumIndices}");

        int intCount = myArray.Count();
        Console.WriteLine($"6. Кількість цілих чисел у масиві: {intCount}");

        Console.ReadKey();
    }
}