using System;

namespace PObjeto_Aluno_funcionario
{
    internal class Program
    {

       static void coleta_dados_alunos(string nome, string data_nascimento, long cpf, string registro, string data_matricula)
        {
            Console.Write("\nDigite o Nome do aluno: ");
            nome = Console.ReadLine();

            Console.Write("\nDigite a data de Nascimento do aluno: ");
            data_nascimento = Console.ReadLine();

            Console.Write("\nDigite o CPF do aluno: ");
            cpf = long.Parse(Console.ReadLine());

            Console.Write("\nDigite o Registro do aluno: ");
            registro = Console.ReadLine();

            Console.Write("\nDigite a data da Matricula do aluno: ");
            data_matricula = Console.ReadLine();
        }

        static void Main(string[] args)
        {
            int Numeros_alunos, Numeros_Funcionarios,pessoas;
            String nome, data_nascimento;
            long cpf;



            Console.WriteLine("Digite o número de alunos que deseja: ");
            Numeros_alunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de funcionários que deseja: ");
            Numeros_Funcionarios = int.Parse(Console.ReadLine());


            coleta_dados_alunos(nome,data_nascimento,cpf);












            //pessoas = Numeros_alunos + Numeros_Funcionarios;

            //Pessoa[] pessoa = new Pessoa[pessoas];

            //Pessoa[] alunos = new Pessoa[Numeros_alunos];
            //Pessoa[] funcionarios = new Pessoa[Numeros_Funcionarios];



            //for (int i = 0; i < pessoas; i++) // laço para leitura de valores e alimentação do vetor 
            //{
            //    Console.Write("\nDigite o " + (i + 1) + "º Nome: ");
            //    nome = Console.ReadLine();

            //    Console.Write("\nDigite a " + (i + 1) + "º data de  nascimento: ");
            //    data_nascimento = Console.ReadLine();

            //    Console.Write("\nDigite o " + (i + 1) + "º CPF: ");
            //    cpf = long.Parse(Console.ReadLine());

            //    pessoa[i] = new Pessoa(nome, data_nascimento, cpf);
            //    Console.Clear();
            //}

            //for (int i = 0; i < pessoas; i++) // laço para exibição 
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine("\nDados da " + (i + 1) + "º Pessoa: ");
            //    Console.Write(pessoa[i].ToString());

            //    Console.WriteLine("Tecle ENTER para CONTINUAR");
            //    Console.ReadKey();

            //}

        }
    }
}
