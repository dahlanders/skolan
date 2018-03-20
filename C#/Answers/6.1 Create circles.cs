class Circle
{
    string name;
    double radius;

    public Circle(string incomingName, double incomingRadius)
    {
        name = incomingName;
        radius = incomingRadius;
    }

    public void SayHello()
    {
        Console.WriteLine($"I'm a circle with the name {name}!");
    }

    public void WriteArea()
    {
        double area = radius * radius * Math.PI;
        Console.WriteLine($"My name is {name}. I have a radius of {radius} and an area of {area:.##}");
    }

}
