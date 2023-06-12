using NUnit.Framework;
using OldPhonePad;

[TestFixture]
public class OldPhonePadClassTests
{
    [Test]
    public void Test1()
    {
        // Arrange
        string input = "222 2 22";
        string expectedOutput = "C";

        // Act
        string result = OldPhonePadClass.OldPhonePad(input);

        // Assert
        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Test2()
    {
        string input = "33#";
        string expectedOutput = "E";

        string result = OldPhonePadClass.OldPhonePad(input);

        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Test3()
    {
        string input = "227*#";
        string expectedOutput = "B";

        string result = OldPhonePadClass.OldPhonePad(input);

        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Test4()
    {
        string input = "4433555 555666#";
        string expectedOutput = "HELLO";

        string result = OldPhonePadClass.OldPhonePad(input);

        Assert.AreEqual(expectedOutput, result);
    }

    [Test]
    public void Test5()
    {
        string input = "8 88777444666*664#";
        string expectedOutput = "TURING";

        string result = OldPhonePadClass.OldPhonePad(input);

        Assert.AreEqual(expectedOutput, result);
    }
}
