using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROVA_18_06
{
    public class Gerente : Funcionario
    {
        public static int Bonus = 1600;

        public Gerente(string nome, string cpf, double salarioB) : base(nome, cpf, salarioB){

        }

        public override double CalcularSalarioFinal(){
        return SalarioBase += Bonus;
    }


        public virtual void ExibirDados(){
        Console.WriteLine($"Nome: {Nome}, Salário Final: {CalcularSalarioFinal():C2}");
    }
    }
}