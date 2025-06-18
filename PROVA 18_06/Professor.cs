using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROVA_18_06
{
    public class Professor : Pessoa
    {
        public decimal Salario  { get; set; }

        public Professor(string nome, int idade, decimal salario) : base(nome, idade){
            Salario = salario;
        }

        public override void ExibirInfo(){
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Salario: {Salario}");
        }//Aplicação Polimorfismo.
    }
}