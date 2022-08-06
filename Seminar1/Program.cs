
// Проба
// Задача моя. Запись введенного целого числа наоборот и поиск полиндрома
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