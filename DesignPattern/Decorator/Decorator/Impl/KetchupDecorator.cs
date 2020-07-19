namespace Decorator
{
    public class KetchupDecorator : SauceDecorator
    {
        public KetchupDecorator(BatterCake batterCake) : base(batterCake)
        {

        }

        public override decimal Cost()
        {
            return base.Cost() + 1;
        }

        public override string Description()
        {
            return base.Description() + " 加番茄口味1元";
        }
    }
}
