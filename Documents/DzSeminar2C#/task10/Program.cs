﻿// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    number = number * -1;
}
if (number >= 100 && number <= 999)
{
    Console.WriteLine("Вторая цифра: " + (number % 100) / 10);
}
else
{
    Console.WriteLine("Число не является треххначным");
}
