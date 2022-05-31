using System;

class Conversor
{
	private int num;

	public Conversor(int n){
		num = n;
	}

	public void SetNum(int n){
		num = n;
	}

	public int GetNum(){
		int n = num;
		return n;
	}

	public string Binario(){
		string bin = Convert.ToString(num, 2);
		return bin;
	}
 
	public override string ToString(){
    return num.ToString() + ":" + Binario();
  }
}

class MainClass
{
	public static void Main(){
		Console.Write("Digite um valor: ");
		int N = int.Parse(Console.ReadLine());

		Conversor con = new Conversor(N);
		Console.WriteLine(N+" em Binário é "+con.Binario());
	}
}