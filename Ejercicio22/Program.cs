using System;

class Program
{
    static void Main()
    {
        const double PI = 3.141592653589793;
        double radio = 5.0;
        double area = PI * Math.Pow(radio, 2);
        double perimetro = 2 * PI * radio;

        Console.WriteLine("Área: " + area);
        Console.WriteLine("Perímetro: " + perimetro);
    }
}
