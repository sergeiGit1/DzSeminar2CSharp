// Напишите программу, которая на вход принимает число и
// выдаёт его квадрат (число умноженное на само себя).
// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49
Console.Write("Введите число для которого мы ищем квадрат: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number * number;
Console.WriteLine("квадрат от числа: " + number + " равен " + result);
