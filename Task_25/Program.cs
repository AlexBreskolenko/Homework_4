/*
Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Math.Pow использовать нельзя
3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.Clear();

int DegreOfNumber(int number, int degree)
{
    int result = 1;

    for(int i = 0; i < degree; i++)
    {
        result *= number;
    } 
    
    return result;
}

Console.Write("Введите число : ");
int num = int.Parse(Console.ReadLine());

Console.Write("Введите степень : ");
int degree = int.Parse(Console.ReadLine());

int result = DegreOfNumber(num, degree);

Console.WriteLine(result);

