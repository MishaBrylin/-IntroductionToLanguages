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
            for (int n = j, x = 0; n < array.GetLength(1); n++)
                if (newSortArray[i, j] < array[i, n])
                {
                    x = newSortArray[i, j];
                    newSortArray[i, j] = array[i, n];
                    array[i, n] = x;
                }
            {
            }
        }


    }

    return newSortArray;

}
int[,] Array = CreateRandom2dArray();

Show2dArray(Array);
Show2dArray(SortElements2dArray(Array));


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int MinSumElementsRow(int[,] array)
{

    int sum = 0;
    int row = 0;
    int minSumRow = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {


        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            if (i == 0)
                minSumRow = sum;
            if (minSumRow > sum && j == array.GetLength(1) - 1)
            {
                minSumRow = sum;
                row = i;

            }
        }

    }
    return row + 1;
}
int[,] Array2 = CreateRandom2dArray();
Show2dArray(Array2);

Console.WriteLine($"The row with the smallest sum of elements: {MinSumElementsRow(Array2)}");


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

void MatrixMultiplication(int[,] array, int[,] array2)
{

    if (array.GetLength(0) != array2.GetLength(1))
        Console.WriteLine("Matrices cannot be multiplied");

    else

    {
        int[,] newSortArray = new int[array.GetLength(0), array2.GetLength(1)];
        for (int i = 0; i < array.GetLength(0); i++)
        {


            for (int n = 0; n < array2.GetLength(1); n++)
            {
                int res = 0;
                for (int j = 0; j < array.GetLength(0); j++)
                {

                    res = res + array[i, j] * array2[j, n];
                    if (j == array.GetLength(0) - 1)
                        Console.Write(res + " ");
                }
            }

            Console.WriteLine();
        }

        Console.WriteLine();
    }
}

int[,] Matrix1 = CreateRandom2dArray();
int[,] Matrix2 = CreateRandom2dArray();
Show2dArray(Matrix1);
Show2dArray(Matrix2);
MatrixMultiplication(Matrix1, Matrix2);
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
int[,,] CreateRandom3dArray()
{
    Console.Write("Imput numbers of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput numbers of columns ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput depth of the array ");
    int depth = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Imput max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,,] newArray = new int[rows, columns, depth];

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            for (int n = 0; n < depth; n++)
                newArray[i, j, n] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}

void Show3dArray(int[,,] array)
{
    for (int n = 0; n < array.GetLength(2); n++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                Console.Write(array[i, j, n] + " ");

            Console.WriteLine();
        }
        Console.WriteLine();
    }
    Console.WriteLine();

}
int[,,] Array3 = CreateRandom3dArray();
Show3dArray(Array3);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.  (Не нашел решения)

// int[,] CreateSpiralArray()
// {
//     Console.Write("Imput numbers of rows: ");
//     int rows = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Imput numbers of columns ");
//     int columns = Convert.ToInt32(Console.ReadLine());


//     int[,] newArray = new int[rows, columns];
//     int j = 0;
//     int i = 0;
//     int n = 0;
//     int number = 1;
//     if (n <= rows * columns)
//     {
//         if (j < columns - n)
//         {
//             newArray[i, j] = number;
//             number++;
//             j++;
//         }
//         if (i < rows - n)
//         {
//             newArray[i, j] = number;
//             number++;
//             i++;
//         }
//         if (j > 0 + n)
//         {
//             newArray[i, j] = number;
//             number++;
//             i--;
//         }
//         n++;
//         if (i > 0 + n)
//         {
//             newArray[i, j] = number;
//             number++;
//             i--;
//         }
//     }


//     return newArray;
// }
// int[,] Array4 = CreateSpiralArray();
// Show2dArray(Array4);
