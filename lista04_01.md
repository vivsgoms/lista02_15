using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite seu nome:");
		string[] nome = Console.ReadLine().Split(' ');
		string primeiro_nome = nome[0];
		string segundo_nome = nome[1];
		Console.WriteLine("Resultado");
		Console.WriteLine(segundo_nome + ", " + primeiro_nome);
 	}
}
