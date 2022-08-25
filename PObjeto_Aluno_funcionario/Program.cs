using System;

namespace PObjeto_Aluno_funcionario
{
    internal class Program
    {

        static Aluno coleta_dados_alunos()
        {
            Console.Write("\nDigite o Nome do aluno: ");
            string nome = Console.ReadLine();

            Console.Write("\nDigite a data de Nascimento do aluno: ");
            string data_nascimento = Console.ReadLine();

            Console.Write("\nDigite o CPF do aluno: ");
            long cpf = long.Parse(Console.ReadLine());

            Console.Write("\nDigite o Registro do aluno: ");
            string registro = Console.ReadLine();

            Console.Write("\nDigite a data da Matricula do aluno: ");
            string data_matricula = Console.ReadLine();

            return new Aluno(nome, data_nascimento, cpf, registro, data_matricula);
        }

        static Funcionarios coleta_dados_funcionarios()
        {
            Console.Write("\nDigite o Nome do Funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("\nDigite a data de Nascimento do Funcionário: ");
            string data_nascimento = Console.ReadLine();

            Console.Write("\nDigite o CPF do Funcionário: ");
            long cpf = long.Parse(Console.ReadLine());

            Console.Write("\nDigite o Setor do Funcionário: ");
            string setor = Console.ReadLine();

            Console.Write("\nDigite o numero do Pis do Funcionário: ");
            string numero_pis = Console.ReadLine();

            Console.Write("\nDigite o numero Salário do Funcionário: ");
            double salario = double.Parse(Console.ReadLine());


            return new Funcionarios(nome, data_nascimento, cpf, setor, numero_pis, salario);
        }

        static void Main(string[] args)
        {
            int Numeros_alunos, Numeros_Funcionarios;

            Console.WriteLine("Digite o número de alunos que deseja: ");
            Numeros_alunos = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o número de funcionários que deseja: ");
            Numeros_Funcionarios = int.Parse(Console.ReadLine());

            Aluno[] alunos = new Aluno[Numeros_alunos];
            Funcionarios[] funcionarios = new Funcionarios[Numeros_Funcionarios];


            for (int i = 0; i < Numeros_alunos; i++)
            {
                Aluno aluno = coleta_dados_alunos();
                alunos[i] = aluno;
                
            }

            Console.Clear();

            for (int i = 0; i < Numeros_alunos; i++)
            {
                Funcionarios funcionario = coleta_dados_funcionarios();
                funcionarios[i] = funcionario;
               
            }
            Console.Clear();

            for (int i = 0; i < Numeros_alunos; i++)
            {
                Console.WriteLine("\nAluno: nº" +(i+1));
                Console.WriteLine(alunos[i]);
                Console.WriteLine("Tecle ENTER para continuar");
                Console.ReadKey();
            }

            Console.Clear();

            for (int i = 0; i < Numeros_Funcionarios; i++)
            {

                Console.WriteLine("\nFuncionário: nº" + (i + 1));
                Console.WriteLine(funcionarios[i]);
                Console.WriteLine("Tecle ENTER para continuar");
                Console.ReadKey();
            }
        }
    }
}

