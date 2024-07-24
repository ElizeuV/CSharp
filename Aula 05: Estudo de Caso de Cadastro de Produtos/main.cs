using System;
using System.Collections.Generic;

class MainClass
{
    private static List<Produto> produtos = new List<Produto>();

    public static void Main(string[] args)  { 
        
    Console.WriteLine("Classes, Objetos e Escopos de Visibilidade. \n");
        
        string comandoEscolhido = "S";

        do  
        {
            //exibição do menu
            Console.Clear();
            Console.WriteLine("Escolha uma opção: \n");
            Console.WriteLine("1 - Cadastrar um novo produto");
            Console.WriteLine("2 - Listar produtos");
            Console.WriteLine("S - Sair");

            //leitura da opção desejeada pelo usuário
            Console.Write("Opção desejada: ");
        comandoEscolhido=Console.ReadKey().KeyChar.ToString().ToUpper();
        switch (comandoEscolhido) 
        {
            case "1":
                Console.Write("\nNome do produto: ");
                string nome = Console.ReadLine();
                Console.Write("Preço do produto: ");
                string preco = Console.ReadLine();
                Produto novoProduto = new Produto(nome, Convert.ToDouble(preco));
                produtos.Add(novoProduto);
                Console.WriteLine("Produto adicionado com sucesso!");
                Console.ReadKey();
                break;
    
            case "2":
                if (produtos.Count > 0) 
                {
                    Console.WriteLine("\nLista de produtos: \n");
                    foreach (Produto p in produtos)
                    {
                        Console.WriteLine(p.ObterTexto());
                    }
                    Console.Write("Pressione qualquer tecla para sair....");
                    Console.ReadKey();
                }
                else
                    Console.WriteLine("\nNão há produtos cadastrados!");
                break;
    
            case "S":
                
                Console.WriteLine("\nObrigado por usar o programa. ");
                break;
                
        default:
              Console.WriteLine("\nOpção inválida! Tente novamente.");
            break;
            
            }      
        } while (comandoEscolhido != "S");
    }
}




    // Produto p1 = new Produto("Maça", 6.2);
    // Produto p2 = new Produto("Banana", 2.5);
    // Produto p3 = new Produto("Pera", 10.2);
    // Produto p4 = new Produto("Uva", 12.33);
    // Produto p5 = new Produto("Laranja", 3.2);


    // List<Produto> produtos = new List<Produto>();
    // produtos.Add(p1);
    // produtos.Add(p2);
    // produtos.Add(p3);
    // produtos.Add(p4);
    // produtos.Add(p5);

    // foreach (Produto p in produtos) {
    //     p.Comprar(100);
    //     Console.WriteLine(p.ObterTexto());
    // }