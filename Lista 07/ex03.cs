using System;

class MainClass
{
	public static void Intervalo(double x)
	{
		
		int n1 = (int)x;
		Console.WriteLine("["+n1+", "+(n1+1)+"]");
	}
	
	public static void Main()
	{
		double n1 = double.Parse(Console.ReadLine());
		Intervalo(n1);
	}

	
}