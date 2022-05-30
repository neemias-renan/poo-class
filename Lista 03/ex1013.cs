using System;

class MainClass
{
	public static void Main()
	{
		string valores = Console.ReadLine();
		string[] array_valores = valores.Split(" ");

		int a = int.Parse(array_valores[0]);
		int b = int.Parse(array_valores[1]);
		int c = int.Parse(array_valores[2]);
		
		int maiorAB = (a+b+Math.Abs(a-b))/2;
		int maiorAB_C  = (maiorAB+c+Math.Abs(maiorAB-c))/2;

		Console.WriteLine(maiorAB_C+" eh o maior");
			
	}
}