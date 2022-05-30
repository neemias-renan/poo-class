using System;

class MainClass
{
	public static void Ordenar(int x, int y, int z)
	{
		int[] ordem = {0,0,0};
		ordem[0] = x;
		ordem[1] = y;
		ordem[2] = z;
		Array.Sort(ordem);

		Console.WriteLine(ordem[0]+" "+ordem[1]+" "+ordem[2]);
	}
	
	public static void Main()
	{
		int n1 = int.Parse(Console.ReadLine());
		int n2 = int.Parse(Console.ReadLine());
		int n3 = int.Parse(Console.ReadLine());
		Ordenar(n1,n2,n3);
	}

	
}