using System;

namespace ConstrutoresDestrutores
{
    class MainClass
    {
        static MainClass()
        {
            Console.WriteLine("Programa iniciado com sucesso.");
        }
        
        static void CriarObjetos() {
            Carro c1 = new Carro();
            c1.Modelo = "Fusca 1.3";
            c1.Portas = 4;
            c1.Preco = 40.000;

            Carro c2 = new Carro();
            c2.Modelo = "Opala 2.0";
            c2.Portas = 2;
            c2.Preco = 25.000;

            Carro c3 = new Carro();
            c3.Modelo = "BMW X1 5.5";
            c3.Portas = 4;
            c3.Preco = 200.000;

            Carro c4 = new Carro("BMW 320i 2.5", 4, 260000);

            Carro c5 = new Carro(1001);
        }
        
        static void Main(string[] args)
        {
            
            CriarObjetos();
       
            Console.WriteLine("Objetos já não são mais utiliados");

            GC.Collect();
              
        }
        
    }
}
