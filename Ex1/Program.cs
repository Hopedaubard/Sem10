// Задача 24: Напишите программу, которая принимает на вход число (А) и 
// выдаёт сумму чисел от 1 до А.

// 7 -> 28
// 4 -> 10
// 8 -> 36


Main();

void Main()
{
    int num = Promt();
    Console.WriteLine($"Сумма чисел от 1 до {num} равна: {GetSum(num)}");
}

int Promt()
{
    Console.WriteLine("Введите число");
    int limit = int.Parse(Console.ReadLine());
    return limit;
}

int GetSum(int limit)
{
    int sum = 0;
    for (int i = 1; i <= limit; i++)
    {
        sum = sum + i;
    }
    return sum;
}

