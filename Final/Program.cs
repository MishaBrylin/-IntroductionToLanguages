
string[] CreateArray()
{
    Console.Write("Imput number of elements in the array: ");
    int sizeArray = Convert.ToInt32(Console.ReadLine());

    string[] newArray = new string[sizeArray];

    for (int i = 0; i < sizeArray; i++)
        newArray[i] = Console.ReadLine();

    return newArray;
}

string[] array1 = CreateArray();
string[] array2 = new string[array1.Length];
void ArrayLessThanFour(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayLessThanFour(array1, array2);
PrintArray(array2);