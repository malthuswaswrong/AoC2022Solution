using AoC2022.Data;

namespace AoC2022.Days;

public class Day04 : IDay
{
    private readonly IDataLoader _dataLoader;

    public Day04(IDataLoader? dataLoader = null)
    {
        _dataLoader = dataLoader ?? new DefaultDataLoader(nameof(Day04));
    }
    public string SolvePart1(DataSet dataSet)
    {
        var dataList = _dataLoader.GetInputList(dataSet);
        int overlapCount = 0;
        foreach (var set in dataList)
        {
            var segments = set.Split(",");
            var t1 = segments[0].Split("-").Select(x => int.Parse(x)).ToList();
            var t2 = segments[1].Split("-").Select(x => int.Parse(x)).ToList();
            var range1 = new Range(t1[0], t1[1]);
            var range2 = new Range(t2[0], t2[1]);
            if (range1.FullOverlap(range2))
            {
                overlapCount++;
            }
        }
        return $"{overlapCount}";
    }

    public string SolvePart2(DataSet dataSet)
    {
        var dataList = _dataLoader.GetInputList(dataSet);
        int overlapCount = 0;
        foreach (var set in dataList)
        {
            var segments = set.Split(",");
            var t1 = segments[0].Split("-").Select(x => int.Parse(x)).ToList();
            var t2 = segments[1].Split("-").Select(x => int.Parse(x)).ToList();
            var range1 = new Range(t1[0], t1[1]);
            var range2 = new Range(t2[0], t2[1]);
            if (range1.PartialOverlap(range2))
            {
                overlapCount++;
            }
        }
        return $"{overlapCount}";
    }
}
file static class ElfExtensions
{
    public static bool FullOverlap(this Range range1, Range range2)
    {
        return (range1.Start.Value <= range2.Start.Value && range1.End.Value >= range2.End.Value) || (range2.Start.Value <= range1.Start.Value && range2.End.Value >= range1.End.Value);
    }
    public static bool PartialOverlap(this Range range1, Range range2)
    {
        return (range1.Start.Value <= range2.Start.Value && range1.End.Value >= range2.Start.Value) || (range2.Start.Value <= range1.Start.Value && range2.End.Value >= range1.Start.Value);
    }
}
