namespace AoC2022.Data;

public class DefaultDataLoader : IDataLoader
{
    private readonly string _day;
    public string DataDir => Path.Combine("..", "..", "..", "..", "AoC2022", "Data", _day);
    public string ExampleFile => Path.Combine(DataDir, "example.txt");
    public string ChallengeFile => Path.Combine(DataDir, "challenge.txt");
    public string BigBoiFile => Path.Combine(DataDir, "bigboi.txt");

    public DefaultDataLoader(string day)
    {
        _day = day;
    }

    public StreamReader GetInputStreamReader(DataSet dataSet)
    {
        string file = dataSet switch
        {
            DataSet.Example => ExampleFile,
            DataSet.Challenge => ChallengeFile,
            DataSet.BigBoi => BigBoiFile,
            _ => throw new ArgumentOutOfRangeException(nameof(dataSet), dataSet, null)
        };

        return new StreamReader(file);
    }

    public string GetInputString(DataSet dataSet) => GetInputStreamReader(dataSet).ReadToEnd();

    public string[] GetInputArray(DataSet dataSet) => GetInputString(dataSet).Split(Environment.NewLine);

    public List<string> GetInputList(DataSet dataSet) => GetInputArray(dataSet).ToList();

}