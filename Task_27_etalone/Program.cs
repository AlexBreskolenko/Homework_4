/*
Задача 27: Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
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

//Метод складывает и возвраощает сумму цифр в числе
int SumNumber(int number)
{
    int result = 0;

    while(number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    return result;
}

int num = Prompt("Введите число : ");
Console.WriteLine($"Сумма всех цифр в числе {num} равна {SumNumber(num)}");