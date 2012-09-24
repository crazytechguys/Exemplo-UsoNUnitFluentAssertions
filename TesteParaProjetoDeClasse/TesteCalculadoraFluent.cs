using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using FluentAssertions;

namespace TesteParaProjetoDeClasse
{
    [TestFixture]
    public class TesteCalculadoraFluent
    {
        ProjetoDeClasse.Calculadora calculadora;

        [SetUp]
        public void Init()
        {
            calculadora = new ProjetoDeClasse.Calculadora();
        }

        [Test]
        public void SomaTestFluent()
        {
            calculadora.Soma(1, 1).Should().Be(2);
            calculadora.Soma(1, 3).Should().NotBe(2);
            calculadora.Soma(1, -1).Should().Be(0);
        }

        [Test]
        public void DivisaoTestFluent()
        {
            calculadora.Divisao(1, 1).Should().Be(1);
            calculadora.Divisao(2, 2).Should().Be(1);
            calculadora.Divisao(2, -2).Should().Be(-1);
            calculadora.Divisao(3, 2).Should().NotBe(1.3m);

            Action act = () => calculadora.Divisao(2, 0);
            act.ShouldThrow<DivideByZeroException>();
        }

        [Test]
        public void SubtracaoTestFluent()
        {
            calculadora.Subtracao(2, 1).Should().Be(1);
            calculadora.Subtracao(0, -3).Should().Be(3);
            calculadora.Subtracao(4, 5).Should().Be(8);
            calculadora.Subtracao(1, 1).Should().Be(0);
        }
    }
}
