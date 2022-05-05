// Напишите рекурсивный метод, который принимает номер года и определяет, является ли он високосным или нет. 
// Постарайтесь воспользоваться только сложением или вычитанием.

Console.WriteLine("Введите номер года: ");
int year = Convert.ToInt32(Console.ReadLine());

if (year%400 == 0)
{
    Leap(year);
}
else if ((year% 4 == 0) && (year%100 != 0))
{
    Leap(year);
}
else Console.WriteLine("Не високосный");


void LeapYear(int currentYear)
{
    if (currentYear % 400 == 0)
    {
        Console.WriteLine("Год " + currentYear + " является високосным");
    }
    else if ((currentYear % 4 == 0) && (currentYear % 100 != 0))
    {
        Console.WriteLine("Год " + currentYear + " является високосным");
    }
    else
    {
        Console.WriteLine("Год " + currentYear + " не является високосным");
    }
}

void Leap(int currentYear)
{

        if (currentYear == 0)
        {
            Console.WriteLine("Високосный");
            return;
        }
        else if (currentYear < 0)
        {
            Console.WriteLine("Не високосный");
            return;
        }
        else
        {
            Leap(currentYear - 4);
        }


}
