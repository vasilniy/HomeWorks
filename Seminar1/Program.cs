//Задача 2: Напишите программу, которая на вход принимает
//          два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введи первое целое число: "); 
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе целое число: "); 
int b = Convert.ToInt32(Console.ReadLine());

int max = 0;

if (a > b)
{
    max = a;
}
else
{
    max = b;
}

Console.Write($"Максимальное число = {max}");
*/

//Задача 4: Напишите программу, которая принимает
//          на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введи первое целое число: "); 
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи второе целое число: "); 
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введи тертье целое число: "); 
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}

Console.Write($"Максимальное число = {max}");
*/

//Задача 6: Напишите программу, которая на вход принимает
// число и выдаёт, является ли число чётным
// (делится ли оно на два без остатка).
/*
Console.Write("Введи целое число: "); 
int a = Convert.ToInt32(Console.ReadLine());

int even = a % 2;

if (even == 0)
{
    Console.Write($"Ваше число = ({a}) - четное");
}
else
{
    Console.Write($"Ваше число = ({a}) - НЕ четное");
}
*/

// Задача 8: Напишите программу, которая на вход 
//           принимает число (N), а на выходе показывает
//           все чётные числа от 1 до N.
/*
Console.Write("Введи целое число: "); 
int n = Convert.ToInt32(Console.ReadLine());

int even = 0, count = 1;

Console.Write("Все четные числа: ");

while(count <= n)
{
    even = count % 2;
    if (even == 0)
    {
        Console.Write($"{count} ");
    }
    count++;
}
*/



// Проба, не обращайте внимание.
// Вспомнил задачу с 1 курса, делали на паскале.
// Задача моя. Вывести введенное целого числа наоборот
//             и поиск полиндрома
/*
Console.Clear();
Console.Write("Введи любое целое число, более 2-х знаков: "); 
int num = Convert.ToInt32(Console.ReadLine());

int num_int = 0, number_before = num, num2 = num;

while(num2 != 0)
{
    num_int = num_int * 10;
    num = num % 10;    
    num2 = num2 / 10;
    num_int = num_int + num;
    num = num2;        
}
if (number_before == num_int)
{
    Console.WriteLine($"Твое число {number_before} - полиндром, так как оно одинаково пишется туда и обратно");    
}
else
{
    Console.WriteLine($"Твое число = {number_before}, а запись его наоборот = {num_int}");
}
*/