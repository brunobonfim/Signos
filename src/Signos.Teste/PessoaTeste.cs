using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Signos;

namespace Signos.Teste
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class PessoaTeste
    {
       
        [TestMethod]
        public void devePermitirInformarUmNome()
        {
            //Arange  
            var raul = new Pessoa();
            //Act
            raul.AtribuirNome("Raul");
            //Assert
            Assert.AreEqual("Raul", raul.ObterNome());
        }

        [TestMethod]
        public void devePermitirInformarUmaDataDeNascimento()
        {
            //Arange
            var raul = new Pessoa();
            var data = new DateTime(1980,7,30);

            //Act
            raul.AtribuirDataNascimento(data);

            //Assert
            Assert.AreEqual(data , raul.ObterDataNascimento());

        }
    }
}
 