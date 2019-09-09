using Microsoft.VisualStudio.TestTools.UnitTesting;
using module_06;

namespace ReflectIt.Tests
{
    [TestClass]
    public class IoCTests
    {
        [TestMethod]
        public void Can_Resolve_Types()
        {
            var ioc = new Container();
            ioc.For<ILogger>().Use<SqlServerLogger>();

            var logger = ioc.Resolve<ILogger>();

            Assert.AreEqual(typeof(SqlServerLogger), logger.GetType());
        }
    }
}
