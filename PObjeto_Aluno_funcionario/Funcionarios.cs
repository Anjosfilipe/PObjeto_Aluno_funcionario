using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PObjeto_Aluno_funcionario
{
    internal class Funcionarios : Pessoa
    {
        String Setor,Numero_Pis;
        double Salario;


        public Funcionarios(string nome, string data_nascimento, long cpf, string setor, string numero_pis, double salario ) : base(nome, data_nascimento, cpf)
        {
            this.Setor = setor;
            this.Numero_Pis = numero_pis;
            this.Salario = salario; 
        }

        public void setSetor(string setor)
        {
            this.Setor = setor;
        }

        public void setSalario(double salario)
        {
            this.Salario = salario;
        }

        public void setNumero_Pis(string numero_pis)
        {
            this.Numero_Pis = numero_pis;
        }

        public override string ToString()
        {
            return base.ToString() + "\nNumero do Pis: " + Numero_Pis + "\nSalario: " + Salario + "\nSetor: " + Setor;
        }
    }
}
