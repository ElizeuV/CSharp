// using System;
// using System.Collections.Generic;
// using System.Text;

// namespace ConstrutoresDestrutores
// {
//     class Carro
//     {
//       public int Portas { get; set; }

//       public double Preco { get; set; }

//       public string Modelo { get; set; }

//       public Carro() 
//       {
//           Console.WriteLine("Um novo objeto carro foi criado");
//       }

//       public Carro(string modelo):this()
//       {
//         this.Modelo = modelo;
//       }

//       public Carro(string modelo, int portas, double preco):this(modelo)
//       {
        
//         this.Portas = portas;
//         this.Preco = preco;
        
//       }
//     }
// }