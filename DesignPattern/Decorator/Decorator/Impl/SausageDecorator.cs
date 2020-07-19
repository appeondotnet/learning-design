namespace Decorator
{
    public class SausageDecorator : BatterCakeDecorator
    {
        public SausageDecorator(BatterCake batterCake) : base(batterCake)
        {

        }

        public override decimal Cost()
        {
            return base.Cost() + 2;
        }

        public override string Description()
        {
            return base.Description() + " 加一根香肠2元";
        }
    }
}
