using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using EquazioniLibrary;

namespace EquazioniLibrary.Test
{
    [TestClass]
    public class Equazioni_Test
    {

        [TestMethod]
        public void TestMethod1()
        {

            double a = 3;
            bool risposta_aspettata = true;
            bool risposta = Equazioni.IsDetermined(a);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
            
            [TestMethod]
        public void TestMethod2()
        {
            double a = 3;
            bool risposta2_aspettata = false;
            bool risposta2 = Equazioni.IsInconsisted(a);
            Assert.AreEqual(risposta2_aspettata, risposta2);
            
        }
        [TestMethod]
        public void TestMethod3()
        {
            double a = 3;
            bool risposta_aspettata = false;
            bool risposta = Equazioni.IsDegree2(a);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        [TestMethod]
        public void TestMethod4()
        {
            double a = 1;
            double b = 3;
            double c = -18;
            double risposta_aspettata = 81;
            double risposta = Equazioni.Delta(a,b,c);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
        public void TestMethod5()
        {
            double a = 2;
            double b = 4;
            double risposta_aspettata = -2;
            double risposta = Equazioni.EquationDegree1(a, b);
            Assert.AreEqual(risposta_aspettata, risposta);
        }
    }
}
