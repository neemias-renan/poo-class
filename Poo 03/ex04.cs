using System;

class Equacao
{
	private double a;
	private double b;
	private double c;
	
	public Equacao(double A, double B, double C){
		a = A;
		b = B;
		c = C;
	}

	public void SetABC(double A, double B, double C){
		a = A;
		b = B;
		c = C;
	}

	public void GetABC(out double A, out double B, out double C){
		A = a;
		B = b;
		C = c;
	}

	public bool RaizesReais(out double x1, out double x2){
		x1 = (-b+Math.Sqrt(Delta()))/(2*a);
		x2 = (-b-Math.Sqrt(Delta()))/(2*a);
		
		double delta = Delta();
		if(delta < 0){
			return false;
		}
		else if(delta > 0){
			return true;
		}
		else{
			return true;
		}
	}
	
	public double Delta(){
		double delta = ((b*b)-(4*a*c));
		return delta;
	}
	
	
	public override string ToString(){
    return "(A: "+a.ToString() + ") (B: " + b.ToString() +") (C: "+c.ToString()+")";
  }
}

class MainClass
{
	public static void Main(){
		Equacao equa = new Equacao(1,-3,-10);

		equa.GetABC(out double A, out double B, out double C);

		
		Console.WriteLine("Delta: "+equa.Delta());

		if(equa.RaizesReais(out double x1, out double x2) == true){	
			Console.WriteLine("X¹: "+x1);
			Console.WriteLine("X²: "+x2);
		}

		Console.WriteLine(equa);

	}
}