using AoC2022.Data;

namespace AoC2022.Days;

public class Day02 : IDay
{
    private readonly IDataLoader _dataLoader;
    public Day02(IDataLoader? dataLoader = null)
    {
        _dataLoader = dataLoader ?? new DefaultDataLoader(nameof(Day02));
    }
    public string SolvePart1(DataSet dataSet)
    {
        var dataList = _dataLoader.GetInputList(dataSet).Select(x => CompetitionInput1.Parse(x));
        long totalScore = dataList?.Sum(x => x.Score) ?? 0;
        return $"{totalScore}";
    }

    public string SolvePart2(DataSet dataSet)
    {
        var dataList = _dataLoader.GetInputList(dataSet).Select(x => CompetitionInput2.Parse(x));
        long totalScore = dataList?.Sum(x => x.Score) ?? 0;
        return $"{totalScore}";
    }
    public abstract class CompetitionInputBase
    {
        public HandShape Opponent;
        public HandShape Mine;
        public Victory Status;
        public int Score => (int)Mine + (int)Status;
        public enum HandShape
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }
        public enum Victory
        {
            Win = 6,
            Draw = 3,
            Loss = 0,
        }
    }
    public class CompetitionInput1 : CompetitionInputBase
    {        
        CompetitionInput1(string input)
        {
            var t = input.Split(' ');
            Opponent = t[0] switch
            {
                "A" => HandShape.Rock,
                "B" => HandShape.Paper,
                "C" => HandShape.Scissors,
                _ => throw new Exception("Invalid input")
            };
            Mine = t[1] switch
            {
                "X" => HandShape.Rock,
                "Y" => HandShape.Paper,
                "Z" => HandShape.Scissors,
                _ => throw new Exception("Invalid input")
            };
            Status = (Mine, Opponent) switch
            {
                (HandShape.Rock, HandShape.Scissors) => Victory.Win,
                (HandShape.Scissors, HandShape.Paper) => Victory.Win,
                (HandShape.Paper, HandShape.Rock) => Victory.Win,
                (HandShape.Rock, HandShape.Rock) => Victory.Draw,
                (HandShape.Scissors, HandShape.Scissors) => Victory.Draw,
                (HandShape.Paper, HandShape.Paper) => Victory.Draw,
                _ => Victory.Loss
            };
        }
        public static CompetitionInput1 Parse(string input)
        {
            return new CompetitionInput1(input);
        }
    }
    public class CompetitionInput2 : CompetitionInputBase
    {

        CompetitionInput2(string input)
        {
            var t = input.Split(' ');
            Opponent = t[0] switch
            {
                "A" => HandShape.Rock,
                "B" => HandShape.Paper,
                "C" => HandShape.Scissors,
                _ => throw new Exception("Invalid input")
            };
            Status = t[1] switch
            {
                "X" => Victory.Loss,
                "Y" => Victory.Draw,
                "Z" => Victory.Win,
                _ => throw new Exception("Invalid input")
            };

            Mine = GetRequired(Status, Opponent);
        }
        public static CompetitionInput2 Parse(string input)
        {
            return new CompetitionInput2(input);
        }
        private static HandShape GetRequired(Victory desired, HandShape theirs)
        {
            return (desired, theirs) switch
            {
                (Victory.Loss, HandShape.Rock) => HandShape.Scissors,
                (Victory.Loss, HandShape.Scissors) => HandShape.Paper,
                (Victory.Loss, HandShape.Paper) => HandShape.Rock,
                (Victory.Win, HandShape.Rock) => HandShape.Paper,
                (Victory.Win, HandShape.Scissors) => HandShape.Rock,
                (Victory.Win, HandShape.Paper) => HandShape.Scissors,
                (Victory.Draw, _) => theirs,
                _ => throw new Exception("Invalid input")
            };
        }
        
    }
}
