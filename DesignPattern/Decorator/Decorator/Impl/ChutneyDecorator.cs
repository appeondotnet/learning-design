namespace Decorator
{
    public class ChutneyDecorator : SauceDecorator
    {
        public ChutneyDecorator(BatterCake batterCake) : base(batterCake)
        {

        }

        public override decimal Cost()
        {
            return base.Cost() + 1;
        }

        public override string Description()
        {
            return base.Description() + " 加酸辣口味1元";
        }
    }
}
