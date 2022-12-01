
using AoC2022.Days;

string dataBaseDir = Path.Combine("..", "..", "..", "Data");
for (int i = 1; i <= 25; i++)
{
    string dayDir = Path.Combine(dataBaseDir, $"Day{i:00}");
    if (Directory.Exists(dayDir))
    {
        continue;
    }
    Console.WriteLine($"Making {dayDir}");
    Directory.CreateDirectory(dayDir);
    File.WriteAllText(Path.Combine(dayDir, "example.txt"), "");
    File.WriteAllText(Path.Combine(dayDir, "challenge.txt"), "");
    File.WriteAllText(Path.Combine(dayDir, "bigboi.txt"), "");
}
while (true)
{
    try
    {
        Console.Write("Day (1 - 25): ");
        var inputDay = Console.ReadLine()!;
        if (!int.TryParse(inputDay, out var day)) continue;
        IDay handle = day switch
        {
            1 => new Day01(),
            2 => new Day02(),
            3 => new Day03(),
            4 => new Day04(),
            5 => new Day05(),
            6 => new Day06(),
            7 => new Day07(),
            8 => new Day08(),
            9 => new Day09(),
            10 => new Day10(),
            11 => new Day11(),
            12 => new Day12(),
            13 => new Day13(),
            14 => new Day14(),
            15 => new Day15(),
            16 => new Day16(),
            17 => new Day17(),
            18 => new Day18(),
            19 => new Day19(),
            20 => new Day20(),
            21 => new Day21(),
            22 => new Day22(),
            23 => new Day23(),
            24 => new Day24(),
            25 => new Day25(),
            _ => throw new InvalidInputException()
        };

        Console.Write("Data Set ([e]xample, [c]hallenge, [b]igboi): ");
        string inputDataSet = Console.ReadLine()!.ToLower();
        DataSet dataSet = inputDataSet switch
        {
            "e" => DataSet.Example,
            "c" => DataSet.Challenge,
            "b" => DataSet.BigBoi,
            _ => throw new InvalidInputException()
        };

        Console.Write("Part ([1], [2]): ");
        string inputPart = Console.ReadLine()!;
        string result = inputPart switch
        {
            "1" => handle.SolvePart1(dataSet),
            "2" => handle.SolvePart2(dataSet),
            _ => throw new InvalidInputException()
        };
        Console.WriteLine($"Result: {result}");
    }
    catch (InvalidInputException)
    {
        Exit();
    }
}

void Exit()
{
    Console.WriteLine("Unknown input. Exiting.");
    Environment.Exit(0);
}
