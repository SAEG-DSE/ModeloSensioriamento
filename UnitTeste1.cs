using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OcrTeste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Programa capt = new Programa;
			capt.main("'1';'2'");
        }
    }
}
