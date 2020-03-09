using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Em que data você nasceu?");
    string data = Console.ReadLine();
    string ano = data.Substring(6,4);
    int idade = int.Parse(ano);
    Console.WriteLine($"Em 2020 você terá {2020-idade} anos");
  }
}
