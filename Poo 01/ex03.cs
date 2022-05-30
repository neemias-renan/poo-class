// A classe deve ter atributos para armazenar a distância em km
// e o tempo gasto em horas e minutos da viagem
// realizada.
// A classe deve possuir método para calcular
// a velocidade média atingida na viagem em km/h de acordo
// com a distância e o tempo gasto.
	
using System;

class Viagem
{
	public int distancia;
	public int tempo;

	public int VelocidadeMedia()
	{		
		int Vm  = distancia/tempo;
		
		return Vm;
	}
}

class MainClass
{
	public static void Main()
	{
		int d = int.Parse(Console.ReadLine());
		int t = int.Parse(Console.ReadLine());
	
		Viagem Vi = new Viagem();
		Vi.distancia  = d;
		Vi.tempo = t;
		Console.WriteLine(Vi.VelocidadeMedia());
	}
}