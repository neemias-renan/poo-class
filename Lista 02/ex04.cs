using System;

class ClassMain
{
    public static void Main()
    {
        Console.WriteLine("Digite a base e a altura do retângulo ");
        double n1 = double.Parse(Console.ReadLine());
        double n2 = double.Parse(Console.ReadLine());
        double area = n1 * n2;
        double perimetro = (n1*2)+(n2*2);
        double diagonal  = Math.Sqrt(Math.Pow(n1, 2)+Math.Pow(n2,2));


        Console.WriteLine($"Área = {area:0.00} - Perímetro = {perimetro:0.00} - Diagonal = {diagonal:0.00}");
    }
}
