using System;

class MainClass
{
	public static void Main(){
		string[] entrada = Console.ReadLine().Split(" ");
		int n1 = int.Parse(entrada[0]);
		int n2 = int.Parse(entrada[1]);
		int n3 = int.Parse(entrada[2]);
		int n4 = int.Parse(entrada[3]);
		int n5 = int.Parse(entrada[4]);		

		if(n1<n2 && n2<n3 && n3<n4 && n4<n5){
			Console.WriteLine('C');
		}
		else if (n1>n2 && n2>n3 && n3>n4 && n4>n5){
			Console.WriteLine('D');
		}
		else{
			Console.WriteLine('N');
		}
	}
}
