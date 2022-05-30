using System;

class Circulo
{
	public int raio;

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
		Circulo circ = new Circulo();
		circ.raio = 15;
		circ.calcCircunferencia();
	}
}