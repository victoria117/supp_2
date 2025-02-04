using System;
using Xunit;
using supplemental_2;

public class UnitTests
{
    [Fact]
    public void TestNormalDistribution()
    {
        double mean = 50;
        double stdDev = 10;
        int sampleSize = 10000;
        double sum = 0;
        double sumSq = 0;

        for (int i = 0; i < sampleSize; i++)
        {
            double value = RandomUtils.GenerateNormal(mean, stdDev);
            sum += value;
            sumSq += value * value;
        }

        double sampleMean = sum / sampleSize;
        double sampleVariance = (sumSq / sampleSize) - (sampleMean * sampleMean);
        double sampleStdDev = Math.Sqrt(sampleVariance);

        Assert.InRange(sampleMean, mean - 1, mean + 1);
        Assert.InRange(sampleStdDev, stdDev - 1, stdDev + 1);
    }

   [Fact]
    public void TestPasswordGenerator()
    {
        int length = 8;
        string password = RandomUtils.GeneratePassword(length);

        Assert.Equal(length, password.Length);
        Assert.Matches(@"^[A-Za-z0-9_]+$", password);
    }


 [Fact]
    public void TestRandomColorGenerator()
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






