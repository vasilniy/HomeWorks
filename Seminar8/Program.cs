// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
// В итоге получается вот такой массив:
//    7 4 2 1
//    9 5 3 2
//    8 4 4 2
/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
void Show2dArray(int[,] array) // Вывод 2-мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[,] OrderElementsDescending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            int minpos = 0;
            for (int x = 1; x < array.GetLength(1); x++)
            {
                if (array[i, x] < array[i, minpos]) minpos = x;

                int temp = array[i, x];
                array[i, x] = array[i, minpos];
                array[i, minpos] = temp;
            }
        }
    }

    return array;
}

Console.Write("Введи количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(MyArray);
OrderElementsDescending(MyArray);
Show2dArray(MyArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

//    1 4 7 2
//    5 9 2 3
//    8 4 2 4
//    5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] CreateRandom2dArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] newArray = new int[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            newArray[i, j] = new Random().Next(minValue, maxValue + 1);

    return newArray;
}
void Show2dArray(int[,] array) // Вывод 2-мерного массива
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int FindMinRowSum(int[,] array)
{
    int rowMin = 0;
    int rowSum = 0;
    for (int j = 0; j < array.GetLength(1); j++)
        rowSum += array[0, j];
        Console.WriteLine($"{1} сумма строки  = {rowSum}");
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int summ = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summ += array[i, j];
        }
        Console.WriteLine($"{i + 1} сумма строки  = {summ}");
        if (summ < rowSum)
        {
            rowMin = i;
            rowSum = summ;
        }
        else 
            if (summ == rowSum) rowMin = -1;
    }

    return rowMin;
}

Console.Write("Введи количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи минимальное значение элемента массива: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи максимальное значение элемента массива: ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] MyArray = CreateRandom2dArray(m, n, min, max);
Show2dArray(MyArray);
int row = FindMinRowSum(MyArray);
if (row != -1) Console.WriteLine($"Строка с минимальной суммой элементов = {row + 1}");
else Console.WriteLine("В массиве есть одинковые строки с минимальной суммой");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет
// находить произведение двух матриц.
// Например, даны 2 матрицы:
//        2 4 | 3 4
//        3 2 | 3 3
// Результирующая матрица будет:
//        18 20
//        15 18
/*
int[,] MyArray1 = new int[,]
{
    {2, 4},
    {3, 2},
};
int[,] MyArray2 = new int[,]
{
    {3, 4},
    {3, 3},
};
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }    
}
int[,] MatrixMultiplication(int[,] arr1, int[,] arr2)
{
    int[,] arr3 = new int[arr1.GetLongLength(0), arr1.GetLength(1)];
    for (int i = 0; i < arr1.GetLongLength(0); i++)
    {       
        int sum = 0;
        for (int x = 0; x < arr1.GetLongLength(1); x++)
        {            
            for (int j = 0; j < arr1.GetLongLength(1); j++)
                sum += arr1[i, j] * arr2[j, x];
            arr3[i, x] = sum;
            sum = 0;
        }
    }
    
    return arr3;
}

Console.WriteLine("Даны 2 матрицы: ");
Show2dArray(MyArray1);
Console.WriteLine(" и ");
Show2dArray(MyArray2);
int[,] MyArray3 = MatrixMultiplication(MyArray1, MyArray2);
Console.WriteLine("Произведение двух матриц: ");
Show2dArray(MyArray3);
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
//                    66(0,0,0) 25(0,1,0)
//                    34(1,0,0) 41(1,1,0)
//                    27(0,0,1) 90(0,1,1)
//                    26(1,0,1) 55(1,1,1)

/*
int[,,] CreateRandom3dArray(int dimension1, int dimension2, int dimension3, int minValue, int maxValue)
{    
    int[,,] newArray = new int[dimension1, dimension2, dimension3];
    for (int x = 0; x < dimension1; x++)
        for (int y = 0; y < dimension2; y++)
            for (int z = 0; z < dimension3; z++)
                newArray[x, y, z] = new Random().Next(minValue, maxValue + 1) + new Random().Next(1, 3);

    return newArray;
}
void Show3dArray(int[,,] array)
{
    for (int x = 0; x < array.GetLength(0); x++)
    {
        for (int y = 0; y < array.GetLength(1); y++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
                Console.Write($"{array[x, y, z]}({x},{y},{z}) ");
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

Console.Write("Введи первое измерение: ");
int d1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе измерение: ");
int d2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье измерение: ");
int d3 = Convert.ToInt32(Console.ReadLine());

int[,,] MyArray = CreateRandom3dArray(d1, d2, d3, 10, 96);
Show3dArray(MyArray);
*/


// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//                        01 02 03 04
//                        12 13 14 05
//                        11 16 15 06
//                        10 09 08 07



