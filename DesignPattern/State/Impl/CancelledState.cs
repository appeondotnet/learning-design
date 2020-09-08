using System;

namespace State
{
    public class CancelledState : State
    {
        public override string Name => "Cancelled";

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
