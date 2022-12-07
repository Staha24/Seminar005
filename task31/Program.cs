// task31

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    array [i] = new Random().Next (-9, 10); //[-9; 9]
}

void ReleaseArray (int [] array)
{
    int sumNegative = 0; int sumPositive = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ( array[i] > 0)
        sumPositive += array[i];
        else
        sumNegative += array[i];
    }
    Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
    Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");
}

Console.Clear();
Console.Write("Введите количество элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray (array);
Console.WriteLine ($"[{string.Join(", ", array)}]");
ReleaseArray (array);
