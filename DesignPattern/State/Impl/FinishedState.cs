using System;

namespace State
{
    public class FinishedState : State
    {
        public override string Name => "Finished";

        public override void Start(TaskContext context)
        {
            throw new NotImplementedException();
        }

        public override void Cancel(TaskContext context)
        {
            throw new NotImplementedException();
        }
    }
}
