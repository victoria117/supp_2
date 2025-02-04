namespace supplemental_2.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
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
}
