using System;
using System.Collections.Generic;
using System.Text;

namespace Semana5
{
    class Pessoa
    {
        private string cpf;

        public string CPF
        {
            get { return cpf; }
            set
            {
                if (value.Length == 11)
                    cpf = value;
                else
                    throw new Exception("CPF inválido!");
            }
        }

        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }

        public double IMC 
        {
            get 
            {
                return (this.Peso / (this.Altura * this.Altura));
            }
        }

        public Pessoa (string nome, string sobrenome, DateTime dataNascimento, string cpf)
        {
            this.Nome = nome;
            this.SobreNome = sobrenome;
            this.DataNascimento = dataNascimento;
            this.CPF = cpf;
        }

        public Pessoa(string nome, string sobrenome,  DateTime dataNascimento, string cpf, double peso, double altura) : this(nome, sobrenome, dataNascimento, cpf)
        {
            this.Peso = peso;
            this.Altura = altura;
        }

        public void Comer(double pesoKg) 
        {
            this.Peso += pesoKg / 10;
            Console.WriteLine($"{this.Nome} {this.SobreNome} comeu {pesoKg}Kg de comida");
        }

        public void Comer(int calorias)
        {
            this.Peso += calorias / 30000;
              Console.WriteLine($"{this.Nome} {this.SobreNome} ingeriu {calorias} calorias");
        }

        public void Correr (double distanciaKm, int dias = 1)
        {
            this.Peso -= (distanciaKm /40) * dias;
            Console.WriteLine($"{this.Nome} {this.SobreNome} correu {distanciaKm}Kms por {dias} dias");
        }

        public void MostrarDados()
        {
            Console.WriteLine($"\nNome completo: {this.Nome} {this.SobreNome}");

            Console.WriteLine($"\nNome completo: {this.Nome} {this.SobreNome}");
            
            Console.WriteLine($"Idade: {Math.Floor((DateTime.Now - this.DataNascimento).TotalDays / 365.25)} anos");

            Console.WriteLine($"IMC: {this.IMC:F2}");
        } 
    }
}