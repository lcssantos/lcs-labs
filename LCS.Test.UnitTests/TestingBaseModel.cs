using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LCS.Core.Domain;

namespace LCS.Test.UnitTests
{
    [TestClass]
    public class TestingBaseModel
    {
        [TestMethod]
        public void TestId()
        {
            var id = Guid.NewGuid();
            var model = new BaseModel();

            model.Id = id;

            Assert.AreEqual(id, model.Id);
        }
    }
}
