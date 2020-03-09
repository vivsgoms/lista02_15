using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite um valor monetário:");
    string valor = Console.ReadLine();
    int virgula = valor.IndexOf(",");
    string resto = valor.Substring(virgula);
    string centavos = resto.Substring(1);
    int quantidade = valor.Length;
    int maximo = quantidade - 3;
    string reais = valor.Substring(0,maximo);
    Console.WriteLine($"{reais} reais e {centavos} centavos");
    
    
  }
}
