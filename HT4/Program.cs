/* 60 трехмерный массив из неповторяющихся двузначных чисел. Построчно выводить массив добавляя индексы каждого элемента */


void Matrix3D(int[,,] matrix3D)
{
    int number = 10;
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
                matrix3D[i, j, k] = number++;
        }
    }
}

void PrintMatrix3D(int[,,] matrix3D)
{
    for (int i = 0; i < matrix3D.GetLength(0); i++)
    {
        for (int j = 0; j < matrix3D.GetLength(1); j++)
        {
            for (int k = 0; k < matrix3D.GetLength(2); k++)
                Console.Write($"{matrix3D[i, j, k]}({i},{j},{k})" + " ");
        }

    }
}

Console.Clear();
Console.Write("Ведите размеры массива: ");
int[] size = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
int[,,] matrix3D = new int[size[0], size[1], size[2]];
Matrix3D(matrix3D);
PrintMatrix3D(matrix3D);
Console.WriteLine();

