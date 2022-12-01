namespace AoC2022.Data
{
    public interface IDataLoader
    {
        string BigBoiFile { get; }
        string ChallengeFile { get; }
        string DataDir { get; }
        string ExampleFile { get; }

        string[] GetInputArray(DataSet dataSet);
        List<string> GetInputList(DataSet dataSet);
        StreamReader GetInputStreamReader(DataSet dataSet);
        string GetInputString(DataSet dataSet);
    }
}