// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] SumArr(int[] array1, int[] array2)
{
    int[] resArray = new int[array1.Length];
    for (int i = 0; i < resArray.Length; i++)
    {
        resArray[i] = array1[i] + array2[i];
    }
    return resArray;
}

int[] RandArr(int num)
{
    int[] array = new int[num];
    for (int i = 0; i < num; i++)
    {
        array[i] = new Random().Next(0, 2);
    }
    return array;
}

void PrintArr(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($" [{array[i]}] ");
    }
    Console.WriteLine();
}

const int lengthArr = 8;

int[] arr1 = RandArr(lengthArr);
int[] arr2 = RandArr(lengthArr);
PrintArr(arr1);
PrintArr(arr2);
PrintArr(SumArr(arr1, arr2));