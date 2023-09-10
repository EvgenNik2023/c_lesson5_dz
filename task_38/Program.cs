// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

double[] doubles = new double[number];

void FillArray(double[] array)
{
    for(int i = 0; i < doubles.Length; i++)
        {
            double randomNum = new Random().NextDouble() + new Random().Next(1, 20);
            doubles[i] = Math.Round(randomNum, 2);
        }

    Console.WriteLine(string.Join(", ", doubles));
}

double Max(double[] array)
{
    double max = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

double Min(double[] array)
{
    double min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

FillArray(doubles);
double minimum = Min(doubles);
double maximum = Max(doubles);
double result = maximum - minimum;
Console.WriteLine(minimum);
Console.WriteLine(maximum);
Console.WriteLine(Math.Round(result, 2));
