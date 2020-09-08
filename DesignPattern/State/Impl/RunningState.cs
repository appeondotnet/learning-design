using System;

namespace State
{
    public class RunningState : State
    {
        public override string Name => "Running";

        public override void Start(TaskContext context)
        {
            context.State = new FinishedState();
        }

        public override void Cancel(TaskContext context)
        {
            context.State = new CancelledState();
        }
    }
}
