using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Web;
using System.Net.Http;
using EADCA3;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            EADCA3.Pages.Index r1 = new EADCA3.Pages.Index();
            r1.setMeal("chicken");
            r1.searchRecipe();

            EADCA3.Pages.Index r2 = new EADCA3.Pages.Index();
            r2.setMeal("meat%%");
            r2.searchRecipe();

            Assert.AreEqual(r1.getInvalidInput(),false);
            Assert.AreEqual(r2.getInvalidInput(), true);
        }
    }
}
