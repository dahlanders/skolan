class Circle
{
    string name;
    double radius;

    public Circle()
    {
        name = "Unknown";
        radius = 5;
    }

    public Circle(string incomingName)
    {
        name = incomingName;
        radius = 5;
    }

    public Circle(string incomingName, double incomingRadius)
    {
        name = incomingName;
        radius = incomingRadius;
    }

    public override string ToString()
    {
        return $"I'm a circle with name={name} and radius={radius}";
    }
}

public class Triangle
{
    double _x;
    double _y;
    double _baselength;
    double _height;

    public Triangle(double x, double y, double baselength, double height)
    {
        _x = x;
        _y = y;
        _baselength = baselength;
        _height = height;
    }

    public override string ToString()
    {
        return $"I'm a triangle with x={_x}, y={_y}, baselength={_baselength} and height={_height}";
    }
}

public class Rectangle
{
    double _height;
    double _width;
    double _x;
    double _y;

    public Rectangle(double height, double width)
    {
        _height = height;
        _width = width;
    }

    public Rectangle(double x, double y, double height, double width)
    {
        _x = x;
        _y = y;
        _height = height;
        _width = width;
    }

    public override string ToString()
    {
        return $"I'm a rectangle with height={_height} and width={_width}";
    }
}
