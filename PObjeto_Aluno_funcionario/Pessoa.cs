using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PObjeto_Aluno_funcionario
{
    internal class Pessoa
    {
        String Nome, Data_Nascimento;
        long Cpf;

        public Pessoa(string nome, string data_nascimento, long cpf)
        {
            this.Nome = nome;
            this.Data_Nascimento = data_nascimento;
            this.Cpf = cpf;

        }

        public void setNome(String nome)
        {
            this.Nome = nome;
        }

        public void setData_Nascimento(String data_nascimento)
        {
            this.Data_Nascimento = data_nascimento;
        }

        public void setCpf(long cpf)
        {
            this.Cpf = cpf;
        }

        public override String ToString() // override - escrever por cima 
        {
            return "\nNome: " + Nome + "\nData de Nascimento: " + Data_Nascimento + "\nCPF: " + Cpf;

        }



    }
}
