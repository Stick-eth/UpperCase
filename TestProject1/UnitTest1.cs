using System.Diagnostics;
using UpperCase;
using UpperCase.Model;
using UpperCase.ViewModel;

namespace TestProjectNameSpace
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [DataRow("input", "INPUT")]
        [DataRow("maison", "MAISON")]
        [DataRow("Corse123", "CORSE123")]
        [DataRow("%&ciel", "%&CIEL")]
        [DataRow("!*port", "!*PORT")]
        public void Tester(string x, string y)
        {
            ModelUpper modelUpper = new ModelUpper();
            ViewModelUpper viewModelUpper = new ViewModelUpper(modelUpper);
            Assert.AreEqual(viewModelUpper.Update(x), y);
        }
    }
}