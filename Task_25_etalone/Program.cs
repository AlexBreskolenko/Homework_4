/*
Задача 25: Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Math.Pow использовать нельзя
3, 5 -> 243 (3⁵)

2, 4 -> 16
*/

Console.Clear();

//Метод принимает сообщение о вводе и возвращает число
int Prompt(string message)
{
    Console.Write(message);                      // Выводит приглашение к вводу
    string readInput = Console.ReadLine();       // Вводим значение
    int result = int.Parse(readInput);           // Приводим к числу
    return result;                               // Возвращаем результат
}

//Метод возводит число в степень(принимает число и степень возведения)
int Power(int powerBase, int exponent)
{
    int power = 1;

    for(int i = 0; i < exponent; i++)
    {
        power *= powerBase;
    }

    return power;
}

//Метод для проверки на ввод числа меньше 0
bool ValidExponent(int exponent)
{
    if(exponent < 0)
    {
        Console.WriteLine("Показатель не должен быть меньше нуля.");
        return false;
    }
    return true;
}

int powerBase = Prompt("Введите число : ");
int exponent = Prompt("Введьте экспонент : ");

if(ValidExponent(exponent))
{
    Console.WriteLine($"Число {powerBase} в степени {exponent} равно {Power(powerBase, exponent)}");
}


