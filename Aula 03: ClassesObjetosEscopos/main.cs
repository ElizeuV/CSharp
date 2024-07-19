using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Classes, Objetos e Escopos de Visibilidade. \n".);

    Produto p1 = new Produto();
    p1.Nome = "Banana";
    p1.Preco = 3.9;

    Console.WriteLine($"{p1.Nome} =  {p1.Preco}");
  }
}