namespace DatabaseThingy.Actions;
internal class Action
{
    public required uint StudentID { get; init; }
    public DateTime CreatedAt { get; set; }

    public void Perform(Student o)
    {
        CheckParam();
        PerformSelf(o);
    }
    protected virtual void CheckParam() { }
    protected virtual void PerformSelf(Student o) { }
}
internal class Action<TParam> : Action
{
    protected TParam? Param { get; private set; }
    protected sealed override void CheckParam()
    {
        if (Param is null)
            throw new Exception("Param was not set");
    }
    public Action<TParam> SetParam(TParam param)
    {
        Param = param;
        return this;
    }
    protected override void PerformSelf(Student o) { }
}