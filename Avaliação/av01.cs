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
		int i = 0;
		while(i!=1){
			Console.Write("Digite o Nome do Pais: ");
			string pais = Console.ReadLine();
			if(pais != ""){
				Console.Write("Digite a Quantidade Populacional: ");
				int popu = int.Parse(Console.ReadLine());
				if(popu >= 0){
					Pais p = new Pais(pais,popu);
					Console.WriteLine(p);
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
	}
}