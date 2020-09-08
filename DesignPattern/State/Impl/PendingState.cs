using System;

namespace State
{
    public class PendingState : State
    {
        public override string Name => "Pending";

        public override void Start(TaskContext context)
        {
            context.State = new RunningState();
        }

        public override void Cancel(TaskContext context)
        {
            throw new NotImplementedException();
        }
    }
}
