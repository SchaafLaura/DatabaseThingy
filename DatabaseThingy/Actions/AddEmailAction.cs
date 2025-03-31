namespace DatabaseThingy.Actions;
internal sealed class AddEmailAction : Action<string>
{
    protected override void PerformSelf(Student o)
    {
        o.Email = Param!;
    }
}