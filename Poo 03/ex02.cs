using System;

class Frete
{
	private double distancia;
	private double peso;

	public Frete(double d, double p)
	{
		distancia = d;
		peso = p;
	}

	public void SetDistancia(double d)
	{
		distancia = d;
	}

	public void SetPeso(double p)
	{
		peso = p;
	}

	public double GetDistancia()
	{
		double d = distancia;
		return d;
	}

	public double GetPeso()
	{
		double p = peso;
		return p;
	}

	public double CalcFrete()
	{
		double frete = 0.01*distancia*peso;
		return frete;
	}
	
	public override string ToString() {
	    return $"Distancia = {distancia} km, Peso = {peso} kg";
  }
	
}

class MainClass
{
	public static void Main()
	{
		Frete f = new Frete(100,10);
		Console.WriteLine(f);
    Console.WriteLine(f.GetDistancia());
    Console.WriteLine(f.GetPeso());
    Console.WriteLine(f.CalcFrete());
    f.SetDistancia(150);
    Console.WriteLine(f);
    Console.WriteLine(f.CalcFrete());
	}
}