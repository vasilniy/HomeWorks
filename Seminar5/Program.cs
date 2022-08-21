// Задача 34: Задайте массив заполненный случайными положительными
// трёхзначными числами. Напишите программу, которая покажет количество
// чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int FindEvenNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0) 
        {
            count++;
            Console.WriteLine($"{count} - {array[i]}");// Для удобства сверки :)
        }
    return count;
}


Console.Write("Введи размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи мин. значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи макс. значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
Console.WriteLine($"Количество четных числе в массиве =  {FindEvenNumbers(myArray)}");
*/

// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int SumOfElementsInOddPositions(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
        if(i % 2 != 0) sum += array[i];
    return sum;    
}

Console.Write("Введи размер массива: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи мин. значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи макс. значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
Console.Write($"Суммма чисел на нечетных позициях = {SumOfElementsInOddPositions(myArray)}");
*/

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
