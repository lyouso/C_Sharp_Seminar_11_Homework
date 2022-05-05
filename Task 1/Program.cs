// На вход подаются два числа n и m, такие, что n<m. Заполните массив случайными числами из промежутка [n, m].

Console.WriteLine("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Random rand = new Random();
int[] array = new int[5];

if (n < m)
{
    PrintArray(array);
}
else if (n > m)
{
    Console.WriteLine("Число " + n + " больше числа " + m + ".");
}
else
{
    Console.WriteLine("Введенные числа равны.");
}


void PrintArray(int[] array)
{
    Console.WriteLine("Полученный массив: ");
    for (int i = 0; i < array.Length; i ++)
    {
        array[i] = rand.Next(n, m+1);
        Console.Write($"{array[i]} ");
    }
}
