using AoC2022.Data;

namespace AoC2022.Days;

public class Day17 : IDay
{
    private readonly IDataLoader _dataLoader;

    public Day17(IDataLoader? dataLoader = null)
    {
        _dataLoader = dataLoader ?? new DefaultDataLoader(nameof(Day17));
    }
    public string SolvePart1(DataSet dataSet)
    {
        var dataList = _dataLoader.GetInputList(dataSet);
        throw new NotImplementedException();
    }

    public string SolvePart2(DataSet dataSet)
    {
        var dataList = _dataLoader.GetInputList(dataSet);
        throw new NotImplementedException();
    }
}
