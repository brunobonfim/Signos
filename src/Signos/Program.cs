using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Signos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um nome");
            var nome = Console.ReadLine();

            var qualquerPessoa = new Pessoa();

            qualquerPessoa.AtribuirNome(nome);

            Console.WriteLine("Digite sua data de nascimento");

            var dataNascimento = Convert.ToDateTime(Console.ReadLine());

            qualquerPessoa.AtribuirDataNascimento(dataNascimento);

            var signo = new Signo();
            var nomeSigno = signo.ObterNomeSigno(qualquerPessoa.ObterDataNascimento());

            Console.WriteLine("Seu signo é: {0}", nomeSigno);

            Console.WriteLine("Pressione qualquer tecla para terminar");
            Console.ReadKey();

        }
    }
}
