using AoC2022.Days;

namespace AoC2022Tests;

public class Challenges
{
    [Theory]
    [InlineData(DataSet.Example, "24000")]
    [InlineData(DataSet.Challenge, "70764")]
    public void Day1_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day01();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }
    
    [Theory]
    [InlineData(DataSet.Example, "45000")]
    [InlineData(DataSet.Challenge, "203905")]
    public void Day1_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day01();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }
}