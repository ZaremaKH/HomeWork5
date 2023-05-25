// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int InputData()
{
    
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SearchEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}


Console.Write("Введите количество элементов массива: ");
int elementsArray = InputData();
int[] array = new int[elementsArray];
FillArray(array);
Console.Write("Вывод массива: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве = {SearchEvenNumbers(array)}");