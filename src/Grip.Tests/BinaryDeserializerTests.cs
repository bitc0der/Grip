using System.Runtime.InteropServices;
using Grip.Data.Infrastructure;

namespace Grip.Tests;

[TestFixture]
public sealed class BinaryDeserializerTests
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

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    private struct TestStruct
    {
        public byte Value;
    }

    [Test]
    public void Should_DeserializeStructure_When_ValueIsArray()
    {
        // Arrange
        var buffer = new byte[] { 0xAF, 0x08 };

        // Act
        var result = BinaryDeserializer.Deserialize<TestStructWithArray>(buffer);

        // Assert
        Assert.That(result.Value, Is.EqualTo(buffer));
    }

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    private struct TestStructWithArray
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Value;
    }
}
