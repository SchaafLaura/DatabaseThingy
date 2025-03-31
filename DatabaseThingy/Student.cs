namespace DatabaseThingy;
internal class Student
{
    private static uint runningID = 0;
    public static uint RunningID
    {
        get => runningID++;
        set => runningID = value;
    }

    public string? Name;
    public string? Email;
    public DateTime? DateOfBirth;
    public uint ID { get; init; }
}