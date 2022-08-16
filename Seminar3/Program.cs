// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
/*
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

*/

// Задача 21/ Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// корень из (( x2 - x1 )2 + ( y2 - y1 )2 + ( z2 - z1 )2)
// A ( x1, y1, z1 ); B ( x2, y2, z2 )
// A ( 3,  6,   8 ); B (  2,  1, -7 ), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
/*
double FindDistance3d(double x1, double y1, double z1,
                      double x2, double y2, double z2)
{
    double dist = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));
    return dist;
}

Console.Write("Веедите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Веедите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Веедите z1: ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Веедите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Веедите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Веедите z2: ");
double z2 = Convert.ToDouble(Console.ReadLine());

Console.Write($"Расстояние между точками = {FindDistance3d( x1, y1, z1, x2, y2, z2 )}");
*/


//  Задача 23. Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
/*
void NumberCubed(int N)
{
    for( int i = 1; i <= N; i++)     
        Console.WriteLine($"{i}^3 = {Math.Pow(i, 3)}");    
}

Console.Write("Веедите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());
NumberCubed(number);
*/