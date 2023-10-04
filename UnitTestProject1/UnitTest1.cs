using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using pizzeria;
using pizzeria.Strategies;
using System.IO;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var Carbonara = new carbonara();
            var text = "Заказ пицца карбонара";
            var stringWriter = new StringWriter();
            Console.SetOut(stringWriter);

            //act
            carbonara.carbonara1();

            //assert
            var output = stringWriter.ToString();
            Assert.AreEqual($"{text}\r\n", output);
        }
    }
}
