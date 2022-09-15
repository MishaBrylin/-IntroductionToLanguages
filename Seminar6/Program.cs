
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// int Pack1(int M)
// {
//  int [] arr = new int[M];
//  int res = 0;
//  for (int i = 0; i < M; i++) 
//  {
//     Console.WriteLine($"Укажите число номер {i+1}");
//     arr[i] = Convert.ToInt32(Console.ReadLine());
//         if (arr[i]>0)
//             res++;
//  }
//  return res;
// }



// Console.WriteLine("Укажите количество чисел в вашем массиве");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Количество чисел больше 0 в вашем массиве  {Pack1(M)}");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем. 
// ( x = (b1-b2)/ (k1- k2), у = (b1-b2)*k1/ (k1- k2) + b1 )

void Pack2(double b1, double k1, double b2, double k2)
{
    double x = (b2-b1)/ (k1- k2);
    double y = ((b2-b1)*k1)/ (k1- k2) + b1;
    Console.WriteLine($"Кординаты пресечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2 ({x};{y})");

}

Console.WriteLine("Задайте значения для уравленией прямых y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Значение k1 = ");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение b1 = ");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение k2 = ");
double k2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Значение b2 = ");
double b2 = Convert.ToInt32(Console.ReadLine());

Pack2(b1, k1, b2, k2);