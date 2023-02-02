Console.Clear();
int[]array = new int [5];
for (int i=0; i<array.Length; i++)
array[i] = Convert.ToInt32(Console.ReadLine());
int summa = 0;
for (int i=0; i<array.Length; i++)
{
    if (array[i] > 0)
    {
    summa++;
    }
}

