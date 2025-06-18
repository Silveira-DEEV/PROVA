using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROVA_18_06
{
    public class Estagiario : Funcionario
    {

        public static double Taxa = 0.6;

        public Estagiario(string nome, string cpf, double salarioB) : base(nome, cpf, salarioB){
            
        }

        public override double CalcularSalarioFinal(){
            return SalarioBase *= Taxa;
    }


        public virtual void ExibirDados(){
        Console.WriteLine($"Nome: {Nome}, Salário Final: {CalcularSalarioFinal():C2}");
    }
    }
}