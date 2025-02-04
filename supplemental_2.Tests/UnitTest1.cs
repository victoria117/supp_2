namespace supplemental_2.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        int length = 8;
        string password = RandomUtils.GeneratePassword(length);

        Assert.Equal(length, password.Length);
        Assert.Matches(@"^[A-Za-z0-9_]+$", password);
    }








}
