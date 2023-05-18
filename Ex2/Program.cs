// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

//456 -> 3
//78 -> 2
//89126 -> 5



int GetCount(int number)
{
    int count = 0;

    if (number != 0)
    {
        while (number > 0 || number < 0)
        {
            number /= 10;
            count++;
        }
        return count;
    }
    return 1;
}

int Promt()
{
    Console.Write("Введите число: ");
    int userNum = int.Parse(Console.ReadLine());
    return userNum;
}

int num = Promt();
Console.WriteLine($"Количество цифр в {num}: {GetCount(num)}");