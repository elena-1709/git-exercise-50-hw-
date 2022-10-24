// Напишите программу, которая на вход
// принимает позиции элемента в двумерном массиве, и
// возвращает значение этого элемента или же указание,
// что такого элемента нет

int[,] GettwoArray()
{
    int m = new Random().Next(10, 10);
    int n = new Random().Next(10, 10);
    int[,] inArray = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            inArray[i, j] = new Random().Next(0, 10);
        }
    }
    return inArray;
}

void PrinttwoArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}\t ");
        }
        Console.WriteLine();
    }
}

void FindNumIntwoArray(int[,] matrix, int number)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] == number)
            {
                Console.WriteLine($"{number} - указанный элемент в массиве есть");
                return;
            }
        }
    }
    Console.WriteLine($"{number} - указанного элемента в массиве нет");
}

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int[,] Arr = GettwoArray();
PrinttwoArray(Arr);
Console.WriteLine();
FindNumIntwoArray(Arr, number);