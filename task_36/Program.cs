// Задача 36: Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int[] arrayNumber = new int[number];

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 10);
    }
    Console.WriteLine(String.Join(",", arrayNumber));
}

void SumUneven(int[] array)
{
    int sum = 0;

    for(int i = 1; i < array.Length; i+=2)
    {       
        sum += array[i];
    }
    Console.WriteLine(sum);
}


FillArray(arrayNumber);
SumUneven(arrayNumber);
