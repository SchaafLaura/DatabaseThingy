using Action = DatabaseThingy.Actions.Action;
namespace DatabaseThingy;
internal class Database
{
    private readonly Dictionary<uint, SortedList<DateTime, Action>> _studentEvents = [];
    public void Append(Action a)
    {
        if (!_studentEvents.TryGetValue(a.StudentID, out _))
            _studentEvents[a.StudentID] = [];

        a.CreatedAt = DateTime.Now;
        _studentEvents[a.StudentID].Add(a.CreatedAt, a);
    }
    public Student? GetCurrent(uint studentID)
    {
        if (!_studentEvents.TryGetValue(studentID, out var list))
            return null;
        var s = new Student();
        foreach (var (_, a) in list)
            a.Perform(s);
        return s;
    }
}