using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o valor do a raio:");
    double raio = double.Parse(Console.ReadLine());
    double circunferencia = 2 * 3.14 * raio;
    double area = 2 * 3.14 * (raio*raio);
    Console.WriteLine($"Circunferência = {circunferencia}");
    Console.WriteLine($"Área = {area}");
  }
}
