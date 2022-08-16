// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

void FindPalindrom(int number)
{
    int before_number = number;
    int after_namber = 0;

    while(number != 0)
    {
        after_namber = after_namber * 10;
        int number2 = number % 10;
        number = number / 10;
        after_namber = after_namber + number2;
    }

    if (before_number == after_namber)
        Console.WriteLine($"{before_number} = {after_namber} - Палиндром!");
    else   
        Console.WriteLine($"{before_number} и {after_namber} неравны - не Палиндром!");
}

Console.Write("Введите 5-значное число: ");
int num = Convert.ToInt32(Console.ReadLine());

FindPalindrom(num);







// Задача 21/ Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53







//  Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
