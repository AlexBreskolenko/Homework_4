/*
Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
Console.Clear();

int SumNumbers(string num)
{
    int result = 0;
    
    for(int i = 0; i < num.Length; i++)
    {
        result += Convert.ToInt32(num[i] - '0');
    }
    
    return result;
}

Console.Write("Введите число : ");
string num = Console.ReadLine();

int result = SumNumbers(num);

Console.WriteLine(result);
