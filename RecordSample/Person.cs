namespace RecordSample;

public record Person
{
    public string FirstName { get; init; } = "";
    public string LastName { get; init; } = "";
    public int Age { get; init; }
}