using AoC2022.Days;

namespace AoC2022Tests;

public class Challenges
{
    [Theory]
    [InlineData(DataSet.Example, "24000")]
    [InlineData(DataSet.Challenge, "70764")]
    public void Day01_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day01();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }
    
    [Theory]
    [InlineData(DataSet.Example, "45000")]
    [InlineData(DataSet.Challenge, "203905")]
    public void Day01_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day01();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "15")]
    [InlineData(DataSet.Challenge, "15337")]
    public void Day02_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day02();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "12")]
    [InlineData(DataSet.Challenge, "11696")]
    public void Day02_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day02();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }
    
    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day03_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day03();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day03_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day03();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day04_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day04();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day04_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day04();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day05_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day05();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day05_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day05();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day06_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day06();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day06_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day06();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day07_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day07();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day07_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day07();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day08_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day08();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day08_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day08();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day09_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day09();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day09_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day09();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day10_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day10();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day10_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day10();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day11_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day11();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day11_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day11();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day12_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day12();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day12_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day12();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day13_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day13();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day13_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day13();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day14_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day14();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day14_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day14();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day15_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day15();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day15_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day15();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day16_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day16();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day16_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day16();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day17_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day17();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day17_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day17();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day18_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day18();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day18_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day18();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day19_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day19();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day19_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day19();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day20_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day20();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day20_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day20();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day21_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day21();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day21_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day21();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day22_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day22();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day22_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day22();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day23_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day23();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day23_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day23();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day24_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day24();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day24_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day24();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day25_Part1(DataSet dataSet, string actual)
    {
        var cut = new Day25();
        Assert.Equal(actual, cut.SolvePart1(dataSet));
    }

    [Theory]
    [InlineData(DataSet.Example, "")]
    [InlineData(DataSet.Challenge, "")]
    public void Day25_Part2(DataSet dataSet, string actual)
    {
        var cut = new Day25();
        Assert.Equal(actual, cut.SolvePart2(dataSet));
    }

}