// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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

int[,] SortElements2dArray(int[,] array)
{
    int[,] newSortArray = new int[array.GetLength(0), array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {
                for (int n = j; n < array.GetLength(1); n++)
                    if (newSortArray[i, j]< array[i, n])   
                        newSortArray[i, j] = array[i, n];
        {   
        }
}

        
    }

    return newSortArray;

}
int[,] Array = CreateRandom2dArray();

Show2dArray(Array);
Show2dArray(SortElements2dArray(Array));