using System;

class Circulo
{
	private double raio;

	public void SetRaio(double v){
		raio = v;
	}

	public double GetRaio(){
		double r = raio;
		return r;
	}
	
	public void calcArea(){
		double pi = 3.14;
		double area = (pi*(raio*raio));
		Console.WriteLine(area);
	}

	public void calcCircunferencia(){
		double pi = 3.14;
		double circunferencia = 2*pi*raio;
		Console.WriteLine(circunferencia);
	}
}

class MainClass
{
	public static void Main(){
		Console.Write("Digite o valor do Raio: ");
		double raio = double.Parse(Console.ReadLine());
		
		Circulo circ = new Circulo();
		circ.SetRaio(raio);
		
		Console.Write("Area: ");
		circ.calcArea();
		Console.Write("Circunferencia: ");
		circ.calcCircunferencia();
	}
}