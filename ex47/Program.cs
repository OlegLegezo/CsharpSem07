// Задача 48: Задайте двумерный массив размера m на n,
// каждый элемент в массиве находится по формуле: Aₙₙ = m+n.
// Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

Console.Write("введите кол-во строк: ");
int m = int.Parse(Console.ReadLine());
Console.Write("введите кол-во столбцов: ");
int n = int.Parse(Console.ReadLine());


int[,] GetArray(int row, int col)//метод заполнения массива
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
        }
    }
    return array;
}


void PrintArray(int[,] array) //метод печати массива
{
    for (int i = 0; i < array.GetLength(0); i++)//0-строки
    {
        for (int j = 0; j < array.GetLength(1); j++)//1-строки
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] arrayres = GetArray(m, n);
PrintArray(arrayres);