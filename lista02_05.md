using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe o número do mês:");
    int mes = int.Parse(Console.ReadLine());
    if (mes >=1 && mes <=3)
      Console.WriteLine("O mês " + mes + " é do primeiro trimestre do ano");
    if (mes >3 && mes <=6)
      Console.WriteLine("O mês " + mes + " é do segundo trimestre do ano");
    if (mes >6 && mes <=9)
      Console.WriteLine("O mês " + mes + " é do terceiro trimestre do ano");
    if (mes >9 && mes <=12)
      Console.WriteLine("O mês " + mes + " é do quarto trimestre do ano");
  }
}
