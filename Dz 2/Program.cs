// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4


Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите искомое число");
int number = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
array(arr);
SearchNumber(number);
void array(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}
void SearchNumber(int number)
{
    int empty = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == number)
            {
                Console.WriteLine($"Число: {number} находится в ячейке строка {i+1} столбец {j+1} ");
                empty++;
            }
            if (empty == 0)
            {
                Console.WriteLine($"Число: {number} отсутствует в массиве {empty}");
            }
        }
    }

}

