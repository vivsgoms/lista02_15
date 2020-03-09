using System;

class MainClass {
  public static void Main (string[] args) {
    int menor = 0;
    int maior = 0;
    Console.WriteLine ("Digite três valores inteiros");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    if (a < b && a < c)
      menor = a;
    if (b < a && b < c)
      menor = b;
    if (c < a && c < b)
      menor = c;

    if (a > b && a > c)
      maior = a;
    if (b > a && b > c)
      maior = b;
    if (c > a && c > b)
      maior = c;  
    

    Console.WriteLine($"A soma do maior número com o menor é {maior+menor}");  
  }
}
