using System;

class Pais
{
	private string nome;
	private int populacao;

	public Pais(string Nome, int Populacao)
	{
		if(Nome != ""){
			nome = Nome;
		}
		else{
			Console.WriteLine("invalido");
		}

		if(Populacao >= 0){
			populacao = Populacao;
		}
		else{
			Console.WriteLine("invalido");
		}
		
	}

	public void SetNome(string Nome)
	{
		if(Nome != ""){
			nome = Nome;
		}
		else{
			Console.WriteLine("invalido");
		}
	}

	public void SetPopulacao(int Populacao)
	{
		if(Populacao >= 0){
			populacao = Populacao;
		}
		else{
			Console.WriteLine("invalido");
		}	
	}

	public string GetNome()
	{
		return this.nome;
	}
	

	public int GetPopulacao()
	{
		return this.populacao;
	}

	public override string ToString()
	{
    return nome.ToString()+":"+populacao.ToString();
  }
	
}

class MainClass
{
	public static void Main()
	{
		int pop=0;
		string pais = "";
		
		
		int i = 0;
		while(i!=10){
			Console.Write("Digite o Nome do Pais: ");
			string paisNome = Console.ReadLine();
			if(paisNome != ""){
				Console.Write("Digite a Quantidade Populacional: ");
				int paisPopulacao = int.Parse(Console.ReadLine());
				
				if(paisPopulacao >= 0){
					Pais p = new Pais(paisNome,paisPopulacao);
					if(paisPopulacao > pop){
						pop = p.GetPopulacao();
						pais = p.GetNome();
					}
					i++;
				}
				else{
					Console.WriteLine("Valores Inválidos");
				}	
			}
			else{
					Console.WriteLine("Valores Inválidos");
				}
		}
		Console.WriteLine("O Pais com maior População é a "+pais+":"+pop);
	}
}