﻿// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.WriteLine("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number>=1 && number<=7)
{
    if (number>=6)
    {
        Console.WriteLine("День "+ number + " является выходным");
    }
    else
    {
    Console.WriteLine("День "+ number+ " не является выходным");
    }
}
else
{
    Console.WriteLine("В неделе 7 дней");
}