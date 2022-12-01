using AoC2022.Data;

namespace AoC2022.Days;

public class Day13 : IDay
{
    private readonly IDataLoader _dataLoader;

    public Day13(IDataLoader? dataLoader = null)
    {
        _dataLoader = dataLoader ?? new DefaultDataLoader(nameof(Day13));
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
