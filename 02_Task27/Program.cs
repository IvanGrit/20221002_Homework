// Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;
Clear();
WriteLine("Введите число ");
int a = int.Parse(ReadLine()!);

WriteLine($"Сумма цифр в числе {a} составляет {SumOfNumbers(a)}");



int SumOfNumbers(int num)
{
    int sum = num%10;
    int i = 10;
    while(num/i !=0)
    {
        sum += num/i%10;
        i = i*10;
    }
    return sum;
}

