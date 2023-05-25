// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

int InputData()
{
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

void FillArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double SearchMaxNum(double[] array)
{
    double maxNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxNum)
        {
            maxNum = array[i];
        }
    }
    return maxNum;
}

double SearchMinNum(double[] array)
{
    double minNum = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNum)
        {
            minNum = array[i];
        }
    }
    return minNum;
}

// ниже решение нахождения разницы между максим и миним через один метод
// double SearhDiffMaxMin(double[] array)
// {
//     double maxNum = array[0];
//     double minNum = array[0];
//     for (int i = 1; i < array.Length; i++)
//     {
//         if (array[i] > maxNum)
//         {
//             maxNum = array[i];
//             Console.WriteLine($"Максимальное число = {maxNum}");
//         } 
//         if (array[i] < minNum)
//         {
//             minNum = array[i];
//             Console.WriteLine($"Минимальное число = {minNum}");
//         } 
//     }
//     Console.WriteLine($"Разница между ними = {maxNum-minNum}");
//     return maxNum-minNum;
// }


Console.Write("Введите количество элементов массива: ");
int elementsArray = InputData();
double[] array = new double[elementsArray];
FillArray(array);
Console.Write("Вывод массива: ");
PrintArray(array);
Console.WriteLine($"Максимальное число = {SearchMaxNum(array)}");
Console.WriteLine($"Минимальное число = {SearchMinNum(array)}");
Console.WriteLine($"Разница между макс. и мин. = {SearchMaxNum(array) - SearchMinNum(array)}");


// SearhDiffMaxMin(array); //вывод через один метод


