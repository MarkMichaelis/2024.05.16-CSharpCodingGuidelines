namespace IntelliTect.CSharp.CodingGuidelines;

readonly record struct Person(string? FirstName, string? LastName)
{
    public Person(string firstName, string lastName, string middleName) 
        : this(firstName, lastName)
    {
        MiddleName = middleName;
    }

    //public string Name { get; set; }
    public string? MiddleName { get; init; }

    public static Person Create(string firstName, string lastName, string middleName)
    {
        return new Person(firstName, lastName) { MiddleName = middleName};
    }
}


[TestClass]
public class PersonTests
{
    [TestMethod]
    public void DefaultConstructorIsNotExecuted()
    {
        Person person = new("Inigo", "Montoya");
        Assert.AreEqual(("Inigo", "Montoya"), (person.FirstName, person.LastName));
    }
}