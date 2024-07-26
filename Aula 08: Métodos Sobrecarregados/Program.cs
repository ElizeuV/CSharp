using System;

namespace MetodosSobrecarregados
{
    class Program
    {
        
        static void Main(string[] args) 
        {

            Veiculo v1 = new Veiculo("Fusca", CorVeiculo.Grafite, 2);
            v1.MostrarDados(1);

            Veiculo v2 = new Veiculo("Ferrari", CorVeiculo.Preto, 4);
            v2.MostrarDados(2);

            v2.Acelerar(5, 10);
        }
      
    }
}
