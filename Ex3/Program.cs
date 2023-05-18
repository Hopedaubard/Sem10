// Задача 28: Напишите программу, которая принимает на вход число 
// N и выдаёт произведение чисел от 1 до N.

//4 -> 24 
//5 -> 120

int GetNum(int number)
{
    int temp = 1;

    if (number > 0)
    {
        for (int i = 2; i <= number; i++)
        {
            temp *= i;
        }
        return temp;
    }
    else if (number < 0)
    {
        for (int i = number; i <= -1; i++)
        {
            temp *= i;
        }
        return temp;
    }
    else
    {
        return 0;
    }
}

int Promt()
{
    Console.Write("Введите число: ");
    int userNum = int.Parse(Console.ReadLine());
    return userNum;
}

int num = Promt();
Console.WriteLine($"Произведение чисел от 1 до {num}: {GetNum(num)}");