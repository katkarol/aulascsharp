using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD.Matematica
{
    [TestFixture]
    public class MatematicaMalucaTeste
    {
        [Test]
        public void UtilizandoNumeroMaiorQue30()
        {
            int n1 = 35;
            int n2 = 98;


            MatematicaMaluca m = new MatematicaMaluca();

            Assert.AreEqual((n1 * 4), m.ContaMaluca(n1));
            Assert.AreEqual((n2 * 4), m.ContaMaluca(n2));

        }

        [Test]
        public void UtilizandoNumeroMaiorQue10()
        {
            int n1 = 30;
            int n2 = 25;
            int n3 = 12;
            int n4 = 19;

            MatematicaMaluca m = new MatematicaMaluca();


            Assert.AreEqual((n1 * 3), m.ContaMaluca(n1));
            Assert.AreEqual((n2 * 3), m.ContaMaluca(n2));
            Assert.AreEqual((n3 * 3), m.ContaMaluca(n3));
            Assert.AreEqual((n4 * 3), m.ContaMaluca(n4));

        }
        [Test]
        public void UtilizandoNumeroMenorQue10()
        {
            int n1 = 10;
            int n2 = 5;
            int n3 = 1;
            int n4 = 7;

            MatematicaMaluca m = new MatematicaMaluca();


            Assert.AreEqual((n1 * 2), m.ContaMaluca(n1));
            Assert.AreEqual((n2 * 2), m.ContaMaluca(n2));
            Assert.AreEqual((n3 * 2), m.ContaMaluca(n3));
            Assert.AreEqual((n4 * 2), m.ContaMaluca(n4));

        }
    }
}
