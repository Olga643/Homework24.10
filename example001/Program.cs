// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А:");
int numberA = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Введите число B:");
int numberB = int.Parse(Console.ReadLine()??"");
int result = numberA;

for (int i = 1; i < numberB; i++)
{
    result = result * numberA; 
}

Console.WriteLine($"Число {numberA} в степени {numberB} = {result}");