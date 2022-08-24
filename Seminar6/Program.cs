// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел
// больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
/*
void ShowArray(double[] array)
{
    for (double i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
double[] FillArray(double M)
{
    double[] array = new double[M];
    for (double i = 0; i < array.Length; i++)
    {
        Console.Write($"Введи {i + 1} - число: ");
        array[i] = Convert.Todouble32(Console.ReadLine());
    }

    return array;
}
double NumberCounter(double[] array)
{
    double count = 0;
    for (double i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }

    return count;
}

Console.Write("Введи сколько будет чисел: ");
double num = Convert.Todouble32(Console.ReadLine());
double[] MyArray = FillArray(num);
ShowArray(MyArray);
Console.WriteLine($"Количество чисел больше нуля: {NumberCounter(MyArray)}");
*/

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
// заданных уравнениями
// y = k1 * x + b1, 
// y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Уж простите, Паавел, но эта задача без метода.
//

Console.Write("Введи b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введи k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

double x = (b2 - b1)/(k1 - k2);
double y = k1*x + b1;
Console.WriteLine($"Точка пересечения: ( {x} ; {y} )");
