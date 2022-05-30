using System;

class MainClass
{
	public static void Main()
	{
		string nome = Console.ReadLine();
		double sal_f = double.Parse(Console.ReadLine());
		double total_v =  double.Parse(Console.ReadLine());

		double total = sal_f+(total_v * 0.15);
		Console.WriteLine("TOTAL = R$ {0:F2}",total);
	}
}