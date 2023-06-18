﻿// ____________________Задача 64_________________________ 
// Задайте значение N. Напишите программу, 
// которая выведет все натуральные числа в промежутке 
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int startNum = 1;

// Console.WriteLine(PrintNumbers(num, startNum));

// string PrintNumbers(int num1, int num2)
// {
//     if (num1 == num2)
//     {
//         return num1.ToString();
//     }
//     return (num1 + ", " + PrintNumbers(num1 - 1, num2));
// }



﻿// ___________________________Задача 66__________________ 
// Задайте значения M и N.
//  Напишите программу, которая найдёт сумму 
//  натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// Console.Write("Введите число M = ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число N = ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Сумма элементов от {num1} до {num2} = {SumNum(num1, num2)}");

// int SumNum(int num1, int num2)
// {
//     if (num1 == num2)
//         return num2;
//     return num2 + SumNum(num1, num2 - 1);
// }


// _______________________________Задача 68_______________________________ 
// Напишите программу вычисления 
// функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите положительное число m= ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите положительное число n= ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write(Akkerman(num1, num2));

int Akkerman(int num1, int num2)
{
    if (num1 == 0)
    {
        return num2 + 1;
    }
    else if (num2 == 0 && num1 > 0)
    {
        return Akkerman(num1 - 1, 1);
    }
    else
    {
        return (Akkerman(num1 - 1, Akkerman(num1, num2 - 1)));
    }
}