/*
Напишите метод, который задаёт массив из N элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

Console.Clear();

int[] CreateArray(int size)
{
    int[] arr = new int[size];

    Console.WriteLine("Вводите элементы массива : ");

    for (int i = 0; i < size; i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
}

Console.Write("Сколько элементов массива вы хотите ввести : ");
int elements = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArray(elements);
PrintArray(arr);