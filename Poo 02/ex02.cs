using System;

class Disciplina
{
	private string nome;
	private int nota1, nota2, nota3, nota4, notaFinal;

	public void SetNome(string s){
		nome = s;
	}
	
	public void SetNota1(int n){
		nota1 = n;
	}
	
	public void SetNota2(int n){
		nota2 = n;
	}
	
	public void SetNota3(int n){
		nota3 = n;
	}
	
	public void SetNota4(int n){
		nota4 = n;
	}
	
	public void SetNotaFinal(int n){
		notaFinal = n;
	}
	
	public string GetNome(){
		string n = nome;
		return n;
	}
	public int GetNota1(){
		int n = nota1;
		return n;
	}
	public int GetNota2(){
		int n = nota2;
		return n;
	}
	public int GetNota3(){
		int n = nota3;
		return n;
	}
	public int GetNota4(){
		int n = nota4;
		return n;
	}
	public int GetNotaFinal(){
		int n = notaFinal;
		return n;
	}
		
	public int CalcMediaParcial()
	{
		int mediap = ((nota1*2)+(nota2*2)+(nota3*3)+(nota4*3))/10;
		return mediap;
	}

	public int CalcMediaFinal()
	{
		int mediapa = CalcMediaParcial();
		int mediaf = (mediapa+notaFinal)/2;
		return mediaf;
	}	
}

class MainClass
{
	public static void Main(){
		Console.Write("Nome da Disciplina: ");
		string disciplina = Console.ReadLine();

		Console.Write("Nota do Primeiro Bimestre: ");
		int notaB1 = int.Parse(Console.ReadLine());

		Console.Write("Nota do Segundo Bimestre: ");
		int notaB2 = int.Parse(Console.ReadLine());

		Console.Write("Nota do Terceiro Bimestre: ");
		int notaB3 = int.Parse(Console.ReadLine());

		Console.Write("Nota do Quarto Bimestre: ");
		int notaB4 = int.Parse(Console.ReadLine());

		Console.Write("Nota da Prova Final: ");
		int notaProvafinal = int.Parse(Console.ReadLine());

		Disciplina d1 = new Disciplina();
		d1.SetNome(disciplina);
		d1.SetNota1(notaB1);
		d1.SetNota2(notaB2);
		d1.SetNota3(notaB3);
		d1.SetNota4(notaB4);
		d1.SetNotaFinal(notaProvafinal);
		
		Console.Write("Média Parcial: ");
		Console.WriteLine(d1.CalcMediaParcial());
		Console.Write("Média Final: ");
		Console.WriteLine(d1.CalcMediaFinal());
	}
}