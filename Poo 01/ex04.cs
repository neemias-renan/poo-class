// A classe deve ter atributos para armazenar o nome do titular da conta, o número da conta e seu saldo e métodos
// para realizar as operações de depósito e saque.
// Escrever um programa para testar a classe.


using System;

class Conta
{
	public string nome;
	public string numerodaconta;
	public int saldo = 100;

	public void Depositar(int valorDep){
		saldo += valorDep;
	}

	public void Sacar(int valorSaq){
		saldo -= valorSaq;
	}
}

class MainClass
{
	public static void Main()
	{
		Console.Write("Nome: ");
		string name = Console.ReadLine();
		Console.Write("Número da Conta: ");
		string numCont = Console.ReadLine();
		Console.WriteLine("-------------------");

		Conta conta = new Conta();
		conta.nome = name;
		conta.numerodaconta = numCont;
		int op;
		do{
		  Console.WriteLine("Olá, "+ conta.nome+".");
			Console.WriteLine("O que deseja fazer?");
			Console.WriteLine(" 1 - Depósito");
			Console.WriteLine(" 2 - Saque");
			Console.WriteLine(" 3 - Extrato");
			Console.WriteLine(" 4 - Sair");
			Console.Write("Digite a opção: ");
			op = int.Parse(Console.ReadLine());
			
			if(op == 1){
				Console.WriteLine("------------------");
				Console.Write("Digite o valor do depósito: ");
				int valorDep = int.Parse(Console.ReadLine());
				conta.Depositar(valorDep);
				Console.WriteLine("------------------");
			}
			else if(op == 2){
				Console.WriteLine("------------------");
				Console.Write("Digite o valor do Saque: ");
				int valorSaq = int.Parse(Console.ReadLine());
				conta.Sacar(valorSaq);
				Console.WriteLine("------------------");
			}
			else if(op == 3){
				Console.WriteLine("------------------");
				Console.WriteLine("Seu saldo é de R$"+ conta.saldo +".");
				Console.WriteLine("------------------");
			}
			else if(op == 4){
				Console.WriteLine("------------------");
				Console.WriteLine("Saindo...");
				Console.WriteLine("------------------");
				break;
			}
		}
		while(op!=4);	
	}
}