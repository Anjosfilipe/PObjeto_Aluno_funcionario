using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PObjeto_Aluno_funcionario
{
    internal class Aluno : Pessoa
    {
        String Registro, Data_Matricula;

        public Aluno(string nome, string data_nascimento, long cpf, string registro, string data_Matricula) : base(nome, data_nascimento, cpf)
        {
            Registro = registro;
            Data_Matricula = data_Matricula;
        }

        public void setRegistro(string registro)
        {
            this.Registro = registro;
        }

        public void setData_Matricula(string data_matricula)
        {
            this.Data_Matricula = data_matricula;
        }



        public override string ToString()
        {
            return base.ToString() + "\nRegistro: " + Registro + "\nData de matricula: " + Data_Matricula;
        }
    }
}
