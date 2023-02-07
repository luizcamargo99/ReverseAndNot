using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace ReverseAndNot.Tests;

public class ReverseAndNotTest
{
    [Theory]
    [InlineData(123, "321123")]
    [InlineData(123456789, "987654321123456789")]
    [InlineData(152, "251152")]
    public void FixedTest(int input, string resultExpected)
    {
        Assert.Equal(new ReverseAndNot().Run(input), resultExpected);
    }
}