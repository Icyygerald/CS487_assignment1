using NUnit.Framework;
using System;

namespace Password.Tests
{
    public class UuidUtilsTests
    {
        [Test]
        public void GenerateUuidV4_ReturnsValidV4Uuid()
        {
            string uuidStr = UuidUtils.GenerateUuidV4();
            Guid uuid = Guid.Parse(uuidStr);

            // Version check (stored in the 7th byte)
            byte version = (byte)((uuid.ToByteArray()[7] >> 4) & 0x0F);
            Assert.AreEqual(4, version);
        }
    }
}
