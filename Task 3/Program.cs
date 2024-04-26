using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть координати точки А (x, y):");
        string[] inputA = Console.ReadLine().Split();
        double x0, y0;
        while (!double.TryParse(inputA[0], out x0) || !double.TryParse(inputA[1], out y0))
        {
            Console.WriteLine("Некоректні координати. Будь ласка, введіть числові значення.");
            inputA = Console.ReadLine().Split();
        }

        Console.WriteLine("Введіть координати точки В (x, y):");
        string[] inputB = Console.ReadLine().Split();
        double x1, y1;
        while (!double.TryParse(inputB[0], out x1) || !double.TryParse(inputB[1], out y1))
        {
            Console.WriteLine("Некоректні координати. Будь ласка, введіть числові значення.");
            inputB = Console.ReadLine().Split();
        }

        double distanceA = Math.Sqrt(x0 * x0 + y0 * y0);
        double distanceB = Math.Sqrt(x1 * x1 + y1 * y1);

        Console.WriteLine($"Відстань до точки A: {distanceA}");
        Console.WriteLine($"Відстань до точки B: {distanceB}");

        if (distanceA < distanceB)
        {
            Console.WriteLine($"Точка A({x0},{y0}) найменш віддалена від центру, ніж точка B({x1},{y1})!");
        }
        else if (distanceB < distanceA)
        {
            Console.WriteLine($"Точка B({x1},{y1}) найменш віддалена від центру, ніж точка A({x0},{y0})!");
        }
        else
        {
            Console.WriteLine("Точки A та B знаходяться на однаковій відстані від центру координат!");
        }
    }
}
