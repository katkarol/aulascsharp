using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD.AnosBissextos
{
    [TestFixture]
    public class AnoBissextoTeste
    {
        [Test]
        public void DeveDarAnoBissexto()
        {
            int tentativa1 = 2016;
            int tentativa2 = 1604;
            int tentativa3 = 2000;
            int tentativa4 = 1280;

            AnoBissexto AB = new AnoBissexto();

            Assert.AreEqual(true, AB.EhBissexto(tentativa1));
            Assert.AreEqual(true, AB.EhBissexto(tentativa2));
            Assert.AreEqual(true, AB.EhBissexto(tentativa3));
            Assert.AreEqual(true, AB.EhBissexto(tentativa4));


        }

        [Test]
        public void NaoDeveDarAnoBissexto()
        {
            int tentativa1 = 2018;
            int tentativa2 = 1053;
            int tentativa3 = 1322;
            int tentativa4 = 1989;

            AnoBissexto AB = new AnoBissexto();

            Assert.AreEqual(false, AB.EhBissexto(tentativa1));
            Assert.AreEqual(false, AB.EhBissexto(tentativa2));
            Assert.AreEqual(false, AB.EhBissexto(tentativa3));
            Assert.AreEqual(false, AB.EhBissexto(tentativa4));


        }
    }
}
