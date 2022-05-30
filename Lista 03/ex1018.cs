using System;

class MainClass
{
	public static void Main()
	{
		int valor = int.Parse(Console.ReadLine());
		int valorcopia = valor;
		int n100 = 0, n50 = 0,n20 = 0,n10 = 0,n5 = 0, n2 = 0, n1 = 0;

		while(valor>0)
		{
			if(valor >= 100)
			{
				valor = valor-100;
				n100 = n100+1;
			}
			else if(valor >= 50 && valor < 100)
			{
				valor = valor-50;
				n50 = n50+1;
			}
			else if(valor >= 20 && valor < 50)
			{
				valor = valor-20;
				n20 = n20+1;
			}
			else if(valor >= 10 && valor < 20)
			{
				valor = valor-10;
				n10 = n10+1;
			}
			else if(valor >= 5 && valor < 10)
			{
				valor = valor-5;
				n5 = n5+1;
			}
			else if(valor >= 2 && valor < 5)
			{
				valor = valor-2;
				n2 = n2+1;
			}
			else if(valor >= 1 && valor < 2)
			{
				valor = valor-1;
				n1 = n1+1;
			}
			else
			{
				break;
			}
		}
		
		Console.WriteLine(valorcopia);
		Console.WriteLine("{0:0} nota(s) de R$ 100,00",n100);
		Console.WriteLine("{0:0} nota(s) de R$ 50,00",n50);
		Console.WriteLine("{0:0} nota(s) de R$ 20,00",n20);
		Console.WriteLine("{0:0} nota(s) de R$ 10,00",n10);
		Console.WriteLine("{0:0} nota(s) de R$ 5,00",n5);
		Console.WriteLine("{0:0} nota(s) de R$ 2,00",n2);
		Console.WriteLine("{0:0} nota(s) de R$ 1,00",n1);
	}
}
