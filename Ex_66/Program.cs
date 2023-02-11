/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int getNumberM(string message)
{
    Console.Write(message);
    int M = Convert.ToInt32(Console.ReadLine());
    return M;
}
int numberM =getNumberM("Введите M - "); 

int getNumberN(string message)
{
    Console.Write(message);
    int N = Convert.ToInt32(Console.ReadLine());
    return N;
}
int numberN =getNumberN("Введите N - "); 

int getNumbersSum (int numberM, int numberN)
{
    while (numberM<0)
    {
        numberM++;
    }
    if (numberM>numberN) return 0;
    else
    return numberM+getNumbersSum(numberM+1, numberN);    
}
int Sum = getNumbersSum(numberM, numberN);
Console.WriteLine($"Сумма натуральных элементов в промежутке от {numberM} до {numberN} = {Sum}");