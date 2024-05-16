namespace IntelliTect.CSharp.CodingGuidelines;



public readonly record struct Coordinate
{
    public double Longitude { get; } = 42;
    public double Latitude { get; }
    
    // Allowable in C# 10
    public Coordinate()
    {
        Latitude = 490;
    }
}

record class Location (string Name)
{
    public Coordinate Coordinate { get; set; }
}

[TestClass]
public class CoordinateTests
{
    [TestMethod]
    public void DefaultConstructorIsNotExecuted ()
    {
        Coordinate coordinate = default;
        Assert.AreEqual<double>(0, coordinate.Longitude);
        Assert.AreEqual<double>(0, coordinate.Latitude);
    }

    [TestMethod]
    public void CoordinateIsNotInitializedByConstructor()
    {
        Location location = new ("Timbuktu");
        Assert.AreEqual<double>(0, location.Coordinate.Longitude);
        Assert.AreEqual<double>(0, location.Coordinate.Latitude);
    }
}