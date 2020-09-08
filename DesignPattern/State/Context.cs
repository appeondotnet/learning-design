using System;

namespace State
{
    public class TaskContext
    {
        private State _state;

        public State State
        {
            get => _state;

            set
            {
                _state = value;

                Console.WriteLine("State：" + _state.Name);
            }
        }

        public void Start()
        {
            State.Start(this);
        }

        public void Cancel()
        {
            State.Cancel(this);
        }
    }
}
