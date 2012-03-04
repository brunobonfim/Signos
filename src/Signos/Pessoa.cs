using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Signos
{
   public class Pessoa
   {
       private string _nome;
       private DateTime _dataNascimento;


       public void AtribuirNome(string nome)
       {
           _nome = nome;

       }    

       public string ObterNome()
       {
           return _nome;
       }

       public void AtribuirDataNascimento(DateTime data)
       {
           _dataNascimento = data;

       }

       public DateTime ObterDataNascimento()
       {
           return _dataNascimento;

       }


   }
}
