using System;

class Retangulo
{
	private double B;
	private double H;

	public Retangulo(double b, double h){
		B = b;
		H = h;
	}

	public void SetBase(double b){
		B = b;
	}

	public void SetAltura(double h){
		H = h;
	}

	public double GetBase(){
		double Base = B;
		return Base;
	}
	
	public double GetAltura(){
		double Altura = H;
		return Altura;
	}

	public double CalcArea(){
		double area = B*H;
		return area;
	}

	public double CalcDiagonal(){
		double diagonal = Math.Sqrt((B*B)+(H*H));
		return diagonal;
	}
 
	public override string ToString(){
    return B.ToString() + ":" + H.ToString();
  }
}

class MainClass
{
	public static void Main(){
		Console.Write("Digite a Base: ");
		double Base = double.Parse(Console.ReadLine());
		Console.Write("Digite a Altura: ");
		double Altura = double.Parse(Console.ReadLine());

		
		Retangulo re = new Retangulo(Base,Altura);
		Console.WriteLine("Area: "+re.CalcArea());
		Console.WriteLine("Diagonal: {0:00.0}",re.CalcDiagonal());
		Console.WriteLine(re);
	}
}