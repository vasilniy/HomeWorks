//Задача 64: Задайте значения M и N. Напишите программу, которая выведет
// все натуральные числа в промежутке от M до N.
// M = 1; N = 5. -> ""1, 2, 3, 4, 5""
// M = 4; N = 8. -> ""4, 6, 7, 8""
// Эту задачу Вы просили не делать, так как мы ее делали с группой в залах.


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт
// сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
/*
int SumOfNaturalNumbers(int M, int N)
{   
    if(N >= M) return SumOfNaturalNumbers(M, N -1) + N;
    
    return 0;
}

Console.Write("Введите минимальное значение: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SumOfNaturalNumbers(m, n));
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

/*
int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return Akkerman(m - 1, 1);

    return Akkerman(m - 1, Akkerman(m, n - 1));
}

int A = Akkerman (3 ,2);
Console.WriteLine(A);
*/