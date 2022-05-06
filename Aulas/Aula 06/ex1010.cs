using System;

class ClassMain
{
    public static void Main()
    {
      string l1, l2;
			l1 = Console.ReadLine();
			l2 = Console.ReadLine();

			string[] linha1 = l1.Split();
			string[] linha2 = l2.Split();

			double soma = (double.Parse(linha1[1])*double.Parse(linha1[2]))+(double.Parse(linha2[1])*double.Parse(linha2[2]));

			Console.WriteLine("VALOR A PAGAR: R$ {0:0.00}",soma);
    }
}