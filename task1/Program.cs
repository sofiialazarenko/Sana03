using System;
using System.Linq;
using System.Text;

public class MyArray
{
    private double[] data;

  
    public MyArray(double[] array)
    {
        this.data = array;
    }

   
    public double SumNegative()
    {
        return data.Where(x => x < 0).Sum();
    }

    
    public double FindMinElement()
    {
        if (data.Length == 0) return double.NaN;
        return data.Min();
    }

    
    public int Index()
    {
        if (data.Length == 0) return -1;

        double maxVal = data[0];
        int maxIndex = 0;

        for (int i = 1; i < data.Length; i++)
        {
            if (data[i] > maxVal)
            {
                maxVal = data[i];
                maxIndex = i;
            }
        }
        return maxIndex;
    }

  
    public double Max()
    {
        if (data.Length == 0) return 0.0;

        double maxAbs = 0.0;
        double maxElement = 0.0;

        foreach (var x in data)
        {
            double absValue = Math.Abs(x);

            if (absValue > maxAbs)
            {
                maxAbs = absValue;
                maxElement = x;
            }
        }
        return maxElement;
    }

    public long SumPositive()
    {
        long sumIndices = 0;
        for (int i = 0; i < data.Length; i++)
        {
            if (data[i] > 0)
            {
                sumIndices += i;
            }
        }
        return sumIndices;
    }

    public int Count()
    {
        int count = 0;
        foreach (var x in data)
        {
            if (x == Math.Floor(x))
            {
                count++;
            }
        }
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.Unicode;
        Console.InputEncoding = Encoding.Unicode;

        Console.WriteLine("Лазаренко Софія Андріївна ІПЗ-25-2");
     

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