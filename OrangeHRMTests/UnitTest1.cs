using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OrangeHRMLiberary;

namespace OrangeHRMTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }

        [TestMethod]
        public void Check_Admin_User()
        {
            Navigation.GoTo();
            Credentials.LoginAs("Admin").WithPassword("admin123").Login();
            Assert.IsTrue(Navigation.IsAt("//a[@id='welcome'][contains(.,'Welcome Admin')]"), "This user is not Admin.");
        }



        [TestMethod]

        public void Check_Normal_User()
        {
            Navigation.GoTo();
            Credentials.LoginAs("fiona.grace").WithPassword("fiona.grace").Login();
            Assert.IsTrue(Navigation.IsAt("//a[@id='welcome'][contains(.,'Welcome Fiona')]"), "This user is not ESS.");
        }


        [TestCleanup]
        public void TestCleanup()
        {
            Driver.Close();
        }

    }
}
