using System;

class MainClass
{
	public static void Main()
	{
		string valores1 = Console.ReadLine();
		string valores2 = Console.ReadLine();
		
		string[] array_valores1 = valores1.Split(" ");
		string[] array_valores2 = valores2.Split(" ");


		double x1 = double.Parse(array_valores1[0]);
		double y1 = double.Parse(array_valores1[1]);

		double x2 = double.Parse(array_valores2[0]);
		double y2 = double.Parse(array_valores2[1]);
		
		double distancia = Math.Pow((Math.Pow((x2-x1),2))+((Math.Pow((y2-y1),2))),0.5);
		Console.WriteLine("{0:0.0000}",distancia);
	}
}
