using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD.Leiloes
{
    [TestFixture]
    public class AvaliadorTeste
    {
        private Avaliador leiloeiro;
        private Usuario joao;
        private Usuario jose;
        private Usuario maria;

        [SetUp]
        public void CriaAvaliador()
        {
            this.leiloeiro = new Avaliador();
            this.joao = new Usuario("João");
            this.jose = new Usuario("José");
            this.maria = new Usuario("Maria");
        }
        [Test]
        public void DeveEntenderLancesEmOrdemCrescente()
        {

            Leilao leilao = new CriadorLeilao().Para("Playstation 3 Novo")
            .Lance(maria, 250.0)
            .Lance(joao, 300.0)
            .Lance(jose, 400.0)
            .Constroi();
           

            leiloeiro.Avalia(leilao);

            double maiorEsperado = 400;
            double menorEsperado = 250;

            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance);
        }
        [Test]
        public void DeveEntenderLancesEmOrdemCrescenteComOutrosValores()
        {

            Leilao leilao = new CriadorLeilao().Para("Playstation 3 Novo")
            .Lance(maria, 1000.0)
            .Lance(joao, 2000.0)
            .Lance(jose, 3000.0)
            .Constroi();

            

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(3000, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(1000, leiloeiro.MenorLance, 0.0001);
        }

        [Test]
        public void DeveEntenderLeilaoComApenasUmLance()
        {
            Leilao leilao = new CriadorLeilao().Para("Playstation 3 Novo")
            .Lance(joao, 200.0)
            .Constroi();

            leiloeiro.Avalia(leilao);

            Assert.AreEqual(200, leiloeiro.MaiorLance, 0.0001);
            Assert.AreEqual(200, leiloeiro.MenorLance, 0.0001);
        }
        [Test]
        public void DeveEncontrarOsTresMaioresLances()
        {
            
            Leilao leilao = new CriadorLeilao().Para("Playstation 3 Novo")
            .Lance(joao, 100.0)
            .Lance(maria, 200.0)
            .Lance(joao, 300.0)
            .Lance(maria, 400.0)
            .Constroi();


            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(3, maiores.Count);
            Assert.AreEqual(400, maiores[0].Valor, 0.00001);
            Assert.AreEqual(300, maiores[1].Valor, 0.00001);
            Assert.AreEqual(200, maiores[2].Valor, 0.00001);
        }

        [Test]
        public void DeveEntenderLancesEmOrdemAleatoria()
        {
            

            Leilao leilao = new CriadorLeilao().Para("Playstation 3 Novo")
            .Lance(maria, 200.0)
            .Lance(joao, 450.0)
            .Lance(maria, 120.0)
            .Lance(joao, 700.0)
            .Lance(maria, 630.0)
            .Lance(joao, 230.0)
            .Constroi();
            


            leiloeiro.Avalia(leilao);
            double maiorEsperado = 700;
            double menorEsperado = 120;

            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance);
        }
        [Test]
        public void DeveEntenderLancesEmOrdemDecrescente()
        {
           
            Leilao leilao = new CriadorLeilao().Para("Playstation 3 Novo")
            .Lance(maria, 500.0)
            .Lance(joao, 400.0)
            .Lance(maria, 300.0)
            .Lance(joao, 200.0)
            .Lance(maria, 100.0)
            .Constroi();



            leiloeiro.Avalia(leilao);
            double maiorEsperado = 500;
            double menorEsperado = 100;

            Assert.AreEqual(maiorEsperado, leiloeiro.MaiorLance);
            Assert.AreEqual(menorEsperado, leiloeiro.MenorLance);
        }
        [Test]
        public void DeveEncontrarOsTresMaioresLancesComdoisItens()
        {
           
            Leilao leilao = new CriadorLeilao().Para("Playstation 3 Novo")
            .Lance(joao, 200.0)
            .Lance(maria, 100.0)
            .Constroi();

         


            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(2, maiores.Count);
            Assert.AreEqual(200, maiores[0].Valor, 0.00001);
            Assert.AreEqual(100, maiores[1].Valor, 0.00001);


        }
        [Test]
        public void DeveEncontrarOsTresMaioresLancesComNenhumItem()
        {
          
            Leilao leilao = new CriadorLeilao().Para("Playstation 3 Novo").Constroi();

            leiloeiro.Avalia(leilao);

            IList<Lance> maiores = leiloeiro.TresMaiores;

            Assert.AreEqual(0, maiores.Count);


        }
        [Test]
        public void NaoDeveAvaliarLeiloesSemNenhumLanceDado()
        {
            Leilao leilao = new CriadorLeilao().Para("Playstation 3 Novo").Constroi();

            Assert.That(() => leiloeiro.Avalia(leilao),
                    Throws.TypeOf<Exception>());
        }

    }
}
