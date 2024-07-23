// using System;

// class MainClass
// {
//     public static void Main(string[] args)
//     {
//         Console.WriteLine("Classes, Objetos e Escopos de Visibilidade. \n");

//         Produto p1 = new Produto();
//         p1.Nome = "Banana";
//         p1.Preco = 3.9;
//         p1.Comprar(20);
//         p1.Vender(8);
//         Console.WriteLine(p1.ObterTexto());

//         Produto p2 = new Produto("Laranja", 4.75);
//         p2.Comprar(100);
//         p2.Vender(17);
//         Console.WriteLine(p2.ObterTexto());

//         Produto p3 = new Produto("Abacaxi", 3.25);
//         p3.Comprar(50);
//         p3.Vender(21);
//         Console.WriteLine(p3.ObterTexto());

//         //Console.WriteLine($"Estoque = {p3.Estoque}"); //Consigo ver o estoque porem não consigo alterar o estq.
//     }
// }