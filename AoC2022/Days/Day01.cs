using AoC2022.Data;
using System.Data;

namespace AoC2022.Days;

public class Day01 : IDay
{
    private readonly IDataLoader _dataLoader;

    public Day01(IDataLoader? dataLoader = null)
    {
        _dataLoader = dataLoader ?? new DefaultDataLoader(nameof(Day01));
    }
    private IOrderedEnumerable<long> OrderedCalorieList(DataSet dataSet)
    {
        var dataArray = _dataLoader.GetInputArray(dataSet);
        List<long> calorieList = new();
        long currCalories = 0;
        foreach (var line in dataArray)
        {
            if (long.TryParse(line, out long tmpCalories))
            {
                currCalories += tmpCalories;
            }
            else
            {
                calorieList.Add(currCalories);
                currCalories = 0;
            }
        }
        calorieList.Add(currCalories);
        return calorieList.OrderByDescending(x => x);
    }
    public string SolvePart1(DataSet dataSet) => OrderedCalorieList(dataSet).First().ToString();
    public string SolvePart2(DataSet dataSet) => OrderedCalorieList(dataSet).Take(3).Sum().ToString();    
}
