using SignInLib;
namespace TestProjectOne
{
    [TestClass]
    public class SignInTest
    {
        [TestMethod]
        public void SuccessMethod()
        {
            string expResult = "Valid user";
            Assert.AreEqual(expResult,SignIn.Authenticate("sam","sam@1256"));
        }
        [TestMethod]
        public void FailureMethod()
        {
            string expResult = "invalid User credential"; 
            Assert.AreEqual(expResult, SignIn.Authenticate("ravi", "ravi@124"));
        }
        [TestMethod]
        public void AnonymousMethod()
        {
            string expResult = "You Must Provide Username and Password";
            Assert.AreEqual(expResult, SignIn.Authenticate(null,null));
        }
    }
}