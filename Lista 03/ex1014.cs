using System;

class MainClass
{
	public static void Main()
	{
		int distancia = int.Parse(Console.ReadLine());
		double combustivelgasto = double.Parse(Console.ReadLine());
		
		double consumomedio = distancia/combustivelgasto;
		
		Console.WriteLine("{0:0.000} km/l",consumomedio);
	}
}
