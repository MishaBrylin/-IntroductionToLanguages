// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
int [] CreateRandomArray(int n, int minVal, int maxVal)
{
 int [] arr = new int[n];
 for (int i = 0; i < n; i++) 
 {
    arr[i] = new Random().Next(minVal, maxVal+1);
 }
 return arr;
}
void PrintArray(int [] arr)
{   Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
      Console.Write($"{arr[i]}, ");
       Console.WriteLine($"\b\b]");  
}

int EvenNumbers(int [] arr)
{   
    int count = 0;    
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 == 0)
            count++;
    }
    return count;
}
int [] arr = CreateRandomArray(5, 100, 1000);
PrintArray(arr);
int res = EvenNumbers(arr);
Console.WriteLine($"Количество четных чисел в массиве =  {res}");

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int SumOddNumbers(int [] arr)
{   
    int res = 0;    
    for (int i = 0; i < arr.Length; i++)
    {
        if (i%2 != 0)
           res = res + arr[i];
    }
    return res;
}
int [] arr2 = CreateRandomArray(6, 1, 10);
PrintArray(arr2);
int res2 = SumOddNumbers(arr2);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях =  {res2}");
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

double [] CreateRandomArray2(int n, int minVal, int maxVal)
{
 double [] arr = new double[n];
 for (int i = 0; i < n; i++) 
 {
    arr[i] = (new Random().Next(minVal, maxVal+1))+(new Random().Next(minVal, maxVal)*0.1) + (new Random().Next(minVal, maxVal)*0.01);

 }
 return arr;
}
void PrintArray2(double [] arr)
{   Console.Write($"[");
    for(int i = 0; i < arr.Length; i++)
      Console.Write($"{arr[i]}, ");
       Console.WriteLine($"\b\b]");  
}

double ElementDifference(double [] arr)
{   
    double res = 0;  
    double max = arr[0];
    double min = arr[0];  
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]>max)
            max = arr[i];
        if (arr[i]<min)
            min = arr[i];
    }
    res = max - min;
    return res;
}


double [] arr3 = CreateRandomArray2(6, 0, 10);
PrintArray2(arr3);

Console.WriteLine($"разницу между максимальным и минимальным элементов массива =  {ElementDifference(arr3)}");