using System;

class MainClass {
  public static void Main (string[] args) {
    string valor = Console.ReadLine();
    int virgula = valor.IndexOf(".");
    string resto = valor.Substring(virgula);
    string centavos = resto.Substring(1);
    int quantidade = valor.Length;
    int maximo = quantidade - 3;
    string pre_notas = valor.Substring(0,maximo);
    int moedas = int.Parse(centavos);
    int notas = int.Parse(pre_notas);

    int n100 = notas / 100;
    int n50 = notas % 100 / 50;
    int n20 = notas % 100 % 50 / 20;
    int n10 = notas % 100 % 50 % 20 / 10;
    int n5 = notas % 100 % 50 % 20 % 10 / 5;
    int n2 = notas % 100 % 50 % 20 % 10 % 5 / 2;
    int n1 = notas % 100 % 50 % 20 % 10 % 5 % 2 / 1;
   
    Console.WriteLine($"{n100:0} nota(s) de R$ 100.00");
    Console.WriteLine($"{n50:0} nota(s) de R$ 50.00");
    Console.WriteLine($"{n20:0} nota(s) de R$ 20.00");
    Console.WriteLine($"{n10:0} nota(s) de R$ 10.00");
    Console.WriteLine($"{n5:0} nota(s) de R$ 5.00");
    Console.WriteLine($"{n2:0} nota(s) de R$ 2.00");
    Console.WriteLine($"{n1:0} moeda(s) de R$ 1.00");
