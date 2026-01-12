using System;
using System.Linq;


public class MyArray
{
    protected double[] _array;

   
    public MyArray(double[] arr)
    {
        _array = arr;
    }

    
    public double SumNegative()
    {
       
        return _array.Where(x => x < 0).Sum();
    }

    public double FindMinElement()
    {
       
        return _array.Min();
    }

    public int Index()
    {
       
        return Array.IndexOf(_array, _array.Max());
    }

    public double Max()
    {
       
        return _array.OrderByDescending(Math.Abs).First();
    }

    public long SumPositive()
    {
       
        long sum = 0;
        for (int i = 0; i < _array.Length; i++)
            if (_array[i] > 0) sum += i;
        return sum;
    }

    public int Count()
    {
        
        return _array.Count(x => x % 1 == 0);
    }
}