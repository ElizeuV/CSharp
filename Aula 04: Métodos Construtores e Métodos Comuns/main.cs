using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Classes, Objetos e Escopos de Visibilidade. \n");

    Produto p1 = new Produto();
    p1.Nome = "Banana";
    p1.Preco = 3.9;
    Console.WriteLine(p1.ObterTexto());

    Produto p2 = new Produto("Laranja" , 4.75);
    Console.WriteLine(p2.ObterTexto());

    Produto p3 = new Produto("Abacaxi" , 3.25);
    Console.WriteLine(p3.ObterTexto());
    
 
  }
}