using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nkandla
{
    [TestClass]
    public class NkandlaTest
    {
        private Nkandla _nkandla;

        [TestInitialize]
        public void initialise()
        {
            _nkandla = new Nkandla();
            _nkandla.Name = "Nkandla";
            _nkandla.Country = "South Africa";
            _nkandla.District = "WhoKnowsWhere";           
        }

        [TestMethod]
        public void AcceptWelcomeTest()
        {
            Politician jz = new Politician();
            jz.Name = "Jacob Zuma";
            jz.Party = Party.ANC;

            _nkandla.Accept(jz);
        }

        [TestMethod]
        [ExpectedException(typeof(UnwelcomeVisitorException))]
        public void AcceptUnwelcomeTest()
        {
            Politician hz = new Politician();
            hz.Name = "Jacob Zuma";
            hz.Party = Party.DA;

            _nkandla.Accept(hz);
        }


    }
}
