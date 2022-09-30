// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void ShowNumbersDiap(int n, int m)
{
    
    
    if (Math.Max(n,m) != Math.Min(n,m))
        ShowNumbersDiap(Math.Max(n,m)-1, Math.Min(n,m));
        Console.Write($"{Math.Max(n,m)} "); 
       
        
}
Console.Write("Imput numbers n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Imput numbers m: ");
int m = Convert.ToInt32(Console.ReadLine());

ShowNumbersDiap(n, m);
Console.WriteLine();
// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int ShowSum(int m, int n)
{ 
  
  if (m < n+1) return  m+ShowSum(m+1, n);
  else
    return 0;  
}


Console.WriteLine(ShowSum(1,15));

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int AckermanFunction(int m, int n)

{
    if (m == 0) return n + 1;
    if (m != 0 && n == 0) return AckermanFunction(m - 1, 1);
    if (m > 0 && n > 0) return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
return AckermanFunction(m, n);
}

Console.WriteLine(AckermanFunction(3,2));

