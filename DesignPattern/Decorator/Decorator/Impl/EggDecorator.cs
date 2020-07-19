namespace Decorator
{
    public class EggDecorator : BatterCakeDecorator
    {
        public EggDecorator(BatterCake batterCake) : base(batterCake)
        {

        }

        public override decimal Cost()
        {
            return base.Cost() + 1;
        }

        public override string Description()
        {
            return base.Description() + " 加一个鸡蛋1元";
        }
    }
}
