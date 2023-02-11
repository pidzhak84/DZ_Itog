/*
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int getNumberFromUser(string message)
{
    Console.Write(message);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}
int N = getNumberFromUser("Введите значение N - "); 
  

void outputNumberFrom(int N)  
    { 
        if (N == 0) return;
        else
        Console.Write($"{N} ");

        outputNumberFrom(N - 1);  
    } 
outputNumberFrom(N);