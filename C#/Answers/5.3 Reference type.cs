public static void Run()
{
    ConsoleHelper ch = new ConsoleHelper();
    {
        Point point = new Point(3, 4);
        ch.TwoColumns("Before", $"point={point}");
        ChangePoint(point);
        ch.TwoColumns("After", $"point={point}");
    }

    Console.WriteLine();

    {
        StringBuilder sb = new StringBuilder("Let's go dancing.");
        ch.TwoColumns("Before", $"sb={sb}");
        ChangeStringBuilder(sb);
        ch.TwoColumns("After", $"sb={sb}");
    }
}

private static void ChangePoint(Point point)
{
    point.X = 999;
    point.Y = 888;
}

private static void ChangeStringBuilder(StringBuilder sb)
{
    sb.Append(" Yes that would be great!");
}

public class Point
{
    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return $"({X},{Y})";
    }
}