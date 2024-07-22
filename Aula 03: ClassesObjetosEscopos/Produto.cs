using System;

class Produto {
  private string nome;
  

  public string Nome 
  {
    get 
    { //ler
      return nome;
    }
    
    set { //escrever
      if (value.Length > 1) 
      nome = value;
      else     
          throw new Exception("Nome do produto deve ter mais de 2 caracteres");
    }    
  }

  public double Preco { get; set; }

  public int Estoque { get; private set; } //pode ser lido, mas so pode ser escrito dentro da classe produto
  
}
