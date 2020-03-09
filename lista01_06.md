using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite a base e a altura do retângulo.");
    int Base = int.Parse(Console.ReadLine());
    int altura = int.Parse(Console.ReadLine());
    int area = Base * altura;
    int perimetro = 2 * (Base + altura);
    double diagonal = Math.Sqrt(Base * Base + altura * altura);
    Console.WriteLine($"Área = {area} - Perímetro = {perimetro} - Diagonal = {diagonal}");
  }
}
