namespace DatabaseThingy.Actions;
internal sealed class ChangeDateOfBirthAction : Action<DateTime>
{
    protected override void PerformSelf(Student o)
    {
        o.DateOfBirth = Param!;
    }
}