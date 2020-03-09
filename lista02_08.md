using System;

class MainClass {
  public static void Main (string[] args) {
    int maior = 0;
    int menor = 0;
    Console.WriteLine("Digite quatro valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int d = int.Parse(Console.ReadLine());
    if ((a!=b) && (a!=c) && (a!=d) && (b!=c) && (b!=d) && (c!=d))
      {
      if ((a<b) && (a<c) && (a<d))
        menor = a;
      if ((b<a) && (b<c) && (b<d))
        menor = b;
      if ((c<a) && (c<b) && (c<d))
        menor = c;
      if ((d<a) && (d<b) && (d<c))
        menor = d;
      if ((a>b) && (a>c) && (a>d))
        maior = a;
      if ((b>a) && (b>c) && (b>d))
        maior  = b;
      if ((c>a) && (c>b) && (c>d))
        maior = c;
      if ((d>a) && (d>b) && (d>c))
        maior = d;
      
      int soma = a + b + c + d - (maior + menor);

      Console.WriteLine($"Maior valor = {maior}");
      Console.WriteLine($"Menor valor = {menor}");
      Console.WriteLine($"Soma do segundo maior com o segundo menor = {soma}");
    }
  }
}
