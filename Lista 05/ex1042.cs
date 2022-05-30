using System;

class MainClass
{
	public static void Main()
	{
		string[] entrada = Console.ReadLine().Split(' ');
		int a = int.Parse(entrada[0]);
		int b = int.Parse(entrada[1]);
		int c = int.Parse(entrada[2]);

		int n1 = 0,n2=0,n3=0;
		
		if(a<b && a<c){
			n1 = a;
		}
		else if(b<a && b<c){
			n1 = b;
		}
		else{
			n1 = c;
		} 

		if(a>b && a>c){
			n3 = a;
		}
		else if(b>a && b>c){
			n3 = b;
		}
		else{
			n3 = c;
		}

		if((n1 == a && n3 == b) || (n1 == b && n3 == a)){
			n2 = c;
		}
		else if ((n1 == b && n3 == c)||(n1 == c && n3 == b)){
			n2 = a;
		}
		else if ((n1 == a && n3 == c)||(n1 == c && n3 == a)){
			n2 = b;
		}

		Console.WriteLine(n1);
		Console.WriteLine(n2);
		Console.WriteLine(n3);
		Console.WriteLine("");
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
		
	}
}