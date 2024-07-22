using System;
using System.Text;

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

  pubLic Produto() {
     this.Estoque = 0;
  }

  public Produto(string nome, double preco) {
    this.Nome = nome;
    this.Preco = preco;
    this.Estoque = 0;
  }

  public int Vender(int qtde) {
    if (this.Estoque - qtde >= 0)
    this.Estoque -= qtde;

    return this.Estoque;
  }

  public int Comprar(int qtde) {
    this.Estoque += qtde;
    return this.Estoque;
  }

  public string ObterTexto() {
    StringBuider sb = new StringBuilder();
    sb.Append($"\nNome: {this.Nome}\n");
    sb.Append($"Preço: {this.Preco}\n");
    sb.aAppend($"Estoque: {this.Estoque}\n");
    return sb.ToString();
    
  }

}
