// Двумерный массив заполнен случайными натуральными числами от 1 до 10. 
// Найдите количество элементов, значение которых больше 5, и их сумму.

Random rand = new Random();
int[,] array = new int[3, 4];
FillArray(array);
PrintArray(array);
FindAmountAndSum(array);

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rand.Next(1, 11);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void FindAmountAndSum(int[,] array, int count = 0, int sum = 0)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] > 5)
            {
                count++;
                sum += array[i, j];
            }
        }
    }
    Console.WriteLine("Количество элементов со значением больше 5 равно: " + count);
    Console.WriteLine("Сумма этих элементов равна " + sum);
}

