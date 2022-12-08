// task38

Console.WriteLine("Введите размер массива ");
int n = Convert.ToInt32(Console.ReadLine());
double [] numbers = new double [n];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
double max = numbers[0];
double min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers [i] > max)
        {
            max = numbers[i];
        }
    if (numbers [i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

