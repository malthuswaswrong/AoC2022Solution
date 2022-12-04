using AoC2022.Data;

namespace AoC2022.Days;

public class Day04 : IDay
{
    private readonly IDataLoader _dataLoader;

    public Day04(IDataLoader? dataLoader = null)
    {
        _dataLoader = dataLoader ?? new DefaultDataLoader(nameof(Day04));
    }
    
    public string SolvePart1(DataSet dataSet) => $"{_dataLoader.GetInputList(dataSet).Where(x => Overlap(GetRanges(x), true)).Count()}";
    public string SolvePart2(DataSet dataSet) => $"{_dataLoader.GetInputList(dataSet).Where(x => Overlap(GetRanges(x), false)).Count()}";

    private (Range, Range) GetRanges(string input)
    {
        var segments = input.Split(",");
        var t1 = segments[0].Split("-").Select(x => int.Parse(x)).ToList();
        var t2 = segments[1].Split("-").Select(x => int.Parse(x)).ToList();
        return (new Range(t1[0], t1[1]), new Range(t2[0], t2[1]));
    }
    private bool Overlap((Range, Range) set, bool full) =>
        (full)
        ? (set.Item1.Start.Value <= set.Item2.Start.Value && set.Item1.End.Value >= set.Item2.End.Value) || (set.Item2.Start.Value <= set.Item1.Start.Value && set.Item2.End.Value >= set.Item1.End.Value)
        : (set.Item1.Start.Value <= set.Item2.Start.Value && set.Item1.End.Value >= set.Item2.Start.Value) || (set.Item2.Start.Value <= set.Item1.Start.Value && set.Item2.End.Value >= set.Item1.Start.Value);

}
