void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 11);
        }
    }
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}


void ReleaseMatrix(int[,] matrix)
{
    int x = 0, y = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (x <= 0 || x >= matrix.GetLength(0) || y <= 0 || y >= matrix.GetLength(1))

                Console.WriteLine($"Такого элемента нет");
            else
                Console.WriteLine($"Позиция элемента: {matrix[x, y]}");
        }
    }
}

Console.Clear();
Console.Write("Введите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
Console.WriteLine("Введите номер строки:");
int x = Convert.ToInt32(Console.ReadLine()) + 1;
Console.WriteLine("Введите номер столбца:");
int y = Convert.ToInt32(Console.ReadLine()) + 1;
int[,] matrix = new int[size[0], size[1]];
InputMatrix(matrix);
Console.WriteLine("Начальный массив:");
PrintMatrix(matrix);
ReleaseMatrix(matrix);
