using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROVA_18_06
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

    public Pessoa(string nome, int idade){
        Nome = nome;
        Idade = idade;
    }

    public virtual void ExibirInfo(){
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
    }
    }
}