using System;

class Viagem
{
	private double distancia;
	private double tempo;

	public void SetDistancia(double d){
		distancia = d;
	}

	public void SetTempo(double t){
		tempo = t;
	}

	public double GetDistancia(){
		double d = distancia;
		return d;
	}

	public double GetTempo(){
		double t = tempo;
		return t;
	}

	public double VelocidadeMedia(){		
		double Vm = distancia/tempo;
		return Vm;
	}
}

class MainClass
{
	public static void Main()
	{
		Console.Write("Distância: ");
		double d = double.Parse(Console.ReadLine());
		Console.Write("Tempo: ");
		double t = double.Parse(Console.ReadLine());
	
		Viagem Vi = new Viagem();
		Vi.SetDistancia(d);
		Vi.SetTempo(t);

		Console.Write("Velocidade Média: ");
		Console.WriteLine(Vi.VelocidadeMedia()+" km/h");
	}
}