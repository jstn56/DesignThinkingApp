using DesignThinking.Business.Repository;
using DesignThinking.Business.Service;
using DesignThinking.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            User user = new User();
            var userservice = new UserRepository();
            userservice.Save(user);
        }
    }
}
