using System;

class MainClass
{
	public static void Main()
	{
		string[] l1 = Console.ReadLine().Split(" ");
	  string[] l2 = Console.ReadLine().Split(" ");

		int l = int.Parse(l1[0]);
		int d = int.Parse(l1[1]);
		
		int k = int.Parse(l2[0]);
		int p = int.Parse(l2[1]);

		int custototal = (l*k)+((l/d)*p);
		Console.WriteLine(custototal);
		

	}
}
