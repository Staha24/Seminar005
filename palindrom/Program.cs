// task19
Console.Write("Введите число: ");
string? n = Console.ReadLine();
int newNumber = 0;
for (int i = n.Length - 1; i >= 0; i--)
{
    newNumber = newNumber + Convert.ToInt32(int.Parse(n[i].ToString())*Math.Pow(10,i));
} 
Console.WriteLine(newNumber);
if (newNumber == int.Parse(n))
Console.WriteLine("yes");
else
Console.WriteLine("no");
