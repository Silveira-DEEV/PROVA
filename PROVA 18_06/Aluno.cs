using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROVA_18_06
{
    public class Aluno : Pessoa
    {
        public double Nota { get; set; }


        public Aluno(string nome, int idade, double nota) : base(nome, idade){
            Nota = nota;
        }
        public override void ExibirInfo(){
        Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Nota: {Nota}");
        }//Aplicação Polimorfismo.
    }
}