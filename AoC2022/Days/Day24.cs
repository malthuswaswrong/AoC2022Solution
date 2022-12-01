using AoC2022.Data;

namespace AoC2022.Days;

public class Day24 : IDay
{
    private readonly IDataLoader _dataLoader;

    public Day24(IDataLoader? dataLoader = null)
    {
        _dataLoader = dataLoader ?? new DefaultDataLoader(nameof(Day24));
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
