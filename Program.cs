﻿using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void Main()
    {
        int[] arr = new int[] { 4, 35, 86, 2, 84, 5, 1, 76 };
        int[] arr2 = new int[] { 5, 8, 45, 1, 45, 1, 75, 6 };

        //MinMax(arr);
        //FactorialDemo();
        IndexOfDemo(arr);
        Contains(arr);

    }

    private static void Contains(int[] arr)
    {
        int targetElement = 4;
        int indexTarget = Contains(arr, targetElement);

        if (indexTarget != -1)
        {
            Console.WriteLine($"елемент {targetElement} присутній");
        }
        else
        {
            Console.WriteLine("відсутній");
        }
    }

    private static void IndexOfDemo(int[] arr)
    {
        int target = 86;
        int index = IndexOf(arr, target);

        if (index != -1)
        {
            Console.WriteLine($"??? {target},{index}");
        }
        else
        {
            Console.WriteLine("error? yes!", target);
        }
    }

    private static void FactorialDemo()
    {
        int number = 6;
        int factorial = Factorial(number);
        Console.WriteLine($"Факторіал числа {number} = {factorial}");
    }

    private static void MinMax(int[] arr)
    {
        var resultMinIndex = GetMinValueIndex(arr);
        var resultMaxIndex = GetMaxValueIndex(arr);
        SelectionSort(arr);

        Console.WriteLine(resultMinIndex);
        Console.WriteLine(resultMaxIndex);
        Console.WriteLine(string.Join(",", arr));
    }

    public static int GetMinValueIndex(int[] arr){
        int minValue = arr[0];
        int minIndex = 0;
        for (var i=0; i<arr.Length;i++){
            if (arr[i] < minValue){
                minValue = arr[i];
                minIndex = i;
                }
        }
        return minIndex;
    }

    public static int GetMaxValueIndex(int[] arr){
        int maxValue = arr[0];
        int maxIndex = 0;
        for (var i=0; i<arr.Length;i++){
            if (arr[i] > maxValue){
                maxValue = arr[i];
                maxIndex = i;
                }
        }
        return maxIndex;
    }
    public static void SelectionSort(int[] arr){
        int temp;
        for (int i = 0; i<arr.Length; i++)
        {
            var minIndex = i;
            for(var j =i; j<arr.Length; j++)
            {
                if(arr[j]<arr[minIndex])
                {
                    minIndex = j;
                }
            }
            temp=arr[minIndex];
            arr[minIndex]=arr[i];
            arr[i]=temp;         
        }
    }
    public static int Factorial(int number)
    {
        int result = 1;
        if(number > 1)
        {
            result = number*Factorial(number-1);
        }
        return result;  
    }

    public static int IndexOf(int[] arr,int target)
    {
        for (int i=0; i<arr.Length; i++)
        {
            if(arr[i]== target)
            {
                return i;
            }
        }
        return -1;
    }

    public static int Contains(int[] arr, int targetElement)
    {
        for (int i=0; i<arr.Length; i++)
        {
            if(arr[i]==targetElement)
            {
                return i;
            }
        }
        return -1;
    }

    public static int Intersect(int[] arr)
    {
        for(int i=0; i<arr.Length; i++)
        {
            
        }
        return 0;
    }

}