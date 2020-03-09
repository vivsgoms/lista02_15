using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Há quantos anos você fuma?");
    int anos = int.Parse(Console.ReadLine());
    Console.WriteLine("Quantos cigarros você fuma por dia?");
    int cigarros = int.Parse(Console.ReadLine());
    Console.WriteLine("Quanto custa uma carteira de cigarro?");
    double valor = double.Parse(Console.ReadLine());
    double preco = (valor * cigarros) / 20;
    int dias = anos * 365;
    double total = (preco * cigarros * dias)/10;
    Console.WriteLine($"Você gasta: {total}");
  }
}
