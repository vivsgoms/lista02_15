using System;

class MainClass {
  public static void Main (string[] args) {
    int maior, menor, medio;
    Console.WriteLine ("Digite três valores");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    maior = a;
    if (b>maior)
      maior = b;
    if (c>maior)
      maior = c;
    
    menor = a;
    if (b<menor)
      menor = b;
    if (c<menor)
      menor = b;

    medio = a;
    if ((a!=maior) && (a!=menor))
      medio = a;
    if ((b!=maior) && (b!=menor))
      medio = b;
    if ((c!=maior) && (c!=menor))
      medio = c;

    Console.WriteLine($"{menor}, {medio}, {maior}");
  }
}