using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite os coeficientes a, b e c de uma equação do segundo grau:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());

    int delta = (b*b) - 4*a*c;

    if (delta < 0)
      Console.WriteLine("Impossível calcular");
    
    double x1 = ((b*-1) + Math.Sqrt(delta)) / 2*a;
    double x2 = ((b*-1) - Math.Sqrt(delta)) / 2*a;

    Console.WriteLine($"As raízes são {x1} e {x2}");
  }
}
