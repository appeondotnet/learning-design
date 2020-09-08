namespace State
{
    public abstract class State
    {
        public abstract string Name { get; }

        public abstract void Start(TaskContext context);

        public abstract void Cancel(TaskContext context);
    }
}
