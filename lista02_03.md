using System;

class MainClass {
  public static void Main (string[] args) {
    int soma = 0;
    Console.WriteLine("Digite quatro valores inteiros:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());

    int total = a + b + c + d;

    if (a % 2 == 0)
       soma = soma + a;
    if (b % 2 == 0)
       soma = soma + b;
    if (c % 2 == 0)
       soma = soma + c;
    if (d % 2 == 0)
       soma = soma + d;

    int impares = total - soma;

    Console.WriteLine("Soma dos pares = " + soma);
    Console.WriteLine("Soma dos ímpares = " + impares);

    
  }
}
