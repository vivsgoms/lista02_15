using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a nota dos três primeiros bimestres:");
    int a = int.Parse(Console.ReadLine());
    int b = int.Parse(Console.ReadLine());
    int c = int.Parse(Console.ReadLine());
    int media = (a*2 + b*2 + c*3)/10; // 48
    // 60 = (a*2 + b*2 + c*3 + d*3) / 10
    // 60 - 48 = 3d
    int ValorMultiplicadoPorTres = 60 - media;
    int ValorReal= (ValorMultiplicadoPorTres/3)*10;
    Console.WriteLine(ValorReal);
  }
}
