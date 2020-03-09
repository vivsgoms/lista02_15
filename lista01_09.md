using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe a sua massa em kg:");
    double massa = double.Parse(Console.ReadLine());
    Console.WriteLine("Informe a sua altura em metros:");
    double altura = double.Parse(Console.ReadLine());
    double imc = massa / (altura*altura);
    string imcoficial = imc.ToString("0.00");
    Console.WriteLine($"IMC = {imcoficial}");
  }
}
