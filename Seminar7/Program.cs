// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
double[,] CreateRandom2dArrayDouble()
{
    Console.Write("Imput numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput numbers of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] newArray = new double[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1) + new Random().NextDouble();

    return newArray;
}

void Show2dArrayDouble(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(Math.Round(array[i, j], 2) + " ");

        Console.WriteLine();
    }

    Console.WriteLine();

}

double[,] myArray = CreateRandom2dArrayDouble();
Show2dArrayDouble(myArray);
// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
int[,] CreateRandom2dArray()
{
    Console.Write("Imput numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput numbers of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] newArray = new int[rows, columns];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }

    Console.WriteLine();

}

void ShowElementArray(int[,] array)
{
    Console.Write($"Imput row number from 1 to {array.GetLength(0)}: ");
    int rowNumber = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Imput column number from 1 to {array.GetLength(1)}: ");
    int columnNumber = Convert.ToInt32(Console.ReadLine());
    if (rowNumber <= array.GetLength(0) && columnNumber <= array.GetLength(1) && rowNumber > 0 && columnNumber > 0)
        Console.WriteLine($"Your element: {array[rowNumber - 1, columnNumber - 1]}");
    else
        Console.WriteLine("There are no such numbers");
}
int[,] Array = CreateRandom2dArray();
Show2dArray(Array);

ShowElementArray(Array);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
double[] ArithmeticMeanArray(int[,] array)
{
    double [] arr = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        
        for (int j = 0; j < array.GetLength(0); j++)
        {
            arr[i] = arr[i] + array[j, i];
                           
        }
    }
    return arr;
}

void PrintArray(double [] arr)
{   
    Console.WriteLine("The arithmetic mean of the elements in each column");
    Console.Write("[");
    for(int i = 0; i < arr.Length; i++)
      Console.Write($"{arr[i]}, ");
       Console.WriteLine($"\b\b]");  
}

Show2dArray(Array);

PrintArray(ArithmeticMeanArray(Array));