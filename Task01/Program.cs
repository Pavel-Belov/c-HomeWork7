// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

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

void ArrangeArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            int max = matr[i, j];
            int indexMax = j;

            for (int k = j + 1; k < matr.GetLength(1); k++)
            {
                if (matr[i, k] > max)
                {
                    max = matr[i, k];
                    indexMax = k;
                }
            }

            int temp = matr[i, j];
            matr[i, j] = matr[i, indexMax];
            matr[i, indexMax] = temp;
        }
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, columns];

FillArray(matrix);
PrintArray(matrix);
ArrangeArray(matrix);
Console.WriteLine("Получаем массив с упорядоченными по убыванию элементами каждой строки: ");
PrintArray(matrix);