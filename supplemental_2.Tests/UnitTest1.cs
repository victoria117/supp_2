namespace supplemental_2.Tests;

public class UnitTest1
{
        int length = 8;
        string password = RandomUtils.GeneratePassword(length);

        Assert.Equal(length, password.Length);
        Assert.Matches(@"^[A-Za-z0-9_]+$", password);
    }


    [Fact]
    public void Test1()
    {
        var (hex, (r, g, b)) = RandomUtils.GenerateRandomColor();

        Assert.Matches(@"^#[0-9A-Fa-f]{6}$", hex);
        Assert.InRange(r, 0, 255);
        Assert.InRange(g, 0, 255);
        Assert.InRange(b, 0, 255);

        string expectedHex = $"#{r:X2}{g:X2}{b:X2}";
        Assert.Equal(expectedHex, hex);
    }
}






