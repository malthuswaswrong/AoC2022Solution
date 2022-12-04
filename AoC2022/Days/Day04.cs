using AoC2022.Data;

namespace AoC2022.Days;

public class Day04 : IDay
{
    private readonly IDataLoader _dataLoader;

    public Day04(IDataLoader? dataLoader = null)
    {
        _dataLoader = dataLoader ?? new DefaultDataLoader(nameof(Day04));
    }

    public string SolvePart1(DataSet dataSet) => $"{_dataLoader.GetInputList(dataSet).Where(x => FullRangeOverlap(GetRanges(x))).Count()}";
    public string SolvePart2(DataSet dataSet) => $"{_dataLoader.GetInputList(dataSet).Where(x => PartialRangeOverlap(GetRanges(x))).Count()}";

    private (Range, Range) GetRanges(string input)
    {
        var segments = input.Split(",");
        var t1 = segments[0].Split("-").Select(x => int.Parse(x)).ToList();
        var t2 = segments[1].Split("-").Select(x => int.Parse(x)).ToList();
        return (new Range(t1[0], t1[1]), new Range(t2[0], t2[1]));
    }
    private bool FullRangeOverlap((Range, Range) set) => Overlap(set.Item1, set.Item2, true);
    
    private bool PartialRangeOverlap((Range, Range) set) => Overlap(set.Item1, set.Item2, false);
    
    private bool Overlap(Range range1, Range range2, bool full) =>
        (full)
        ? (range1.Start.Value <= range2.Start.Value && range1.End.Value >= range2.End.Value) || (range2.Start.Value <= range1.Start.Value && range2.End.Value >= range1.End.Value)
        : (range1.Start.Value <= range2.Start.Value && range1.End.Value >= range2.Start.Value) || (range2.Start.Value <= range1.Start.Value && range2.End.Value >= range1.Start.Value);

}
