//  Escreva um programa que leia três valores com ponto flutuante 
//  de dupla precisão: A, B e C. Em seguida, calcule e mostre:
//  a) a área do triângulo retângulo que tem A por base e C por altura.
//  b) a área do círculo de raio C. (pi = 3.14159)
//  c) a área do trapézio que tem A e B por bases e C por altura.
//  d) a área do quadrado que tem lado B.
//  e) a área do retângulo que tem lados A e B.
using System;

class ClassMain
{
    public static void Main()
    {
			double a,b,c,d,e;
			
			string linha = Console.ReadLine();
			
			string[] dados = linha.Split();

			double d1,d2,d3;
			d1 = double.Parse(dados[0]);
			d2 = double.Parse(dados[1]);
			d3 = double.Parse(dados[2]);
			
			a = ((d1*d3)/2);
			b = (3.14159*(d3*d3));
			c = (((d1+d2)*d3)/2);
			d = (d2*d2);
			e = (d1*d2);

			Console.WriteLine("TRIANGULO: {0:0.000}",a);
			Console.WriteLine("CIRCULO: {0:0.000}",b);
			Console.WriteLine("TRAPEZIO: {0:0.000}",c);
			Console.WriteLine("QUADRADO: {0:0.000}",d);
			Console.WriteLine("RETANGULO: {0:0.000}",e);
			
    }
}
