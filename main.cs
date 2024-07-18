using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome");
        string r1 = Console.ReadLine();
        Console.WriteLine($"Seu nome é {r1} e possui {ContarLetras(r1)} letras.");


        //Chamada do método
        MostrarDados();
    }

    //Método
    public static void MostrarDados()
    {
        Console.WriteLine("Estes são os dados");
        Console.WriteLine("Rua Olga Benário, 526");
        Console.WriteLine("Anita G./SP");
        Console.WriteLine("CEP: 07179840");
    }

    public static int ContarLetras(string palavra)
    {
        return palavra.Length;
    }
}