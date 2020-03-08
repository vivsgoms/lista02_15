using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Digite a nota dos dois bimestres da disciplina:");
    int notaa = int.Parse(Console.ReadLine());
    int notab = int.Parse(Console.ReadLine());
    int media = ((notaa * 2) + (notab *3)) / 5;
    Console.WriteLine($"Media parcial = {media}");
  }
}
