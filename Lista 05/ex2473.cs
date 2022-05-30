using System;

class ClassMain
{
    public static void Main()
		{
			string[] l1 = Console.ReadLine().Split(' ');
			string[] l2 = Console.ReadLine().Split(' ');
			
			int n1 = int.Parse(l1[0]);
			int n2 = int.Parse(l1[1]);
			int n3 = int.Parse(l1[2]);
			int n4 = int.Parse(l1[3]);
			int n5 = int.Parse(l1[4]);
			int n6 = int.Parse(l1[5]);

			int r1 = int.Parse(l2[0]);
			int r2 = int.Parse(l2[1]);
			int r3 = int.Parse(l2[2]);
			int r4 = int.Parse(l2[3]);
			int r5 = int.Parse(l2[4]);
			int r6 = int.Parse(l2[5]);

			int acertos = 0;
			
			if(r1 == n1){
				acertos += 1;
			}
			else if(r1 == n2){
				acertos += 1;
			}
			else if(r1 == n3){
				acertos += 1;
			}
			else if(r1 == n4){
				acertos += 1;
			}
			else if(r1 == n5){
				acertos += 1;
			}
			else if(r1 == n6){
				acertos += 1;
			}

			if(r2 == n1){
				acertos += 1;
			}
			else if(r2 == n2){
				acertos += 1;
			}
			else if(r2 == n3){
				acertos += 1;
			}
			else if(r2 == n4){
				acertos += 1;
			}
			else if(r2 == n5){
				acertos += 1;
			}
			else if(r2 == n6){
				acertos += 1;
			}

			if(r3 == n1){
				acertos += 1;
			}
			else if(r3 == n2){
				acertos += 1;
			}
			else if(r3 == n3){
				acertos += 1;
			}
			else if(r3 == n4){
				acertos += 1;
			}
			else if(r3 == n5){
				acertos += 1;
			}
			else if(r3 == n6){
				acertos += 1;
			}

			if(r4 == n1){
				acertos += 1;
			}
			else if(r4 == n2){
				acertos += 1;
			}
			else if(r4 == n3){
				acertos += 1;
			}
			else if(r4 == n4){
				acertos += 1;
			}
			else if(r4 == n5){
				acertos += 1;
			}
			else if(r4 == n6){
				acertos += 1;
			}

			if(r5 == n1){
				acertos += 1;
			}
			else if(r5 == n2){
				acertos += 1;
			}
			else if(r5 == n3){
				acertos += 1;
			}
			else if(r5 == n4){
				acertos += 1;
			}
			else if(r5 == n5){
				acertos += 1;
			}
			else if(r5 == n6){
				acertos += 1;
			}

			if(r6 == n1){
				acertos += 1;
			}
			else if(r6 == n2){
				acertos += 1;
			}
			else if(r6 == n3){
				acertos += 1;
			}
			else if(r6 == n4){
				acertos += 1;
			}
			else if(r6 == n5){
				acertos += 1;
			}
			else if(r6 == n6){
				acertos += 1;
			}

			if(acertos == 3){
				Console.WriteLine("terno");
			}
			else if(acertos == 4){
				Console.WriteLine("quadra");
			}
			else if(acertos == 5){
				Console.WriteLine("quina");
			}
			else if(acertos == 6){
				Console.WriteLine("sena");
			}
			else if(acertos < 3){
				Console.WriteLine("azar");
			}
		}
}