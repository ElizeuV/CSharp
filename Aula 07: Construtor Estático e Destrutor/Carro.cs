// using System;
// using System.Collections.Generic;
// using System.Text;

// namespace ConstrutoresDestrutores
// {
//     class Carro : Veiculo 
//     {
//       public int Portas { get; set; }

//       public double Preco { get; set; }

//       public string Modelo { get; set; }

//       public Carro() 
//       {
//           Console.WriteLine("Um novo objeto carro foi criado");
//       }

//       public Carro(int pesoKg) : base(pesoKg)
//       {
//         this.PesoKg = pesoKg;
//         Console.WriteLine($"Um novo objeto carro foi criado com peso {this.PesoKg}");
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

//       ~Carro()	
//       {
//           Console.WriteLine("Um objeto do tipo carro foi destruído");
//       }
      
//     }
// }