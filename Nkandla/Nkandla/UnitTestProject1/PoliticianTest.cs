using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Nkandla
{
    [TestClass]
    public class PoliticianTest
    {
        Politician _politician;

        [TestInitialize]
        public void initilialise()
        {
            _politician = new Politician();
            _politician.Name = "A Jerk";
        }

        [TestMethod]
        public void VisitTest()
        {
            HomeStead homestead = new Nkandla();
            homestead.Name = "Nkandla";

            var stdOut = Console.Out;
            var output = new StringWriter();
            Console.SetOut(output);

            _politician.visit(homestead);

            Console.SetOut(stdOut);
            
            Assert.AreEqual("A Jerk is now visiting the Nkandla home stead\r\n", output.ToString());
        }
    }
}
