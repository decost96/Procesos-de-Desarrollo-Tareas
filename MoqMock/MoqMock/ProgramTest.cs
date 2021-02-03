using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace MoqMock
{
    [TestClass]
    public class ProgramTest
    {
        [TestMethod]
        public void ShouldThrowArgumentExceptionTest()
        {
            var mockLog = new Mock();

            //cuando se llame al método log, escribimos en el output
            mockLog.Setup(l => l.Log(It.IsAny())).Callback(param => System.Diagnostics.Debug.Write(param));

            var mockHtmlValidator = new Mock();

            //al validar html queremos comprobar como se comporta el blog si no es valido
            mockHtmlValidator.Setup(v => v.IsValid(It.IsAny())).Returns(false);

            BlogService blog = new BlogService(mockHtmlValidator.Object, mockLog.Object);

            bool testOK = false;

            try
            {
                blog.PublicPost("html no valido");
            }
            catch (ArgumentException ex)
            {
                
                testOK = true;
            }

            Assert.IsTrue(testOK);
        }
    }
}