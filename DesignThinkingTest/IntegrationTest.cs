using DesignThinking.Business.Service;
using DesignThinking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DesignThinkingTest
{
    public class IntegrationTest
    {
        [Fact]
        public void Integration_Test()
        {
            User user = new User();
            var userService = new UserService();
            Assert.True(true);
             
        }


    }
}
