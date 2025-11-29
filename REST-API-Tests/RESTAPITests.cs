using System;
using NUnit.Framework;

namespace REST_API.Tests
{
    [TestFixture]
    public class RESTAPITests
    {
        [Test]
        public void TestServerTimestampType()
        {
            var timestamp = new REST_API.ServerTimestamp
            {
                Timestamp = DateTime.Now
            };
            Assert.That(timestamp is not null, "ServerTimestamp instance should not be null");
            Assert.That(timestamp.Timestamp is DateTime, "Timestamp property should be of type DateTime");
        }

        [Test]
        public void TestTimestampControllerType()
        {
            var controller = new REST_API.Controllers.TimestampController();

            var result = controller.GetTimestamp();
            Assert.That(result is REST_API.ServerTimestamp, "Result should be of type ServerTimestamp");
        }

        [Test]
        public void TestTimestampControllerTime()
        {
            var controller = new REST_API.Controllers.TimestampController();

            var result = controller.GetTimestamp();
            // Hier sollten wahrscheinlich Tests mit genauen Vorgaben für die Zeitdifferenz gemacht werden. (z.B. max. 2 Sekunden Differenz)
            // z.B. Assert.That((DateTime.Now - result.Timestamp).TotalSeconds < 2, "Timestamp should be within 2 seconds of current server time");
            Assert.That(result.Timestamp <= DateTime.Now, "Timestamp should be less than or equal to current server time");
        }
    }
}
