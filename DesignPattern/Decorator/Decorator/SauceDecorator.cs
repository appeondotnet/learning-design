namespace Decorator
{
    public class SauceDecorator : BatterCake
    {
        private readonly BatterCake _batterCake;

        public SauceDecorator(BatterCake batterCake)
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
