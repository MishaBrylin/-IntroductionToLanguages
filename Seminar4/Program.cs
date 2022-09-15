// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int MetodAB(int a, int b)
{	
	int res = 1;
	for (int i=1; i<=b; i++)
   		res = res*a;
    return res;
}

Console.WriteLine("введите число a");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("введите число b");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"число a в степени b = {MetodAB(a, b)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int Pack1(int x)
{
    int n = 1;
    while (x / n != 0)
        n = n * 10;
    n = n / 10;
    int res = 0;
 
    while (n >= 1)
    {
        res = res + (x / n) % 10;
        n = n / 10;
    }
    return res;
}

Console.WriteLine("введите число");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"сумма всех цифр в числе = {Pack1(x)}");


// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.WriteLine($"введите количество чисел в массиве");
int n = Convert.ToInt32(Console.ReadLine());
int [] CreateArray(int n)
{
 int [] arr = new int[n];
 for (int i = 0; i < n; i++) 
 {
	Console.WriteLine($"напишите цифру под номером {i+1}");
    arr[i] = Convert.ToInt32(Console.ReadLine());
 }
 return arr;
}

void PrintArray(int [] arr)
{   
	Console.WriteLine("Ваш массив: ");
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
        Console.Write($"{arr[i]}, ");
    Console.WriteLine("\b\b]");
}

PrintArray(CreateArray(n));
