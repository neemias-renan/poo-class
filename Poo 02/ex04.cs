
using System;

class Conta
{
	private string nome;
	private string conta;
	private int saldo = 0;

	public void SetNome(string n){
		nome = n;		
	}
	
	public void SetConta(string n){
		conta = n;		
	}

	public string GetNome(){
		string n = nome;
		return n;
	}
	
	public string GetConta(){
		string c = conta;
		return c;
	}
	
	public int GetSaldo(){
		int s = saldo;
		return s;
	}

	
	
	public void Depositar(int valorDep){
		if(valorDep > 0){
			saldo += valorDep;
			Console.WriteLine("------------------");
			Console.WriteLine("Depósito Realizado.");
			Console.WriteLine("------------------");
		}
		else{
			Console.WriteLine("------------------");
			Console.WriteLine("Falha ao Realizar Depósito.");
			Console.WriteLine("------------------");
		}
	}

	public void Sacar(int valorSaq){
		if(valorSaq <= saldo && valorSaq > 0){
			saldo -= valorSaq;
			Console.WriteLine("------------------");
			Console.WriteLine("Saldo Atualizado");
			Console.WriteLine("------------------");
		}else{
			Console.WriteLine("------------------");
			Console.WriteLine("Saldo Indisponível");
			Console.WriteLine("Você possui apenas R$"+saldo+".");
			Console.WriteLine("------------------");
		}
	}

}

class MainClass
{
	public static void Main()
	{
		Console.Write("Nome: ");
		string nome = Console.ReadLine();
		Console.Write("Número da Conta: ");
		string numCont = Console.ReadLine();
		Console.WriteLine("-------------------");
		Console.Clear();
		
		Conta conta = new Conta();
		conta.SetNome(nome);
		conta.SetConta(numCont);
		int op;
		
		do{
			Console.Clear();
		  Console.WriteLine("Olá, "+ conta.GetNome()+".");
			Console.WriteLine("O que deseja fazer?");
			Console.WriteLine(" 1 - Depósito");
			Console.WriteLine(" 2 - Saque");
			Console.WriteLine(" 3 - Extrato");
			Console.WriteLine(" 4 - Sair");
			Console.Write("Digite a opção: ");
			op = int.Parse(Console.ReadLine());
			
			if(op == 1){
				Console.Clear();
				Console.WriteLine("------------------");
				Console.Write("Digite o valor do depósito: ");
				int valorDep = int.Parse(Console.ReadLine());
				conta.Depositar(valorDep);
				Console.Write("Digite Enter para voltar");
				Console.ReadLine();
				Console.WriteLine("------------------");
			}
			else if(op == 2){
				Console.Clear();
				Console.WriteLine("------------------");
				Console.Write("Digite o valor do Saque: ");
				int valorSaq = int.Parse(Console.ReadLine());
				conta.Sacar(valorSaq);
				Console.Write("Digite Enter para voltar");
				Console.ReadLine();
				Console.WriteLine("------------------");
			}
			else if(op == 3){
				Console.Clear();
				Console.WriteLine("------------------");
				Console.WriteLine("Seu saldo é de R$"+ conta.GetSaldo() +".");
				Console.Write("Digite Enter para voltar");
				Console.ReadLine();
				Console.WriteLine("------------------");
				
			}
			else if(op == 4){
				Console.Clear();
				Console.WriteLine("------------------");
				Console.WriteLine("Saindo...");
				Console.WriteLine("------------------");
				break;
			}
		}
		while(op!=4);		
	}
}