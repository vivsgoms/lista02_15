using System;

class MainClass {
  public static void Main (string[] args) {
  Console.WriteLine ("Digite o primeiro horário no formato hh:mm");
  string[] primeiro = Console.ReadLine().Split(":");
  Console.WriteLine ("Digite o segundo horário no formato hh:mm");
  string[] segundo = Console.ReadLine().Split(":");
  int minutos = int.Parse(primeiro[1]) + int.Parse(segundo[1]);
  int horas = int.Parse(primeiro[0]) + int.Parse(segundo[0]);
  if (minutos >= 60)
   {
    minutos = minutos - 60;
    horas = horas + 1;
   }

  Console.WriteLine($"Total de horas = {horas:00}:{minutos}");
  
 

  }
}
