using AoC2022.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace AoC2022.Days;

public class Day03 : IDay
{
    private readonly IDataLoader _dataLoader;

    public Day03(IDataLoader? dataLoader = null)
    {
        _dataLoader = dataLoader ?? new DefaultDataLoader(nameof(Day03));
    }
    public string SolvePart1(DataSet dataSet)
    {
        var dataList = _dataLoader.GetInputList(dataSet);
        int total = 0;
        foreach (var line in dataList)
        {
            string ruck1 = line.Substring(0, line.Length / 2);
            string ruck2 = line.Substring(line.Length / 2);
            var t = (int)ruck1.Intersect(ruck2).First();
            total += ToCustomX(t);
        }
        return $"{total}";
    }

    public string SolvePart2(DataSet dataSet)
    {
        var dataList = _dataLoader.GetInputList(dataSet);
        int total = 0;
        for (int i = 0; i < dataList.Count(); i+=3)
        {
            var t1 = dataList.Take( new Range(i, i + 3)).ToList();
            var i1 = string.Join("",t1[0].Intersect(t1[1]).Select(x => x.ToString()).ToList());
            var i2 = (int)i1.Intersect(t1[2]).First();
            total += ToCustomX(i2);
        }

        return $"{total}";
    }
    private static int ToCustomX(int t)
    {
        return (t <= 90) ? t - 'A' + 1 + 26 : t - 'a' + 1;
    }
}
