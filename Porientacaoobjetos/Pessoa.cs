using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Porientacaoobjetos
{
    internal class Pessoa
    {
        String Nome;
        DateTime DataNasc;
        String Cpf;
        long Telefone;

        public Pessoa()//objeto construtor
        {

        }

        public Pessoa(string nome, DateTime dataNasc, string cpf, long telefone)
        {
            this.Nome = nome;
            this.DataNasc = dataNasc;
            this.Cpf = cpf;
            this.Telefone = telefone;

        }

        public void setNome()//tipo de acesso/ retorno do metodo/ nome
        {
            Console.WriteLine("Informe o nome:");
            this.Nome = Console.ReadLine();
        }
        public void getNome()
        {
            Console.WriteLine("Nome: " + this.Nome);
        }

        public void setDataNasc()
        {
            Console.WriteLine("Informe a data de nascimento: ");
            this.DataNasc = DateTime.Parse(Console.ReadLine());
        }
        public void getDataNasc()
        {
            Console.WriteLine("Data de nascimeento: " + this.DataNasc);
        }

        public void setCpf()
        {
            Console.WriteLine("Informe o cpf: ");
            this.Cpf = Console.ReadLine();

        }
        public void getCpf()
        {
            Console.WriteLine("Cpf: " + this.Cpf);
        }


        public void setTelefone()
        {
            Console.WriteLine("informe o telefone: ");
            this.Telefone = long.Parse(Console.ReadLine());
        }
        public void getTelefone()
        {
            Console.WriteLine("Telefone: " + this.Telefone);
        }

        public string ImprimirCadastro() //metodo = função
        {
            return "\nNome: " + this.Nome + "\nData de nascimento: " + this.DataNasc.ToLongDateString() +
                   "\nCPF: " + this.Cpf + "\nTelefone: " + this.Telefone;
        }

        public void CadastrarPessoa()
        {
            setNome();
            setDataNasc();
            setCpf();
            setTelefone();
        }

    }
}