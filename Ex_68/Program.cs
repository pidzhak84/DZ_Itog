/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int getNumberM(string message)
{
    Console.Write(message);
    int M = int.Parse(Console.ReadLine()!);
    return M;
}
int numberM =getNumberM("Введите число M - "); 

int getNumberN(string message)
{
    Console.Write(message);
    int N = int.Parse(Console.ReadLine()!);
    return N;
}
int numberN =getNumberN("Введите число N - "); 

int AkkermanFunct(int numberM, int numberN)
{
    if (numberM ==0) return numberN+1;
    else if (numberN==0 && numberM >0) 
    {
        return AkkermanFunct (numberM-1, 1);
    }
    else if (numberM>0 && numberN >0) 
    {
    return  AkkermanFunct(numberM - 1, AkkermanFunct(numberM, numberN - 1));    
    }
    return AkkermanFunct (numberM, numberN);
}
int AkkermanRes = AkkermanFunct (numberM, numberN);
Console.WriteLine ($"Akkerman function from {numberM} and {numberN} equals {AkkermanRes}.");