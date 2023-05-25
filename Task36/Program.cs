// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int InputData()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int SumUnevenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}


Console.Write("Введите количество элементов массива: ");
int elementsArray = InputData();
int[] array = new int[elementsArray];
FillArray(array);
Console.Write("Вывод массива: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Сумма нечётных чисел в массиве = {SumUnevenNumbers(array)}");