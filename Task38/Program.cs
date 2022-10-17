// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2


double[] CreateArray(int size, int min, int max)
{
    double[] array = new double[size];
    var rnd = new Random();
    for (int i = 0; i < size; i++)
    {
        double num = rnd.NextDouble()*(max-min)+min;
        array[i] = Math.Round(num, 2);
    }
    return array;
}

void PrintArray(double[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.Write("]");
}

double FindMax(double[] array)  //находим максимальный элемент массива
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

double FindMin(double[] array)  //находим минимальный элемент массива
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}


double[] arr = CreateArray(5, 0, 100);
PrintArray(arr);
double maxNumber = FindMax(arr);
double minNumber = FindMin(arr);
double diff = maxNumber - minNumber;
double diffMaxMin = Math.Round(diff, 2, MidpointRounding.ToZero);
Console.Write($" -> {diffMaxMin}");