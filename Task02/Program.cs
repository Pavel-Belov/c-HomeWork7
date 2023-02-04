// Написать программу, которая в двумерном массиве заменяет строки на столбцы 
// или сообщить, что это невозможно (в случае, если матрица не квадратная).

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] ArrangeArray(int[,] matr)
{
    int[,] arrangeMatr = new int[matr.GetLength(0), matr.GetLength(1)];
    
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            arrangeMatr[j, i] = matr[i, j];
        }
    }

    return arrangeMatr;
}

Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, columns];

FillArray(matrix);
PrintArray(matrix);

if(rows != columns)
{
    Console.WriteLine("Невозможно заменить строки на столбцы в данной матрице, так как она не квадратная.");
}
else
{
    int[,] arrangeMatrix = ArrangeArray(matrix);
    Console.WriteLine("Заменяем строки на столбцы и получаем получаем матрицу: ");
    PrintArray(arrangeMatrix);
}