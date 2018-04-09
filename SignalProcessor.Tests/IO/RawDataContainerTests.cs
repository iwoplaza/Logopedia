using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SignalProcessor.IO;

namespace SignalProcessor.Tests
{
    [TestFixture]
    public class RawDataContainerTests
    {
        [Test]
        public void Length_SetGetCheck()
        {
            var container = new RawDataContainer<double>(5);

            Assert.That(container.Length, Is.EqualTo(5));
        }

        [Test]
        public void SetSample_SetGetCheck()
        {
            var container = new RawDataContainer<double>(5);
            uint index = 0;
            double value = 0.5;

            container.SetSample(index, value);

            Assert.That(container.GetSample(index), Is.EqualTo(value));
        }
    }
}
