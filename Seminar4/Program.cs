// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

void NumberToThePower(int number, int rank)
{
    int a = number;
    for (int i = 1; i < rank; i++) number = number * a;
    Console.WriteLine($"Число {a} в степени {rank} = {number}");
}

Console.Write("Введи число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи степень: ");
int B = Convert.ToInt32(Console.ReadLine());

NumberToThePower(A, B);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
/*
void SumDigit(int number)
{
    int current = 0;
    int sum = 0;
    int num = number;
    while(number > 0)
    {
        current = number % 10;
        number = number /10;
        sum += current;
    }
    Console.WriteLine($"Сумма цифра числа {num} = {sum}");
}

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());

SumDigit(num);
*/

// Задача 29: Напишите программу, которая задаёт массив из 8
// элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
/*
int[] CreateArray(int number)
{
    int[] arr = new int[number];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введи {i + 1}-й элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }

    return arr;
}

void ShowArray(int[] array)
{
    Console.Write("[");
    for(int i = 0; i < array.Length; i++)
    if (i == array.Length -1) Console.Write($"{array[i]}");
    else Console.Write($"{array[i]}, ");
    Console.Write("]");
    Console.WriteLine();
}



Console.Write("Введи размер массива: ");
int num = Convert.ToInt32(Console.ReadLine());

int[] myarray = CreateArray(num);
ShowArray(myarray);
*/