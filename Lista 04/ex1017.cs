using System;

class ClassMain
{
    public static void Main()
		{
			int tempoviagem = int.Parse(Console.ReadLine());
			int velocidademedia = int.Parse(Console.ReadLine());
			
			double distanciapercorrida = tempoviagem*velocidademedia;
			
			double consumomedio = distanciapercorrida/12;
			Console.WriteLine("{0:0.000}",consumomedio);
    }
}