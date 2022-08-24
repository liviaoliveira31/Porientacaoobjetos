using System;

namespace Porientacaoobjetos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa1 = new Pessoa();

            pessoa1.CadastrarPessoa();

            Console.WriteLine(pessoa1.ImprimirCadastro());

            Console.WriteLine("Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Data de nascimento: ");
            DateTime data = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("CPF: ");
            string cpf = Console.ReadLine();
            Console.WriteLine("Telefone: ");
            long telefone = long.Parse(Console.ReadLine());

            Pessoa pessoa2 = new Pessoa(nome, data, cpf, telefone);
            Console.WriteLine(pessoa2.ImprimirCadastro());


        }
    }
}
