using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROVA_18_06
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double SalarioBase { get; set; }
    public Funcionario(string nome, string cpf, double salarioB){
        Nome = nome;
        Cpf = cpf;
        SalarioBase = salarioB; 
    }   

    public virtual double CalcularSalarioFinal(){
        return SalarioBase;
    }
        public virtual void ExibirDados(){
        Console.WriteLine($"Nome: {Nome}, Salário Final: {CalcularSalarioFinal():C2}");
    }
    }
}