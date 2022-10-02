// Задача 25: Напишите метод, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B с использованием цикла.

using static System.Console;
Clear();
WriteLine("Введите число A: ");
int a = int.Parse(ReadLine()!);
WriteLine("Введите число B: ");
int b = int.Parse(ReadLine()!);
WriteLine(RaseToDegree(a,b));





int RaseToDegree(int i, int j)
{
    int count = 1;
    int result = i;
    while (count < j)
    {
        result *= i;
        count++;
    }
    return result;
}