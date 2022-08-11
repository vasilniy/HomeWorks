// Задача 10: Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
/*
int ShowSecondDigit (int number)
{
    number = number / 10;
    number = number % 10;
    return number;
}

Console.Write("Веедите 3-х значное число: ");

int num = Convert.ToInt32(Console.ReadLine());

Console.Write($"Вторая цифра числа {num} = {ShowSecondDigit(num)}");
*/


// Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int FindThirdDigit(int number)
{
    int count = 0;
    int num = number;

    while (number != 0)
    {
        number = number / 10;
        count++;
    }

    while(num != 0)
    {
        if ((count - 3) == 0) number = num % 10;                    
        
        num = num / 10;
        count--;
    }
    if (number < 0) number = number * -1;
    return number;
}

void ShowThirdDigit(int number)
{
    if ((number / 100) == 0)
    {
        Console.Write($"Вы ввели число = {number} - Третьей цифры нет!");
    }
    else
    {
        Console.Write($"Вы ввели число = {number} - Третья цифра = {FindThirdDigit(number)}");
    }
}

Console.Write("Веедите число: ");

int num = Convert.ToInt32(Console.ReadLine());

ShowThirdDigit(num);



// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

/*
void DayOff(int number)
{
    if (number > 0 && number < 8)
    {
        if (number == 6 ^ number == 7) Console.WriteLine($"День недели: {number} - Выходной день!");
        else Console.WriteLine($"День недели: {number} - не выходной день.");
    }
    else Console.WriteLine($"{number} - такой день недели не существует!");
}

Console.Write("Веедите день недели цифрой от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());

DayOff(num);
*/