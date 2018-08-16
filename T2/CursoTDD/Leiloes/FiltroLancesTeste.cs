using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD.Leiloes
{
    [TestFixture]
    public class FiltroLancesTeste
    {
        [Test]
        public void DeveSelecionarLancesEntre1000E3000()
        {
            Usuario joao = new Usuario("Joao");

            FiltroLances filtro = new FiltroLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,2000),
            new Lance(joao,1000),
            new Lance(joao,3000),
            new Lance(joao, 800)});

            Assert.AreEqual(1, resultado.Count);
            Assert.AreEqual(2000, resultado[0].Valor, 0.00001);
        }

        [Test]
        public void DeveSelecionarLancesEntre500E700()
        {
            Usuario joao = new Usuario("Joao");

            FiltroLances filtro = new FiltroLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,600),
            new Lance(joao,500),
            new Lance(joao,700),
            new Lance(joao, 800)});

            Assert.AreEqual(1, resultado.Count);
            Assert.AreEqual(600, resultado[0].Valor, 0.00001);
        }
        [Test]
        public void DeveSelecionarLancesMaiorQue5000()
        {
            Usuario joao = new Usuario("Joao");

            FiltroLances filtro = new FiltroLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
            new Lance(joao,6000),
            new Lance(joao,5000),
            new Lance(joao,4500),
            new Lance(joao, 1000)});

            Assert.AreEqual(1, resultado.Count);
            Assert.AreEqual(6000, resultado[0].Valor, 0.00001);
        }
        [Test]
        public void DeveEliminarMenoresQue500()
        {
            Usuario joao = new Usuario("Joao");

            FiltroLances filtro = new FiltroLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
        new Lance(joao,400),
        new Lance(joao, 300)});

            Assert.AreEqual(0, resultado.Count);
        }

        [Test]
        public void DeveEliminarEntre3000E5000()
        {
            Usuario joao = new Usuario("Joao");

            FiltroLances filtro = new FiltroLances();
            IList<Lance> resultado = filtro.Filtra(new List<Lance>() {
        new Lance(joao,4000),
        new Lance(joao, 3500)});

            Assert.AreEqual(0, resultado.Count);
        }
    }
}

