// В прямоугольной матрице найти строку с наименьшей суммой элементов.

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

int[] ArraySum(int[,] matr)
{
    int[] arraySum = new int[matr.GetLength(0)];

    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            sum += matr[i, j];
        }
        arraySum[i] = sum;
    }

    return arraySum;
}

void PrintSum(int[] arraySum)
{
    for (int i = 0; i < arraySum.GetLength(0); i++)
    {
        Console.WriteLine($"Строка {i}. Сумма элементов равна {arraySum[i]}");
    }
}

int[] SearchMin(int[] arraySum)
{
    // Создём массив, куда будем записывать минимальные суммы в строках,
    // Если сумма не является минимальной, то не учитываем её и записываем -1
    // В дальнейшем это будет использовано в методе PrintMin()
    // для вывода в консоль строки(строк) с минимальной суммой
    // Так как индекса -1 в массиве не существует, то выводятся только нужные строки
    int[] arrayMin = new int[arraySum.Length];
    for (int i = 0; i < arrayMin.Length; i++)
    {
        arrayMin[i] = -1;
    }

    // Ищем минимально возможную сумму
    int min = arraySum[0];
    int indexMin = 0;
    for (int i = 1; i < arraySum.Length; i++)
    {
        if (arraySum[i] < min)
        {
            min = arraySum[i];
            indexMin = i;
        }
    }

    // Ищем, если ли ещё строки с такой же минимальной суммой
    for (int i = 0; i < arraySum.Length; i++)
    {
        if (arraySum[i] == min)
        {
            arrayMin[i] = i;
        }
    }

    return arrayMin;
}

void PrintMin(int[] arrayMin)
{
    for (int i = 0; i < arrayMin.Length; i++)
    {
        if (arrayMin[i] != -1) Console.WriteLine($"Строка {i}");
    }
}

Console.Write("Введите количество строк двумерного массива: ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов двумерного массива: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] matrix = new int[rows, columns];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

int[] arraySum = ArraySum(matrix);
PrintSum(arraySum);
Console.WriteLine();

int[] arrayMin = SearchMin(arraySum);
Console.WriteLine($"Строки с наименьшей суммой элементов:");
PrintMin(arrayMin);