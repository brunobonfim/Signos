using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Signos.Teste
{
   
    [TestClass]
    public class SignoTeste
    {
        [TestMethod]
        public void deveRetornarAriesQuandoDataEntre21_03_a_20_04()
        {
            // Arrange
            var data = new DateTime(1980,3,22);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Aries",  nomeSigno);
        }

        [TestMethod]
        public void deveRetornarTouroQuandoDataEntre21_04_a_21_05()
        {
            // Arrange
            var data = new DateTime(1980, 4, 22);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Touro", nomeSigno);
        }

        [TestMethod]
        public void deveRetornarGemeosQuandoDataEntre22_05_a_21_06()
        {
            // Arrange
            var data = new DateTime(1980, 5, 23);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Gemeos", nomeSigno);
        }
        [TestMethod]
        public void deveRetornarCancerQuandoDataEntre22_06_a_21_07()
        {
            // Arrange
            var data = new DateTime(1980, 6, 22);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Cancer", nomeSigno);
        }

        [TestMethod]
        public void deveRetornarLeaoQuandoDataEntre24_07_a_23_08()
        {
            // Arrange
            var data = new DateTime(1980, 7, 24);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Leão", nomeSigno);
        }

        [TestMethod]
        public void deveRetornarVirgemQuandoDataEntre24_08_a_23_09()
        {
            // Arrange
            var data = new DateTime(1980, 8, 24);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Virgem", nomeSigno);
        }

        [TestMethod]
        public void deveRetornarLibraQuandoDataEntre24_09_a_23_10()
        {
            // Arrange
            var data = new DateTime(1980, 9, 24);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Libra", nomeSigno);
        }

        [TestMethod]
        public void deveRetornarEscorpiaoQuandoDataEntre24_10_a_22_11()
        {
            // Arrange
            var data = new DateTime(1980, 10, 24);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Escorpiao", nomeSigno);
        }

        [TestMethod]
        public void deveRetornarSagitarioQuandoDataEntre23_11_a_21_12()
        {
            // Arrange
            var data = new DateTime(1980, 11, 23);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Sagitario", nomeSigno);
        }

        [TestMethod]
        public void deveRetornarCapricornioQuandoDataEntre22_12_a_20_01()
        {
            // Arrange
            var data = new DateTime(1980, 12, 22);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Capricornio", nomeSigno);
        }

        [TestMethod]
        public void deveRetornarAquarioQuandoDataEntre21_01_a_19_02()
        {
            // Arrange
            var data = new DateTime(1980, 01, 21);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Aquario", nomeSigno);
        }

        [TestMethod]
        public void deveRetornarPeixesQuandoDataEntre20_02_a_20_03()
        {
            // Arrange
            var data = new DateTime(1980, 2, 20);
            var signo = new Signo();
            //Act
            var nomeSigno = signo.ObterNomeSigno(data);
            //Assert
            Assert.AreEqual("Peixes", nomeSigno);
        }
    }
}
