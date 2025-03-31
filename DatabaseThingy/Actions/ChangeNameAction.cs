namespace DatabaseThingy.Actions;
internal sealed class ChangeNameAction : Action<string>
{
    protected override void PerformSelf(Student o)
    {
        o.Name = Param!;
    }
}