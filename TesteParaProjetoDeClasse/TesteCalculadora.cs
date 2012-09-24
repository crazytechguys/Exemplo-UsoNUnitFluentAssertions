using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteParaProjetoDeClasse
{
    [TestFixture]
    public class TesteCalculadora
    {
        ProjetoDeClasse.Calculadora calculadora;

        [SetUp]
        public void Init()
        {
            calculadora = new ProjetoDeClasse.Calculadora();
        }

        [Test]
        public void SomaTest()
        {
            Assert.AreEqual(2, calculadora.Soma(1, 1));
            Assert.AreNotEqual(2, calculadora.Soma(1, 3));
            Assert.AreEqual(-1, calculadora.Soma(2, -3));
        }

        [Test]
        public void DivisaoTest()
        {
            Assert.AreEqual(1, calculadora.Divisao(2, 2));
            Assert.AreEqual(-1, calculadora.Divisao(2, -2));
            Assert.AreNotEqual(1.3, calculadora.Divisao(3, 2));
            Assert.Catch(typeof(DivideByZeroException), delegate { calculadora.Divisao(2, 0); });
        }

        [Test]
        public void SubtracaoTest()
        {
            Assert.AreEqual(1, calculadora.Subtracao(2, 1));
            Assert.AreEqual(3, calculadora.Subtracao(0, -3));
            Assert.AreNotEqual(8, calculadora.Subtracao(4, 5));
            Assert.AreEqual(0, calculadora.Subtracao(1, 1));
        }



    }
}
