using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoTDD.Palindromo
{
    [TestFixture]
    public class PalindromoTeste
    {
        [Test]
        public void DeveDarUmPalindromo()
        {
            string frase1 = "Socorram-me subi no onibus em Marrocos";
            string frase2 = "Anotaram a data da maratona";

            Palindromo palindromo = new Palindromo(); ;
            

            Assert.AreEqual(true, palindromo.EhPalindromo(frase1));
            Assert.AreEqual(true, palindromo.EhPalindromo(frase2));


        }
        [Test]
        public void NaoDeveDarUmPalindromo()
        {
            Palindromo palindromo = new Palindromo();

            string frase1 = "Programação";
            string frase2 = "Informação";

            Assert.AreEqual(false, palindromo.EhPalindromo(frase1));
            Assert.AreEqual(false, palindromo.EhPalindromo(frase2));

        }
    }
}
