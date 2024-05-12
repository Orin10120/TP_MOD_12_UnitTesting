using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TP_MOD_12_1302223023;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CariTandaBilangan_InputNegatif_ReturnsNegatif()
        {
            Form1 form = new Form1();
            int input = -5;
            string Eo = "Negatif";

            //act
            string output = form.CariTandaBilangan(input);

            //ass
            Assert.AreEqual(Eo, output);
        }

        [TestMethod]
        public void CariTandaBilangan_InputPositif_ReturnsPositif()
        {
            Form1 form = new Form1();
            int input = 5;
            string Eo = "Positif";

            //act
            string output = form.CariTandaBilangan(input);

            //ass
            Assert.AreEqual(Eo, output);
        }

        [TestMethod]
        public void CariTandaBilangan_InputNol_ReturnsNol()
        {
            Form1 form = new Form1();
            int input = 0;
            string Eo = "Nol";

            //act
            string output = form.CariTandaBilangan(input);

            //ass
            Assert.AreEqual(Eo, output);
        }
    }
}
