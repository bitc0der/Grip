using Grip.Data.Infrastructure;

namespace Grip.Tests;

public class BinaryDeserializerTests
{
    [Test]
    public void Should_DeserializeStructure()
    {
        // Arrange
        var buffer = new byte[] { 0xAF };

        // Act
        var result = BinaryDeserializer.Deserialize<TestStruct>(buffer);

        // Assert
        Assert.That(result.Value, Is.EqualTo(0xAF));
    }

    private struct TestStruct
    {
        public byte Value;
    }
}
