// Задача 29: Напишите метод, который формирует массив из 8 случайных элементов и выводит их на экран.

using static System.Console;
Clear();
int[] array = getArray(15);
printArray(array);






int[] getArray(int length)
{
    int[] result = new int[length];
    for (int i = 0; i < length; i++)
    {
     result[i] = new Random().Next(-100,101);
    
    }
    return result;
}

void printArray(int[] array3)
{
    string FinalString = "[ ";
    foreach (int item in array3)
    {
        FinalString+=$"{item} ";
    }
    FinalString += "]";
    WriteLine(FinalString);
}
