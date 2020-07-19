using System;

namespace Decorator
{
    public class BatterCakeDecorator : BatterCake
    {
        private readonly BatterCake _batterCake;

        public BatterCakeDecorator(BatterCake batterCake)
        {
            _batterCake = batterCake;
        }

        public override decimal Cost()
        {
            return _batterCake.Cost();
        }

        public override string Description()
        {
            return _batterCake.Description();
        }
    }
}
