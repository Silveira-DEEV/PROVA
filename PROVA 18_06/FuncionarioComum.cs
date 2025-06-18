using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROVA_18_06
{
    public class FuncionarioComum : Funcionario
    {
        public FuncionarioComum(string nome, string cpf, double salarioB) : base(nome, cpf, salarioB){
            
        }
    }
}