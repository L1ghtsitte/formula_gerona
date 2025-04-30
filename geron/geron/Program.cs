using System;

class Triangle
{
    private double[] storoni;

    public Triangle(double[] storoni)
    {
        this.storoni = storoni;
    }

    public double CalculateArea()
    {
        double a = storoni[0];
        double b = storoni[1];
        double c = storoni[2];

        if (a + b <= c || a + c <= b || b + c <= a)
        {
            Console.WriteLine("Треугольник с такими сторонами не существует.");
            return -1;
        }

        double p = (a + b + c) / 2;
        double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

        return area;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            double[] storonitreug = new double[3];
            for (int i = 0; i < storonitreug.Length; i++)
            {
                Console.Write($"введите {i + 1} строну треугольника: ");
                storonitreug[i] = Convert.ToDouble(Console.ReadLine());
            }
            Triangle triangle = new Triangle(storonitreug);
            double area = triangle.CalculateArea();
            if (area == -1)
                return;
            else
                Console.WriteLine($"Площадь треугольника: {area}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}