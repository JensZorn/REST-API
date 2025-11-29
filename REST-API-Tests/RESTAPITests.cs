using System;
using NUnit.Framework;

namespace REST_API.Tests
{
    [TestFixture]
    public class RESTAPITests
    {
        [Test]
        public void TestTimestampControllerType()
        {
            var controller = new REST_API.Controllers.TimestampController();

            var result = controller.GetTimestamp();
            Assert.That(true == (result is REST_API.ServerTimestamp), "Result should be of type ServerTimestamp");
        }

        [Test]
        public void TestTimestampControllerTime()
        {
            var controller = new REST_API.Controllers.TimestampController();

            var result = controller.GetTimestamp();
            Assert.That(true == (result.Timestamp <= DateTime.Now), "Timestamp should be less than or equal to current server time");
        }
    }
}
