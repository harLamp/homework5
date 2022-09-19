// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int size = 20;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

void PrintArray(int[] arr)
{
    int sum = 0;
    Console.WriteLine();
    for (int i = 0; i < size; i++)
    {
        Console.Write(arr[i] + " ");
        if (i % 2 > 0) sum += arr[i];
    }
    Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {sum} ");
}

PrintArray(FillArray(size));