namespace DatabaseThingy.Actions;
internal class CreateStudentAction : Action<(string, DateTime)>
{
    protected override void PerformSelf(Student o)
    {
        o.Name = Param.Item1;
        o.DateOfBirth = Param.Item2;
    }
}