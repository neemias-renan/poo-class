// A classe deve ter atributos para armazenar :
// o nome da disciplina e 
// as notas dos quatros bimestres 
// e da prova final.

// Os métodos da classe devem permitir :
// calcular a média parcial (com as notas bimestrais) 
// e a média final (com todas as notas, caso o aluno tenha ficado em prova final).

// Considere como média de aprovação o valor 60, notas de 0 a 100
// média parcial ponderada com pesos 2, 2, 3 e 3 e 
// média final como a média aritmética da média parcial com a
// nota da prova final, caso o aluno não seja aprovado por média.

using System;

class Disciplina
{
	public string disciplina;
	public int notaB1, notaB2,notaB3,notaB4,notaProvafinal,mediap,mediapa,mediaf;

	public int mediaparcial(){
		mediap = ((notaB1*2)+(notaB2*2)+(notaB3*3)+(notaB4*3))/10;
		return mediap;
	}

	public int mediafinal(){
		mediapa = mediaparcial();
		mediaf = (mediapa+notaProvafinal)/2;
		return mediaf;
	}	
}

class MainClass
{
	public static void Main(){
		string disciplina = Console.ReadLine();
		int notaB1 = int.Parse(Console.ReadLine());
		int notaB2 = int.Parse(Console.ReadLine());
		int notaB3 = int.Parse(Console.ReadLine());
		int notaB4 = int.Parse(Console.ReadLine());
		int notaProvafinal = int.Parse(Console.ReadLine());

		Disciplina d1 = new Disciplina();
		d1.disciplina = disciplina;
		d1.notaB1 = notaB1;
		d1.notaB2 = notaB2;
		d1.notaB3 = notaB3;
		d1.notaB4 = notaB4;
		d1.notaProvafinal = notaProvafinal;

		Console.WriteLine(d1.mediaparcial());

		Console.WriteLine(d1.mediafinal());
	}
}