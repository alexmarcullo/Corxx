using Corxx.Infra.IntegrationTests.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Corxx.Infra.IntegrationTests
{
    [TestClass]
    public class InfraIntegrationTests : CorxxFixtureContext
    {
        [TestMethod]
        public void Test()
        {
            
            Assert.IsTrue(true);
        }
    }
}
