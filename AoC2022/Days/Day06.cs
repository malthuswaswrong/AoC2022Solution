using AoC2022.Data;

namespace AoC2022.Days;

public class Day06 : IDay
{
    private readonly IDataLoader _dataLoader;

    public Day06(IDataLoader? dataLoader = null)
    {
        _dataLoader = dataLoader ?? new DefaultDataLoader(nameof(Day06));
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
