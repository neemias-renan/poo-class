using System;

class MainClass
{
	public static void Main()
	{
		Console.WriteLine(Maior(7,5));
	}

	public static double Maior(double x, double y)
	{
		if(x > y)
		{
			return x;
		}
		else
		{
			return y;
		}
	}
}