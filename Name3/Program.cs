Console.Clear();
Console.WriteLine("Введите координату вершины треугольника x1: ");
double x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату вершины треугольника y1: ");
double y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату вершины треугольника x2: ");
double x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату вершины треугольника y2: ");
double y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату вершины треугольника x3: ");
double x3 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату вершины треугольника y3: ");
double y3 = Convert.ToInt32(Console.ReadLine());

double S = Math.Abs((x2-x1)*(y3-y1) - (x3-x1)*(y2-y1)) / 2;


Console.WriteLine($"Площадь треугольника: {S}");

